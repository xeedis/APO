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
    public partial class Mask3x3Form : Form
    {
        private int[,] mask;
        int divisor;

        public int[,] Mask
        {
            get { return mask; }
        }

        public int Divisor
        {
            get { return divisor; }
        }

        public Mask3x3Form()
        {
            mask = new int[3, 3];
            InitializeComponent();
            Recalculate();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Recalculate();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Recalculate()
        {
            mask[0, 0] = ParseOrZero(txtMask1.Text);
            mask[0, 1] = ParseOrZero(txtMask2.Text);
            mask[0, 2] = ParseOrZero(txtMask3.Text);
            mask[1, 0] = ParseOrZero(txtMask4.Text);
            mask[1, 1] = ParseOrZero(txtMask5.Text);
            mask[1, 2] = ParseOrZero(txtMask6.Text);
            mask[2, 0] = ParseOrZero(txtMask7.Text);
            mask[2, 1] = ParseOrZero(txtMask8.Text);
            mask[2, 2] = ParseOrZero(txtMask9.Text);

            if (!checkBox1.Checked)
                divisor = Math.Max(ParseOrZero(txtDivisor.Text), 1);
            else
            {
                divisor = 0;
                foreach (int value in mask)
                {
                    divisor += value;
                }
                divisor = Math.Max(divisor, 1);
                txtDivisor.Text = divisor.ToString();
            }
        }

        private int ParseOrZero(string s)
        {
            try
            {
                return int.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        private void txtDivisor_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask1_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask2_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask3_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask4_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask5_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask6_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask7_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask8_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void txtMask9_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        
    }
}
