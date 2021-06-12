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
    public partial class OperationParameter : Form
    {
        int Min, Max, Current;
        public delegate void DelegateOperation(int x);


        public event DelegateOperation OnApply;
        private void btnApply_Click(object sender, EventArgs e)
        {
            OnApply?.Invoke(trackBar1.Value);
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblCurrent.Text = trackBar1.Value.ToString();
        }

        public OperationParameter(int min, int max, int current)
        {
            Min = min;
            Max = max;
            Current = current;
            InitializeComponent();
        }
        private void OperationParameter_Load(object sender, EventArgs e)
        {
            lblCurrent.Text = Current.ToString();
            lblMin.Text = Min.ToString();
            lblMax.Text = Max.ToString();
            trackBar1.Minimum = Min;
            trackBar1.Maximum = Max;
            trackBar1.Value = Current;
        }
    }
}
