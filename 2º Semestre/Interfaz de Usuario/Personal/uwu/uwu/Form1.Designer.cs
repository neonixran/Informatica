namespace uwu
{
    partial class Calculadora
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            title = new Label();
            peso_title = new Label();
            peso_textbox = new TextBox();
            altura_title = new Label();
            altura_textbox = new TextBox();
            calcular_button = new Button();
            SuspendLayout();

            // Titulo
            title.AutoSize = true;
            title.Font = new Font("Verdana", 10F, FontStyle.Bold);
            title.ForeColor = Color.Snow;
            title.Location = new Point(51, 9);
            title.Name = "title";
            title.Size = new Size(163, 20);
            title.TabIndex = 0;
            title.Text = "Calculadora IMC";
 
            // Peso
            peso_title.AutoSize = true;
            peso_title.Font = new Font("Verdana", 8F, FontStyle.Bold);
            peso_title.ForeColor = Color.Snow;
            peso_title.Location = new Point(51, 56);
            peso_title.Name = "peso_title";
            peso_title.Size = new Size(51, 17);
            peso_title.TabIndex = 1;
            peso_title.Text = "Peso:";
 
            peso_textbox.BackColor = Color.FromArgb(226, 226, 226);
            peso_textbox.ForeColor = SystemColors.InactiveCaptionText;
            peso_textbox.Location = new Point(51, 76);
            peso_textbox.Name = "peso_textbox";
            peso_textbox.PlaceholderText = "Ingrese su peso en kg...";
            peso_textbox.Size = new Size(177, 27);
            peso_textbox.TabIndex = 2;
            peso_textbox.TextChanged += Peso_TextChanged;

            // Altura
            altura_title.AutoSize = true;
            altura_title.Font = new Font("Verdana", 8F, FontStyle.Bold);
            altura_title.ForeColor = Color.Snow;
            altura_title.Location = new Point(51, 125);
            altura_title.Name = "altura_title";
            altura_title.Size = new Size(61, 17);
            altura_title.TabIndex = 3;
            altura_title.Text = "Altura:";

            altura_textbox.BackColor = Color.FromArgb(226, 226, 226);
            altura_textbox.Location = new Point(51, 145);
            altura_textbox.Name = "altura_textbox";
            altura_textbox.PlaceholderText = "Ingrese su altura en cm...";
            altura_textbox.Size = new Size(177, 27);
            altura_textbox.TabIndex = 4;
            altura_textbox.TextChanged += Altura_TextChanged;

            // Botón para calcular IMC
            calcular_button.BackColor = Color.FromArgb(226, 226, 226);
            calcular_button.Font = new Font("Verdana", 8F);
            calcular_button.Location = new Point(82, 200);
            calcular_button.Name = "calcular_button";
            calcular_button.Size = new Size(94, 29);
            calcular_button.TabIndex = 5;
            calcular_button.Text = "Calcular";
            calcular_button.UseVisualStyleBackColor = false;
            calcular_button.Click += calcularButton;

            // Ventana principal
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 95, 94);
            ClientSize = new Size(255, 256);
            Controls.Add(calcular_button);
            Controls.Add(altura_textbox);
            Controls.Add(altura_title);
            Controls.Add(peso_textbox);
            Controls.Add(peso_title);
            Controls.Add(title);
            Name = "Calculadora";
            Text = "IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label peso_title;
        private TextBox peso_textbox;
        private Label altura_title;
        private TextBox altura_textbox;
        private Button calcular_button;
    }
}
