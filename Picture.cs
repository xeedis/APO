using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;


namespace APO
{
    public partial class Picture : Form
    {
        private APO parent;
        private int[] histogram;
        public Bitmap bitmap;
        private APO main;
        private Image getImage;
        private Image img;
        private APO aPO;
        private Picture activeForm;

        public Picture()
        {

            InitializeComponent();


        }
        public Picture(Image img)
        {
            InitializeComponent();
            this.img = img;
        }
        public Picture(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
        }

        public Picture(APO aPO)
        {
            this.aPO = aPO;
        }

        public Picture(Picture activeForm)
        {
            bitmap = new Bitmap(activeForm.bitmap);
            pbImageToShow.Image = bitmap;
            InitializeComponent();
        }

        private void Picture_Load(object sender, EventArgs e)
        {
            pbImageToShow.Image = img;
            bitmap = (Bitmap)img;
            refresh();

        }
        public void loadImage(Bitmap bmp)
        {
            pbImageToShow.Image = bmp;
            bitmap = bmp;
            refresh();
        }
        public Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBMP = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(newBMP);
            gfx.DrawImage(src, 0, 0);
            return newBMP;
        }
        public void refresh()
        {
            pbImageToShow.Refresh();
            drawHistogram();
        }
        #region Histogram
        private int[] GetHistogram(Bitmap picture)
        {
            int[] myHistogram = new int[256];

            BitmapData bmd = picture.LockBits(new Rectangle(0, 0, picture.Size.Width, picture.Size.Height),
                            System.Drawing.Imaging.ImageLockMode.ReadOnly,
                            picture.PixelFormat);

            int PixelSize = 0;
            switch (picture.PixelFormat)
            {
                case PixelFormat.Format32bppArgb:
                    PixelSize = 4;
                    break;
                case PixelFormat.Format24bppRgb:
                    PixelSize = 3;
                    break;
            }

            unsafe
            {
                for (int y = 0; y < bmd.Height; y++)
                {
                    byte* row = (byte*)bmd.Scan0 + (y * bmd.Stride);

                    for (int x = 0; x < bmd.Width; x++)
                    {
                        byte color = (byte)((row[x * PixelSize] + row[x * PixelSize + 1] + row[x * PixelSize + 2]) / 3);
                        myHistogram[color]++;
                    }
                }
            }

            picture.UnlockBits(bmd);

            return myHistogram;
        }
        private void drawHistogram()
        {
            histogram = GetHistogram(bitmap);
            Graphics graphicsObj = pHistogram.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Black, 1);

