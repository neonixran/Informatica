using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico4
{
    public partial class frmPráctico4 : Form
    {
        public frmPráctico4()
        {
            InitializeComponent();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNumA_TextChanged(object sender, EventArgs e)
        {
            txtNAm.Text = txtNumA.Text;
            txtNAs.Text = txtNumA.Text;
        }

        private void txtDenA_TextChanged(object sender, EventArgs e)
        {
            txtDAs.Text = txtDenA.Text;
            txtDAm.Text = txtDenA.Text;
        }

        private void txtNumB_TextChanged(object sender, EventArgs e)
        {
            txtNBm.Text = txtNumB.Text;
            txtNBs.Text = txtNumB.Text;
        }

        private void txtDenB_TextChanged(object sender, EventArgs e)
        {
            txtDBm.Text = txtDenB.Text;
            txtDBs.Text = txtDenB.Text;
        }
    }
}
