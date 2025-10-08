using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryContraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            /*
                Requisitos:
                - Longitud desde 8 caracteres.
                - Debe cumplir en tener números, mayúsculas o minúsculas
             */
            if (txtContraseña.Text.Length < 8)
            {
                MessageBox.Show("La longitud debe ser mayor a 8 caracteres", "Longitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseñaR.Clear();
                txtContraseña.Focus();
                return;
            }

            if (txtContraseña.Text != txtContraseñaR.Text)
            {
                MessageBox.Show("Las contraseñas no son las mismas", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtContraseñaR.Clear();
                txtContraseña.Focus();
                return;
            }

            int numeros = 0;
            int mayusculas_minisculas = 0;

            foreach (char ch in txtContraseña.Text)
            {
                if (Char.IsNumber(ch))
                {
                    numeros++;
                }

                if (Char.IsUpper(ch) || Char.IsLower(ch))
                {
                    mayusculas_minisculas++;
                }
            }

            if (numeros <= 0)
            {
                MessageBox.Show("Debe contener números", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if (mayusculas_minisculas <= 0)
            {
                MessageBox.Show("Debe contener mayúsculas o minúsculas", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (numeros > 0 && mayusculas_minisculas > 0)
            {
                MessageBox.Show("Contraseña robusta", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Contraseña débil", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
