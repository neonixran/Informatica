using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryPráctico4
{
    public partial class frmPráctico4 : Form
    {
        public frmPráctico4()
        {
            InitializeComponent();
        }

        int total = 0;
        bool leido = false;

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbArchivo.SelectedItem != null)
                {
                    if (!leido)
                    {
                        StreamReader ListaSuper = new StreamReader(cmbArchivo.SelectedItem.ToString());
                        string dato = ListaSuper.ReadLine();

                        while (dato != null)
                        {
                            string[] datos = dato.Split(';');
                            dgvDatos.Rows.Add(datos[0], datos[1]);
                            dato = ListaSuper.ReadLine();
                            total += int.Parse(datos[1]);
                        }
                        ListaSuper.Close();
                        txtTotal.Text = String.Format("${0}", total);

                        leido = true;
                    }
                    else
                    {
                        MessageBox.Show("Los datos ya fueron leidos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception err)
            {
                if (err.Message.ToString().Contains("No se pudo encontrar el archivo")) {
                    DialogResult result = MessageBox.Show("No se pudo encontrar el archivo ¿Desea crearlo?", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        StreamWriter ListaNueva = new StreamWriter(cmbArchivo.SelectedItem.ToString());
                        ListaNueva.Close();
                        btnLeer.PerformClick();
                        MessageBox.Show("Se creo el archivo", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return;
                }

                MessageBox.Show(err.Message.ToString(), "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (cmbArchivo.SelectedItem != null)
            {
                dgvDatos.Rows.Clear();

                total = 0;
                txtTotal.Text = "$0";

                leido = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbArchivo.SelectedItem != null)
            {
                StreamWriter ListaNueva = new StreamWriter(cmbArchivo.SelectedItem.ToString());
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        ListaNueva.WriteLine(String.Format("{0};{1}", row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()));
                    }
                }
                ListaNueva.Close();
                MessageBox.Show("Lista guardada", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txtTotal.Text, txtTotal.Font);
            txtTotal.Width = size.Width;
        }

        private void dgvDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbArchivo.SelectedItem != null && e.ColumnIndex == 1)
            {
                int newTotal = 0;
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    try
                    {
                        newTotal += row.Cells[1].Value != null ? int.Parse(row.Cells[1].Value.ToString()) : 0;
                    } catch
                    {
                        MessageBox.Show("Ocurrió un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                total = newTotal;
                txtTotal.Text = String.Format("${0}", total);
            }
        }

        private void cmbArchivo_SelectedValueChanged(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
        }
    }
}

