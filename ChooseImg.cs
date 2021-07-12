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
    public partial class ChooseImg : Form
    {

        public delegate void DelegateOperation(int x);
        public event DelegateOperation OnApply;    
        public int combovalue;
        public ChooseImg(Form[] forms)
        {
            InitializeComponent();
            
            foreach(Form form in forms)
            {
                cmbChoose.Items.Add(form.Text);
            }
        }

        private void cmbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                combovalue = (int)cmbChoose.SelectedItem;
            }catch(Exception ex)
            {

            }
            
            OnApply?.Invoke(combovalue);
        }
    }
}
