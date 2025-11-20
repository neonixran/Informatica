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

namespace pryTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para validar si los tres valores de a, b y c forman un triángulo.
        static bool comprobarTriángulo(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        // Método para calcular el área de un triángulo.
        static double calcularArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        // Método para determinar el tipo de triángulo.
        static string determinarTriángulo(double a, double b, double c)
        {
            string tipoTriángulo = "";

            if (a == b && b == c)
            {
                tipoTriángulo = "Equilátero";
            }
            else if (a == b || a == c || b == c)
            {
                tipoTriángulo = "Isósceles";
            }
            else
            {
                tipoTriángulo = "Escaleno";
            }

            return tipoTriángulo;
        }


        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = double.Parse(txtLadoA.Text);
                double ladoB = double.Parse(txtLadoB.Text);
                double ladoC = double.Parse(txtLadoC.Text);
                bool esTriángulo = comprobarTriángulo(ladoA, ladoB, ladoC);

                if (esTriángulo)
                {
                    double area = calcularArea(ladoA, ladoB, ladoC);
                    txtResultado.Text = area.ToString("N1");
                } else
                {
                    txtResultado.Text = "NO ES VÁLIDO";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Leer datos del archivo "triángulo.txt"
            StreamReader triángulos = new StreamReader("../../Triángulos.txt");
            string registros = triángulos.ReadLine();

            int triángulosEscalenos = 0;

            while (registros != null)
            {
                /*
                 * [0]: ladoA
                 * [1]: ladoB
                 * [2]: ladoC
                 */
                string[] lados = registros.Split(';');

                double ladoA = double.Parse(lados[0]);
                double ladoB = double.Parse(lados[1]);
                double ladoC = double.Parse(lados[2]);

                bool esTriángulo = comprobarTriángulo(ladoA, ladoB, ladoC);

                if (esTriángulo)
                {
                    string tipoTriángulo = determinarTriángulo(ladoA, ladoB, ladoC);

                    if (tipoTriángulo == "Escaleno")
                    {

                        triángulosEscalenos++;
                    }
                }

                registros = triángulos.ReadLine();
            }

            triángulos.Close();

            triángulos = new StreamReader("../../Triángulos.txt");
            registros = triángulos.ReadLine();

            // Calcular el área de los triángulos escalenos y guardarlos en el arreglo
            double[] áreas = new double[triángulosEscalenos];
            int contador = 0;

            while (registros != null)
            {
                /*
                 * [0]: ladoA
                 * [1]: ladoB
                 * [2]: ladoC
                 */
                string[] lados = registros.Split(';');

                double ladoA = double.Parse(lados[0]);
                double ladoB = double.Parse(lados[1]);
                double ladoC = double.Parse(lados[2]);

                bool esTriángulo = comprobarTriángulo(ladoA, ladoB, ladoC);

                if (esTriángulo)
                {
                    string tipoTriángulo = determinarTriángulo(ladoA, ladoB, ladoC);

                    if (tipoTriángulo == "Escaleno")
                    {
                        double área = calcularArea(ladoA, ladoB, ladoC);
                        áreas[contador] = área;

                        contador++;
                    }
                }

                registros = triángulos.ReadLine();
            }

            triángulos.Close();

            // Imprimir cantidad de triángulos escalenos
            txtCantEscalenos.Text = triángulosEscalenos.ToString();

            // Guardar las áreas de mayor a menor de los triángulos escalenos
            Array.Sort(áreas);
            Array.Reverse(áreas); // Se hace un reverse, ya que sort ordena de menor a mayor

            StreamWriter escalenos = new StreamWriter("..//..//escalenos.txt");

            for (int i = 0; i < áreas.Length; i++)
            {
                escalenos.WriteLine(áreas[i].ToString("N1"));
            }

            escalenos.Close();
        }
    }
}

