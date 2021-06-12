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
    public partial class DoubleParameterOperations : Form
    {
        int Min, Max, Current;
        public delegate void DelegateDoubleOperation(int x,int y);
        public event DelegateDoubleOperation OnApply;
        public DoubleParameterOperations()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnApply?.Invoke(trackBar1.Value, trackBar2.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblCurrentStart.Text = trackBar1.Value.ToString();
        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblCurrentEnd.Text = trackBar2.Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public DoubleParameterOperations(int min, int max, int current)
        {
            Min = min;
            Max = max;
            Current = current;
            InitializeComponent();
        }
        private void DoubleParameterOperations_Load(object sender, EventArgs e)
        {
            lblMinStart.Text = Min.ToString();
            lblMaxStart.Text = Max.ToString();
            lblCurrentStart.Text = Current.ToString();
            trackBar1.Minimum = Min;
            trackBar1.Maximum = Max;
            trackBar1.Value = Current;

            lblMinEnd.Text = Min.ToString();
            lblMaxEnd.Text = Max.ToString();
            lblCurrentEnd.Text = Current.ToString();
            trackBar2.Minimum = Min;
            trackBar2.Maximum = Max;
            trackBar2.Value = Current;

        }
    }
}
