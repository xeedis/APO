using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using APO.Operacje;
namespace APO
{
    public partial class APO : Form
    {
        private int formCounter = 0;
        public Image getImage {get;set;}
        private Image image;
        private Bitmap parentBitmap;
        public APO()
        {
            InitializeComponent();
        }
        private void useFilter(IFilter filter)
        {
            Picture activeChild = (Picture)ActiveMdiChild;

            filter.setImage(activeChild.bitmap);

            if (filter.hasDialog)
                if (!filter.showDialog())
                    return;

            filter.Convert();

            activeChild.refresh();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    image = Image.FromFile(openFileDialog1.FileName);
                    getImage = image;
                    Picture originalForm = new Picture(image);
                    originalForm.MdiParent = this; 
                    originalForm.Text = new StringBuilder("Obraz ").Append(++formCounter).ToString();
                    originalForm.Show();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                      
         
        }
       

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja zbiorcza z ćwiczeń laboratoryjnych\n" +
                "Autor: Kacper Tarnowski\n" +
                "Prowadzący: mgr.inż Łukasz Roszkowiak\n"+
                "Algorytmy Przetwarzania Obrazów 2021\n"+
                "Inżynieria Oprogramowania ID06IO2");
        }

       
        private void bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            useFilter(new GrayScale());
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            Bitmap img = activeForm.bitmap;
            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "BMP(*.BMP)|*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                img.Save(dialog.FileName);
            }
            
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeChild = (Picture)this.ActiveMdiChild;

            if (activeChild != null)
            {
                Picture newChild = new Picture(activeChild);
                newChild.Text = new StringBuilder("Obraz ").Append(++formCounter).ToString();
                newChild.MdiParent = this;
                newChild.Show();

            }
        }

        private void stretchHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            Image<Gray, byte> img= parentBitmap.ToImage<Gray,byte>();
            double[] im_min,im_max;
            Point[] minLocation;
            Point[] maxLocation;
            int new_max = 255;
            int new_min = 0;
            Mat mat = new Mat();
            mat.MinMax(out im_min,out im_max,out minLocation,out  maxLocation);
            if (activeForm!=null)
            {
                
            }
        }

        private void tresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OperationParameter form = new OperationParameter(0, 255, 100);
                form.OnApply += ApplyThreshold;
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApplyThreshold(int x)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            try
            {
                Image<Bgr, byte> bgr = (new Bitmap(image)).ToImage<Bgr, byte>();
                Image<Gray, byte> img_gray = bgr.Convert<Gray, byte>();
                if (activeForm == null)
                {
                    return;
                }
                var img = img_gray.Clone();
                var output = img_gray.ThresholdBinary(new Gray(x), new Gray(255));
                activeForm.loadImage(output.ToBitmap());
                
                activeForm.Show();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void histogramEqualizationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Picture childForm = (Picture)ActiveMdiChild;
            try
            {
                Image<Bgr, byte> bgr = (new Bitmap(image)).ToImage<Bgr, byte>();
                Image<Gray, byte> img_gray = bgr.Convert<Gray, byte>();
                if (childForm == null)
                {
                    return;
                }
                var img = img_gray;
                Mat histeq = new Mat();
                CvInvoke.EqualizeHist(img, histeq);
                childForm.loadImage(histeq.ToBitmap());
                childForm.Show();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void uOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeChild = (Picture)ActiveMdiChild;
            if (activeChild != null)
                useFilter(new UOP());

        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeChild = (Picture)ActiveMdiChild;
            if (activeChild != null)
                activeChild.negative();
        }

        private void posteriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OperationParameter form = new OperationParameter(2, 255, 3);
                form.OnApply += ApplyPosterise;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApplyPosterise(int x)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            try
            {
                activeForm.posterise(x);
                activeForm.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void stretchImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DoubleParameterOperations form = new DoubleParameterOperations(0, 255, 100);
                form.OnApply += ApplyStretchImage;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApplyStretchImage(int x, int y)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.stretchImage(x,y);
            activeForm.Show();   
        }

        private void ąsiedztwaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeChild = (Picture)ActiveMdiChild;

            if (activeChild == null)
                return;

            Mask3x3Form mask3x3Form = new Mask3x3Form();

            if (mask3x3Form.ShowDialog() == DialogResult.Cancel)
                return;
            activeChild.ApplyMask(mask3x3Form.Mask, mask3x3Form.Divisor);
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ChooseImg form = new ChooseImg(MdiChildren);
            form.OnApply += ApplyAndPointOperation;
            form.ShowDialog();
            
        }
        private void ApplyAndPointOperation(int x)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.AND(((Picture)MdiChildren[x]).bitmap);
        }
        private void oRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseImg form = new ChooseImg(MdiChildren);
            form.OnApply += ApplyOrPointOperation;
            form.ShowDialog();
        }
        private void ApplyOrPointOperation(int x)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.OR(((Picture)MdiChildren[x]).bitmap);
        }
        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseImg form = new ChooseImg(MdiChildren);
            form.OnApply += ApplyXorPointOperation;
            form.ShowDialog();
        }
        private void ApplyXorPointOperation(int x)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.XOR(((Picture)MdiChildren[x]).bitmap);
        }
        private void medianFiltrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OperationParameter form = new OperationParameter(0, 9, 5);
                form.OnApply += ApplymedianFiltration;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApplymedianFiltration(int x)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.medianFiltration(x);
            activeForm.Show();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseImg form = new ChooseImg(MdiChildren);
            form.OnApply += ApplyAddPointOperation;
            form.ShowDialog();
        }

        private void ApplyAddPointOperation(int x)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.ADD(((Picture)MdiChildren[x]).bitmap);
            activeForm.Show();
        }

        private void minusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseImg form = new ChooseImg(MdiChildren);
            form.OnApply += ApplyMinusPointOperation;
            form.ShowDialog();
        }

        private void ApplyMinusPointOperation(int x)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.MINUS(((Picture)MdiChildren[x]).bitmap);
            activeForm.Show();  
        }

        private void Erosion4connectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.Erosion(4);
            activeForm.Show();
        }

        private void Erosion8connectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.Erosion(8);
            activeForm.Show();
        }

        private void Dilation4connectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.Dilation(4);
            activeForm.Show();
        }

        private void Dilation8connectedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.Dilation(8);
            activeForm.Show();
        }

        private void Opening4connectedToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Erosion(4);
                activeForm.Dilation(4);
            }  
            activeForm.Show();
        }

        private void Opening8connectedToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Erosion(8);
                activeForm.Dilation(8);
            }
            activeForm.Show();
        }

        private void Closing4connectedToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Dilation(4);
                activeForm.Erosion(4);
            }
            activeForm.Show();
        }

        private void Closing8connectedToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Dilation(8);
                activeForm.Erosion(8);
            }
            activeForm.Show();
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.GaussianBlur(3, 3);
            
            activeForm.Show();
        }

        private void skeletonizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.Skeletonization();

            activeForm.Show();
        }

        private void segmentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.Segmentation();

            activeForm.Show();
        }

        private void watershedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.Watershed();

            activeForm.Show();
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.sobel();

            activeForm.Show();
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.laplacian();

            activeForm.Show();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.Canny();

            activeForm.Show();
            
        }

        private void egzToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void erosionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.ErosionEgz();

            activeForm.Show();
        }

        private void dilationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Picture activeForm = (Picture)ActiveMdiChild;
            if (activeForm != null)
                activeForm.DilationEgz();

            activeForm.Show();
        }
    }
}
