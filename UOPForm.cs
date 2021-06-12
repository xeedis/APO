using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    public partial class UOPForm : Form
    {
        public List<Point> points = new List<Point>();
        private Graphics graphicsObj;
        private Point draggingPoint;
        private bool isDragging = false;

        BackgroundWorker bw = new BackgroundWorker();

        public class Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public PointF ToPointF()
            {
                return new PointF(X, Y);
            }
        }

        class PointComparer : IComparer<Point>
        {
            public int Compare(Point x, Point y)
            {
                if (x.X != y.X)
                {
                    return x.X - y.X;
                }
                else
                {
                    return x.Y - y.Y;
                }
            }
        }
        public UOPForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
        }
        private void clearPanel()
        {
            graphicsObj.Clear(pUOP.BackColor);

            graphicsObj.DrawLine(Pens.LightGray, 51, 0, 51, 255);
            graphicsObj.DrawLine(Pens.LightGray, 102, 0, 102, 255);
            graphicsObj.DrawLine(Pens.LightGray, 153, 0, 153, 255);
            graphicsObj.DrawLine(Pens.LightGray, 204, 0, 204, 255);
            graphicsObj.DrawLine(Pens.LightGray, 0, 51, 255, 51);
            graphicsObj.DrawLine(Pens.LightGray, 0, 102, 255, 102);
            graphicsObj.DrawLine(Pens.LightGray, 0, 153, 255, 153);
            graphicsObj.DrawLine(Pens.LightGray, 0, 204, 255, 204);
        }

        private void drawPanel()
        {
            Point a = new Point(0, 255);
            clearPanel();
            points.Sort(new PointComparer());
            int count = points.Count;

            for (int i = 0; i < count; i++)
            {
                graphicsObj.DrawLine(Pens.Black, a.ToPointF(), points[i].ToPointF());
                a = points[i];
                graphicsObj.FillRectangle(Brushes.Black, new Rectangle(a.X - 2, a.Y - 2, 5, 5));
            }

            graphicsObj.DrawLine(Pens.Black, a.ToPointF(), new Point(255, 0).ToPointF());
        }

        private void pUOP_Paint(object sender, PaintEventArgs e)
        {
            graphicsObj = pUOP.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Black, 1);

            clearPanel();

            graphicsObj.DrawLine(myPen, 0, 255, 255, 0);
        }

        private void pUOP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].X - 3 < e.X && points[i].X + 3 > e.X)
                    if (points[i].Y - 3 < e.Y && points[i].Y + 3 > e.Y)
                    {
                        isDragging = true;
                        draggingPoint = points[i];
                        if (bw.IsBusy != true)
                        {
                            bw.RunWorkerAsync();
                        }
                        return;
                    }
            }
        }

        private void pUOP_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                draggingPoint.X = e.X;
                draggingPoint.Y = e.Y;
                if (draggingPoint.X > 255) draggingPoint.X = 255;
                else if (draggingPoint.X < 0) draggingPoint.X = 0;
                if (draggingPoint.Y > 255) draggingPoint.Y = 255;
                else if (draggingPoint.Y < 0) draggingPoint.Y = 0;
                pUOP.Text = "Pozycja X: " + draggingPoint.X.ToString() + " Y: " + draggingPoint.Y.ToString();
            }
        }

        private void pUOP_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    if (points[i].X - 3 < e.X && points[i].X + 3 > e.X)
                        if (points[i].Y - 3 < e.Y && points[i].Y + 3 > e.Y)
                        {
                            points.Remove(points[i]);
                            drawPanel();
                            break;
                        }
                }
            }
            else if (!isDragging)
            {
                points.Add(new Point(e.X, e.Y));
                points.Sort(new PointComparer());
                drawPanel();
            }
            else
            {
                isDragging = false;
            }
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (isDragging)
            {
                drawPanel();
                System.Threading.Thread.Sleep(40);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.DialogResult = DialogResult.OK;
            
        }
    }
}
