
namespace pryPráctico6
{
    partial class FrmPráctico5
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrdenados = new System.Windows.Forms.TextBox();
            this.btnObtenerMayor = new System.Windows.Forms.Button();
            this.lblMayor = new System.Windows.Forms.Label();
            this.btnPromediar = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Valores:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIngreso.Location = new System.Drawing.Point(162, 10);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(438, 24);
            this.txtIngreso.TabIndex = 1;
            this.txtIngreso.Text = "Escriba varios números separados por un espacio";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.Orange;
            this.btnOrdenar.Location = new System.Drawing.Point(202, 80);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(210, 37);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar los datos";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos ordenados:";
            // 
            // txtOrdenados
            // 
            this.txtOrdenados.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtOrdenados.Location = new System.Drawing.Point(162, 124);
            this.txtOrdenados.Name = "txtOrdenados";
            this.txtOrdenados.Size = new System.Drawing.Size(438, 24);
            this.txtOrdenados.TabIndex = 1;
            // 
            // btnObtenerMayor
            // 
            this.btnObtenerMayor.Location = new System.Drawing.Point(71, 160);
            this.btnObtenerMayor.Name = "btnObtenerMayor";
            this.btnObtenerMayor.Size = new System.Drawing.Size(92, 64);
            this.btnObtenerMayor.TabIndex = 3;
            this.btnObtenerMayor.Text = "Obtener el Mayor:";
            this.btnObtenerMayor.UseVisualStyleBackColor = true;
            // 
            // lblMayor
            // 
            this.lblMayor.BackColor = System.Drawing.Color.MistyRose;
            this.lblMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor.Location = new System.Drawing.Point(184, 160);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(79, 64);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Valor Mayor";
            this.lblMayor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPromediar
            // 
            this.btnPromediar.Location = new System.Drawing.Point(332, 160);
            this.btnPromediar.Name = "btnPromediar";
            this.btnPromediar.Size = new System.Drawing.Size(92, 64);
            this.btnPromediar.TabIndex = 3;
            this.btnPromediar.Text = "Obtener el promedio:";
            this.btnPromediar.UseVisualStyleBackColor = true;
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.Color.Khaki;
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(445, 160);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(79, 64);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Blue;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Lime;
            this.btnIngresar.Location = new System.Drawing.Point(172, 40);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(270, 37);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Fin Ingreso de Datos";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // FrmPráctico5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 242);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnPromediar);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.btnObtenerMayor);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtOrdenados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPráctico5";
            this.Text = "Operaciones con Arreglos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrdenados;
        private System.Windows.Forms.Button btnObtenerMayor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Button btnPromediar;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnIngresar;
    }
}

