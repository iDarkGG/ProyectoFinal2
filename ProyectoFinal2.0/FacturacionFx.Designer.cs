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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkTarjetaDeCredito = new System.Windows.Forms.CheckBox();
            this.panelContenedorFormasDePago = new System.Windows.Forms.Panel();
            this.fxFormaEfectivo1 = new ProyectoFinal2._0.FormsProducts.FxFormaEfectivo();
            this.fxFormaTarjeta1 = new ProyectoFinal2._0.FormsProducts.FxFormaTarjeta();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContenedorFormasDePago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(41)))), ((int)(((byte)(210)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 443);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(269, -3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Facturacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal2._0.Properties.Resources.minus;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkTarjetaDeCredito);
            this.panel2.Location = new System.Drawing.Point(12, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 76);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Metodo seguro para pagar usando \r\ntu cuenta bancaria";
            // 
            // checkTarjetaDeCredito
            // 
            this.checkTarjetaDeCredito.AutoSize = true;
            this.checkTarjetaDeCredito.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkTarjetaDeCredito.Location = new System.Drawing.Point(26, 3);
            this.checkTarjetaDeCredito.Name = "checkTarjetaDeCredito";
            this.checkTarjetaDeCredito.Size = new System.Drawing.Size(181, 28);
            this.checkTarjetaDeCredito.TabIndex = 0;
            this.checkTarjetaDeCredito.Text = "Tarjeta de Credito";
            this.checkTarjetaDeCredito.UseVisualStyleBackColor = true;
            this.checkTarjetaDeCredito.CheckedChanged += new System.EventHandler(this.checkTarjetaDeCredito_CheckedChanged);
            // 
            // panelContenedorFormasDePago
            // 
            this.panelContenedorFormasDePago.BackColor = System.Drawing.Color.White;
            this.panelContenedorFormasDePago.Controls.Add(this.fxFormaEfectivo1);
            this.panelContenedorFormasDePago.Controls.Add(this.fxFormaTarjeta1);
            this.panelContenedorFormasDePago.Location = new System.Drawing.Point(12, 128);
            this.panelContenedorFormasDePago.Name = "panelContenedorFormasDePago";
            this.panelContenedorFormasDePago.Size = new System.Drawing.Size(478, 296);
            this.panelContenedorFormasDePago.TabIndex = 4;
            // 
            // fxFormaEfectivo1
            // 
            this.fxFormaEfectivo1.BackColor = System.Drawing.Color.White;
            this.fxFormaEfectivo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fxFormaEfectivo1.Location = new System.Drawing.Point(0, 0);
            this.fxFormaEfectivo1.Name = "fxFormaEfectivo1";
            this.fxFormaEfectivo1.Size = new System.Drawing.Size(478, 296);
            this.fxFormaEfectivo1.TabIndex = 1;
            // 
            // fxFormaTarjeta1
            // 
            this.fxFormaTarjeta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fxFormaTarjeta1.Location = new System.Drawing.Point(0, 0);
            this.fxFormaTarjeta1.Name = "fxFormaTarjeta1";
            this.fxFormaTarjeta1.Size = new System.Drawing.Size(478, 296);
            this.fxFormaTarjeta1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal2._0.Properties.Resources.mastercard_payment_method_icon_142750;
            this.pictureBox2.Location = new System.Drawing.Point(355, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // FacturacionFx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 443);
            this.Controls.Add(this.panelContenedorFormasDePago);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturacionFx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContenedorFormasDePago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private FormsProducts.FxFormaTarjeta fxFormaDePagoTarjeta1;
        private FormsProducts.FxFormaEfectivo fxFormaDePagoEfectivo1;
        private Button btnCerrar;
        private FormsProducts.FxFormaTarjeta fxFormaTarjeta1;
        private FormsProducts.FxFormaEfectivo fxFormaEfectivo1;
        private PictureBox pictureBox2;
    }
}