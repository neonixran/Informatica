using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVelocidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lst200m.Items.Add("PAIS ATLETA");
            lst400m.Items.Add("PAIS ATLETA");
        }

        static double calcularVelocidad(double distancia, double tiempo)
        {
            double kilometros = distancia / 1000;
            double horas = tiempo / 3600;

            double velocidad = kilometros / horas;


            return velocidad;
        }

        static int cantidadRegistros()
        {
            StreamReader datos = new StreamReader("../../../atletismo.txt");

            string dato = datos.ReadLine();

            int contador = -1;
            while (dato != null)
            {
                contador++;
                dato = datos.ReadLine();
            }

            datos.Close();

            return contador;
        }

        static double[] obtenerVelocidades()
        {
            StreamReader datos = new StreamReader("../../../atletismo.txt");

            string dato = datos.ReadLine();
            dato = datos.ReadLine();

            /*
             * campo[0]: Nombre
             * campo[1]: País
             * campo[2]: Distancia
             * campo[3]: Tiempo
             */

            int num_atletas = cantidadRegistros();
            double[] velocidades = new double[num_atletas];

            int i = 0;
            while (dato != null)
            {
                string[] campo = dato.Split(';');

                int dist = int.Parse(campo[2]);

                double tiempo = double.Parse(campo[3]);
                double velocidad = calcularVelocidad(dist, tiempo);
                velocidades[i] = velocidad;

                dato = datos.ReadLine();
                i++;
            }

            datos.Close();

            return velocidades;
        }

        static int obtenerPosVeloz(double[] vs)
        {
            double mayor = vs[0];
            int pos_mayor = 0;

            for (int i = 1; i < vs.Length; i++)
            {
                if (mayor < vs[i])
                {
                    mayor = vs[i];
                    pos_mayor = i;
                }
            }

            return pos_mayor;
        }

        static string[] obtenerDatosVeloz(int pos)
        {
            StreamReader datos = new StreamReader("../../../atletismo.txt");

            string dato = datos.ReadLine();

            while (dato != null)
            {
                string[] campo = dato.Split(';');


                dato = datos.ReadLine();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int distancia = int.Parse(txtDistancia.Text);
                double tiempo = double.Parse(txtTiempo.Text);
                
                double velocidad = calcularVelocidad(distancia, tiempo);
                txtVelocidad.Text = velocidad.ToString("N1");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObtenerVeloces_Click(object sender, EventArgs e)
        {
            try
            {

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
