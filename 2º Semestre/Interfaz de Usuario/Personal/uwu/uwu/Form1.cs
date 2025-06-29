namespace uwu
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void calcularButton(object sender, EventArgs e)
        {
            double peso = Convert.ToInt32(peso_textbox.Text);
            double altura = Convert.ToDouble(altura_textbox.Text);

            double imc = Math.Round(peso / (Math.Pow((altura / 100), 2)), 1);
            string type = "";

            if (imc < 18)
            {
                type = "Bajo peso";
            }
            else if (imc < 25)
            {
                type = "Saludable";
            }
            else if (imc < 30)
            {
                type = "Sobrepeso";
            }
            else if (imc < 35)
            {
                type = "Obesidad grado I";
            }
            else if (imc < 40)
            {
                type = "Obesidad grado II";
            }
            else
            {
                type = "Obesidad grado III";   
            }

            MessageBox.Show($"Su IMC: {imc}\nSu categoría: {type}");
        }

        private void Peso_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(peso_textbox.Text, out int peso)) // Comprueba que el texto es un número entero
            {
                peso_textbox.Clear();
                return;
            }

            if (peso > 500)
            {
                MessageBox.Show("El peso no puede ser mayor a 500 kg."); // Muestra un mensaje de error si el peso es mayor a 500 kg
                peso_textbox.Clear();
            }
        }
        
        private void Altura_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(altura_textbox.Text, out int peso)) // Comprueba que el texto es un número entero
            {
                altura_textbox.Clear(); // Elimina el texto si no es un número válido
                return;
            }

            if (peso > 251)
            {
                MessageBox.Show("La altura no puede ser mayor a 251 cm");
                altura_textbox.Clear();
            }
        }
    }
}
