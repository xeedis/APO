﻿using Emgu.CV;
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
            Graphics graphicsObj =pHistogram.CreateGraphics();
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
    }

}

