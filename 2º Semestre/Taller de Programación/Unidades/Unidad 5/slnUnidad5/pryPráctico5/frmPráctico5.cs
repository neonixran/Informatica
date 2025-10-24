using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico5
{
    public partial class frmPráctico5 : Form
    {
        public frmPráctico5()
        {
            InitializeComponent();
        }
        static bool ValidaCorreo(string email)
        {
            if (email.Contains("@") && email.Contains(".") && !String.IsNullOrWhiteSpace(email) && !email.Contains("ñ")) 
            {
                foreach (char c in email)
                {
                    if (!char.IsUpper(c))
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (ValidaCorreo(txtEmail.Text))
            {
                MessageBox.Show("Email OK", "BIEN");
            }
            else
                MessageBox.Show("Email incorrecto", "MAL");
        }
    }
}
