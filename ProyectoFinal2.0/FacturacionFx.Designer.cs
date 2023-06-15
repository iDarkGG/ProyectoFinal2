namespace ProyectoFinal2._0
{
    partial class FacturacionFx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCerrar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            checkTarjetaDeCredito = new CheckBox();
            panelContenedorFormasDePago = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 41, 210);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(511, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 443);
            panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(269, -3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(34, 30);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 19);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Facturacion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.minus;
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkTarjetaDeCredito);
            panel2.Location = new Point(12, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 76);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 34);
            label2.Name = "label2";
            label2.Size = new Size(237, 38);
            label2.TabIndex = 4;
            label2.Text = "Metodo seguro para pagar usando \r\ntu cuenta bancaria";
            // 
            // checkTarjetaDeCredito
            // 
            checkTarjetaDeCredito.AutoSize = true;
            checkTarjetaDeCredito.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkTarjetaDeCredito.Location = new Point(26, 3);
            checkTarjetaDeCredito.Name = "checkTarjetaDeCredito";
            checkTarjetaDeCredito.Size = new Size(181, 28);
            checkTarjetaDeCredito.TabIndex = 0;
            checkTarjetaDeCredito.Text = "Tarjeta de Credito";
            checkTarjetaDeCredito.UseVisualStyleBackColor = true;
            checkTarjetaDeCredito.CheckedChanged += checkTarjetaDeCredito_CheckedChanged;
            // 
            // panelContenedorFormasDePago
            // 
            panelContenedorFormasDePago.BackColor = Color.White;
            panelContenedorFormasDePago.Location = new Point(12, 128);
            panelContenedorFormasDePago.Name = "panelContenedorFormasDePago";
            panelContenedorFormasDePago.Size = new Size(478, 296);
            panelContenedorFormasDePago.TabIndex = 4;
            // 
            // FacturacionFx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 443);
            Controls.Add(panelContenedorFormasDePago);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FacturacionFx";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FacturacionFx_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private CheckBox checkTarjetaDeCredito;
        private Panel panelContenedorFormasDePago;
        private FormsProducts.FxPagoEfectivo fxPagoEfectivo1;
        private FormsProducts.FxPagoEfectivo fxPagoEfectivo2;
        private FormsProducts.FxFormaDePagoTarjeta fxFormaDePagoTarjeta1;
        private FormsProducts.FxFormaDePagoEfectivo fxFormaDePagoEfectivo1;
        private Button btnCerrar;
    }
}