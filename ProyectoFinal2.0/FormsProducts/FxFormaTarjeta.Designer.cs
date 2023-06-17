namespace ProyectoFinal2._0.FormsProducts
{
    partial class FxFormaTarjeta
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtCodigoDeSeguridad = new TextBox();
            label4 = new Label();
            txtExpiracion = new TextBox();
            label3 = new Label();
            txtNumeroTarjeta = new TextBox();
            label2 = new Label();
            txtNombreTitular = new TextBox();
            label1 = new Label();
            btnValidarTarjeta = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtCodigoDeSeguridad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtExpiracion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNumeroTarjeta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombreTitular);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 183);
            panel1.TabIndex = 0;
            // 
            // txtCodigoDeSeguridad
            // 
            txtCodigoDeSeguridad.Location = new Point(316, 46);
            txtCodigoDeSeguridad.Name = "txtCodigoDeSeguridad";
            txtCodigoDeSeguridad.Size = new Size(117, 23);
            txtCodigoDeSeguridad.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(330, 28);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 15;
            label4.Text = "C. de seguridad";
            // 
            // txtExpiracion
            // 
            txtExpiracion.Location = new Point(316, 123);
            txtExpiracion.Name = "txtExpiracion";
            txtExpiracion.Size = new Size(110, 23);
            txtExpiracion.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(316, 90);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 13;
            label3.Text = "Expiracion (mm/yy )";
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Location = new Point(12, 123);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(266, 23);
            txtNumeroTarjeta.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 11;
            label2.Text = "Numero de la tarjeta";
            // 
            // txtNombreTitular
            // 
            txtNombreTitular.Location = new Point(12, 46);
            txtNombreTitular.Name = "txtNombreTitular";
            txtNombreTitular.Size = new Size(266, 23);
            txtNombreTitular.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre del titular";
            // 
            // btnValidarTarjeta
            // 
            btnValidarTarjeta.BackColor = Color.FromArgb(123, 41, 210);
            btnValidarTarjeta.FlatAppearance.BorderSize = 0;
            btnValidarTarjeta.FlatStyle = FlatStyle.Flat;
            btnValidarTarjeta.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidarTarjeta.ForeColor = Color.White;
            btnValidarTarjeta.Location = new Point(328, 234);
            btnValidarTarjeta.Name = "btnValidarTarjeta";
            btnValidarTarjeta.Size = new Size(154, 34);
            btnValidarTarjeta.TabIndex = 7;
            btnValidarTarjeta.Text = "Validar";
            btnValidarTarjeta.UseVisualStyleBackColor = false;
            // 
            // FxFormaTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnValidarTarjeta);
            Controls.Add(panel1);
            Name = "FxFormaTarjeta";
            Size = new Size(508, 296);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private TextBox txtCodigoDeSeguridad;
        private Label label4;
        private TextBox txtExpiracion;
        private Label label3;
        private TextBox txtNumeroTarjeta;
        private Label label2;
        private TextBox txtNombreTitular;
        private Label label1;
        private Button btnValidarTarjeta;
    }
}