            long max = histogram.Max();
            graphicsObj.Clear(pHistogram.BackColor);
            for (int i = 0; i < 256; i++)
            {
                graphicsObj.DrawLine(myPen, i, 150, i, 150 - histogram[i] * 150 / max);
            }
        }
        
        private void pHistogram_Paint(object sender, PaintEventArgs e)
        {
            if (bitmap != null)
            {
                drawHistogram();
            }
            else
            {
                MessageBox.Show(" Nie można stworzyć histogramu, brak obrazu!");
            }
        }

        private void pHistogram_MouseMove(object sender, MouseEventArgs e)
        {
            labelLevel.Text = e.X.ToString();
            if (e.X <= 256)
            {
                labelAmount.Text = histogram[e.X].ToString();
            }
            
        }
        #endregion

        public void negative()
        {
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color c = bitmap.GetPixel(j, i);

                    bitmap.SetPixel(j, i, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void stretchImage(int x, int y)
        {
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color c = bitmap.GetPixel(j, i);
                    int color = 0;

                    if (c.R >= x && c.R <= y)
                    {
                        color = 255 - (255 * (y - c.R) / (y - x));
                    }
                    bitmap.SetPixel(j, i, Color.FromArgb(color, color, color));
                }
            }
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void posterise(int x)
        {
            double prog = 256 / (x - 1);

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color c = bitmap.GetPixel(j, i);

                    int color = 255;

                    for (int k = 0; k < x - 1; k++)
                    {
                        if (c.R < prog * (k + 0.5))
                        {
                            color = (int)prog * k;
                            break;
                        }
                    }

                    bitmap.SetPixel(j, i, Color.FromArgb(color, color, color));
                }
            }
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void ApplyMask(int[,] mask, int divisor)
        {
            FastBitmap bmp = new FastBitmap(bitmap);
            FastBitmap bitmap2 = new FastBitmap(bitmap);

            if (divisor == 0) divisor = 1;

            int size = (int)Math.Sqrt(mask.Length);
            Point[,] temp = new Point[size, size];

            int index = size - size / 2 - 1;
            for (int i = -index; i <= index; i++)
                for (int j = -index; j <= index; j++)
                    temp[i + index, j + index] = new Point(i, j);

            for (int x = index; x < bmp.Width - index; x++)
            {
                for (int y = index; y < bmp.Height - index; y++)
                {
                    int newColor = 0;
                    for (int k = 0; k < size; k++)
                    {
                        for (int l = 0; l < size; l++)
                        {
                            byte oldColor = bmp[x + temp[k, l].X, y + temp[k, l].Y];
                            newColor += mask[k, l] * oldColor;
                        }
                    }
                    newColor /= divisor;

                    // Skalowanie: Metoda 3
                    if (newColor > bitmap2.Levels - 1) newColor = bitmap2.Levels - 1;
                    else if (newColor < 0) newColor = 0;

                    bitmap2[x, y] = (byte)newColor;
                }
            }

            bitmap2.Unlock();
            bitmap = bitmap2.Bitmap;
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void AND(Bitmap bitmap2)
        {
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color c = bitmap.GetPixel(j, i);
                    Color d = bitmap2.GetPixel(j, i);

                    int color = c.R & d.R;

                    bitmap.SetPixel(j, i, Color.FromArgb(color, color, color));
                }
            }
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void OR(Bitmap bitmap2)
        {
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color c = bitmap.GetPixel(j, i);
                    Color d = bitmap2.GetPixel(j, i);

                    int color = c.R | d.R;

                    bitmap.SetPixel(j, i, Color.FromArgb(color, color, color));
                }
            }
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void XOR(Bitmap bitmap2)
        {
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color c = bitmap.GetPixel(j, i);
                    Color d = bitmap2.GetPixel(j, i);

                    int color = c.R ^ d.R;

                    bitmap.SetPixel(j, i, Color.FromArgb(color, color, color));
                }
            }
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void ADD(Bitmap bitmap2)
        {
            for (int i = 0; i < bitmap.Height; ++i)
            {
                for (int j = 0; j < bitmap.Width; ++j)
                {
                    Color c = bitmap.GetPixel(j, i);
                    Color d = bitmap2.GetPixel(j, i);
                    int red = (c.R + d.R) / 2;
                    bitmap.SetPixel(j, i, Color.FromArgb(red, red, red));
                }
            }
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void MINUS(Bitmap bitmap2)
        {
            for (int i = 0; i < bitmap.Height; ++i)
            {
                for (int j = 0; j < bitmap.Width; ++j)
                {
                    Color c = bitmap.GetPixel(j, i);
                    Color d = bitmap2.GetPixel(j, i);
                    int red = Math.Abs(c.R - d.R);
                    bitmap.SetPixel(j, i, Color.FromArgb(red, red, red));
                }
            }
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void medianFiltration(int value)
        {
            FastBitmap bmp = new FastBitmap(bitmap);

            int filterSize = value;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    byte[] neighbours = new byte[filterSize * filterSize];
                    int a = 0;
                    for (int k = -filterSize / 2; k <= filterSize / 2; ++k)
                        for (int l = -filterSize / 2; l <= filterSize / 2; ++l)
                            neighbours[a++] = bmp[x + k, y + l];

                    Array.Sort(neighbours);
                    if (neighbours.Length % 2 == 1)
                        bmp[x, y] = neighbours[neighbours.Length / 2];
                    else
                        bmp[x, y] = (byte)Math.Min((neighbours[neighbours.Length / 2] + neighbours[(neighbours.Length / 2) + 1]) / 2, bmp.Levels - 1);
                }
            }
            bmp.Unlock();
            bitmap = bmp.Bitmap;
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();

        }
        public void sobel()
        {
            Image<Gray, byte> imgGray = bitmap.ToImage<Gray, byte>();
            Image<Gray, float> imgSobel = new Image<Gray,float>(imgGray.Width,imgGray.Height,new Gray(0));
            imgSobel = imgGray.Sobel(1, 1, 3);
            bitmap = imgSobel.ToBitmap();
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void laplacian()
        {
            Image<Gray, byte> imgGray = bitmap.ToImage<Gray, byte>();
            Image<Gray, float> imgLaplacian = new Image<Gray, float>(imgGray.Width, imgGray.Height, new Gray(0));
            imgLaplacian = imgGray.Laplace(3);
            bitmap = imgLaplacian.ToBitmap();
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void Canny()
        {
            Image<Gray, byte> imgGray = bitmap.ToImage<Gray, byte>();
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));
            imgCanny = imgGray.Canny(50, 20);
            bitmap = imgCanny.ToBitmap();
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void Erosion(int value)
        {
            FastBitmap bmp = new FastBitmap(bitmap);

            int i, j, pam;
            int[,] erode = new int[bmp.Width, bmp.Height];
            int[,] tab = new int[bmp.Width, bmp.Height];

            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                    tab[x, y] = bmp[x, y];

            for (i = 1; i < bmp.Height - 1; i++)
            {
                for (j = 1; j < bmp.Width - 1; j++)
                {
                    pam = tab[j, i];

                    if (value == 4)
                    {
                        if (pam > tab[j + 1, i]) pam = tab[j + 1, i];
                        if (pam > tab[j + 1, i + 1]) pam = tab[j + 1, i + 1];
                        if (pam > tab[j, i + 1]) pam = tab[j, i + 1];
                        if (pam > tab[j - 1, i + 1]) pam = tab[j - 1, i + 1];
                        if (pam > tab[j - 1, i]) pam = tab[j - 1, i];
                        if (pam > tab[j - 1, i - 1]) pam = tab[j - 1, i - 1];
                        if (pam > tab[j, i - 1]) pam = tab[j, i - 1];
                        if (pam > tab[j + 1, i - 1]) pam = tab[j + 1, i - 1];
                    }
                    else if (value == 8)
                    {
                        if (pam > tab[j + 1, i]) pam = tab[j + 1, i];
                        if (pam > tab[j, i + 1]) pam = tab[j, i + 1];
                        if (pam > tab[j - 1, i]) pam = tab[j - 1, i];
                        if (pam > tab[j, i - 1]) pam = tab[j, i - 1];
                    }

                    erode[j, i] = pam;
                }
            }

            for (i = 0; i < bmp.Height; i++)
                for (j = 0; j < bmp.Width; j++)
                    bmp[j, i] = (byte)erode[j, i];

            bmp.Unlock();
            bitmap = bmp.Bitmap;
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void Dilation(int value)
        {
            FastBitmap bmp = new FastBitmap(bitmap);

            int i, j, pam;
            int[,] dilate = new int[bmp.Width, bmp.Height];
            int[,] tab = new int[bmp.Width, bmp.Height];

            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                    tab[x, y] = bmp[x, y];

            for (i = 1; i < bmp.Height - 1; i++)
            {
                for (j = 1; j < bmp.Width - 1; j++)
                {
                    pam = tab[j, i];

                    if (value == 4)
                    {
                        if (pam <= tab[j + 1, i]) pam = tab[j + 1, i];
                        if (pam <= tab[j + 1, i + 1]) pam = tab[j + 1, i + 1];
                        if (pam <= tab[j, i + 1]) pam = tab[j, i + 1];
                        if (pam <= tab[j - 1, i + 1]) pam = tab[j - 1, i + 1];
                        if (pam <= tab[j - 1, i]) pam = tab[j - 1, i];
                        if (pam <= tab[j - 1, i - 1]) pam = tab[j - 1, i - 1];
                        if (pam <= tab[j, i - 1]) pam = tab[j, i - 1];
                        if (pam <= tab[j + 1, i - 1]) pam = tab[j + 1, i - 1];
                    }
                    else if (value == 8)
                    {
                        if (pam <= tab[j + 1, i]) pam = tab[j + 1, i];
                        if (pam <= tab[j, i + 1]) pam = tab[j, i + 1];
                        if (pam <= tab[j - 1, i]) pam = tab[j - 1, i];
                        if (pam <= tab[j, i - 1]) pam = tab[j, i - 1];
                    }

                    dilate[j, i] = pam;
                }
            }

            for (i = 0; i < bmp.Height; i++)
                for (j = 0; j < bmp.Width; j++)
                    bmp[j, i] = (byte)dilate[j, i];

            bmp.Unlock();
            bitmap = bmp.Bitmap;
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void GaussianBlur(int x, int y)
        {
            Image<Bgr, byte> img = bitmap.ToImage<Bgr, byte>();
            var imageOutput = new Image<Bgr, byte>(img.Height, img.Width);
            img.Laplace(3);
            CvInvoke.GaussianBlur(img, imageOutput, new Size(x, y), 0, 0);

            pbImageToShow.Image = imageOutput.ToBitmap();
            bitmap = imageOutput.ToBitmap();
            pbImageToShow.Refresh();
            drawHistogram();

        }
        public void Skeletonization()
        {
            FastBitmap bmp = new FastBitmap(bitmap);

            int[] dx = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int[] dy = { 1, 1, 0, -1, -1, -1, 0, 1 };

            bool[,] img = new bool[bmp.Width, bmp.Height];
            int W = bmp.Width;
            int H = bmp.Height;
            for (int i = 0; i < bmp.Width; ++i)
            {
                for (int j = 0; j < bmp.Height; ++j)
                {
                    img[i, j] = bmp[i, j] < 128;
                }
            }


            bool pass = false;
            LinkedList<Point> list;
            do
            {
                pass = !pass;
                list = new LinkedList<Point>();

                for (int x = 1; x < W - 1; ++x)
                {
                    for (int y = 1; y < H - 1; ++y)
                    {
                        if (img[x, y])
                        {
                            int cnt = 0;
                            int hm = 0;
                            bool prev = img[x - 1, y + 1];
                            for (int i = 0; i < 8; ++i)
                            {
                                bool cur = img[x + dx[i], y + dy[i]];
                                hm += cur ? 1 : 0;
                                if (prev && !cur) ++cnt;
                                prev = cur;
                            }
                            if (hm > 1 && hm < 7 && cnt == 1)
                            {
                                if (pass && (!img[x + 1, y] || !img[x, y + 1] || !img[x, y - 1] && !img[x - 1, y]))
                                {
                                    list.AddLast(new Point(x, y));
                                }
                                if (!pass && (!img[x - 1, y] || !img[x, y - 1] || !img[x, y + 1] && !img[x + 1, y]))
                                {
                                    list.AddLast(new Point(x, y));
                                }
                            }
                        }

                    }
                }
                foreach (Point p in list)
                {
                    img[p.X, p.Y] = false;
                }
            } while (list.Count != 0);

            for (int x = 0; x < W; ++x)
            {
                for (int y = 0; y < H; ++y)
                {
                    bmp[x, y] = (byte)(img[x, y] ? 0 : bmp.Levels - 1);
                }
            }

            bmp.Unlock();
            bitmap = bmp.Bitmap;
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void Segmentation()
        {
            Image<Gray, byte> imgGray = bitmap.ToImage<Gray, byte>();
            //binarization
            Image<Gray, byte> imgOutput = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));
            CvInvoke.Threshold(imgGray, imgOutput, 100, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
            bitmap = imgOutput.ToBitmap();
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void Watershed()
        {
            var img = bitmap.ToImage<Bgr, byte>();
            

            var mask = img.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
            Mat distanceTransform = new Mat();
            CvInvoke.DistanceTransform(mask, distanceTransform, null, Emgu.CV.CvEnum.DistType.L2, 3);
            CvInvoke.Normalize(distanceTransform, distanceTransform, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);
            var markers = distanceTransform.ToImage<Gray, byte>().ThresholdBinary(new Gray(50), new Gray(255));
            CvInvoke.ConnectedComponents(markers, markers);
            var finalMarkers = markers.Convert<Gray, Int32>();
            CvInvoke.Watershed(img, finalMarkers);
            Image<Gray, byte> boundaries = finalMarkers.Convert<byte>(delegate (Int32 x)
            {
                return (byte)(x == -1 ? 255 : 0);
            });
            boundaries._Dilate(1);
            img.SetValue(new Bgr(255, 0, 0),boundaries);
            bitmap = img.ToBitmap();
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void ErosionEgz()
        {
            Image<Gray, byte> imgGray = bitmap.ToImage<Gray, byte>();
            Image<Gray, byte> imgOutput = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));
            var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
            CvInvoke.Erode(imgGray, imgOutput,element, new Point(-1, -1),3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0));
            bitmap = imgOutput.ToBitmap();
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }
        public void DilationEgz()
        {
            Image<Gray, byte> imgGray = bitmap.ToImage<Gray, byte>();
            Image<Gray, byte> imgOutput = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));
            var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
            CvInvoke.Dilate(imgGray, imgOutput, element, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0));
            bitmap = imgOutput.ToBitmap();
            pbImageToShow.Image = bitmap;
            pbImageToShow.Refresh();
            drawHistogram();
        }

    }
}

