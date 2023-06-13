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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkTarjetaDeCredito = new System.Windows.Forms.CheckBox();
            this.panelContenedorFormasDePago = new System.Windows.Forms.Panel();
            this.fxPagoEfectivo2 = new ProyectoFinal2._0.FormsProducts.FxPagoEfectivo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContenedorFormasDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(539, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 514);
            this.panel1.TabIndex = 0;
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkTarjetaDeCredito);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 82);
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
            // 
            // panelContenedorFormasDePago
            // 
            this.panelContenedorFormasDePago.BackColor = System.Drawing.Color.White;
            this.panelContenedorFormasDePago.Controls.Add(this.fxPagoEfectivo2);
            this.panelContenedorFormasDePago.Location = new System.Drawing.Point(15, 181);
            this.panelContenedorFormasDePago.Name = "panelContenedorFormasDePago";
            this.panelContenedorFormasDePago.Size = new System.Drawing.Size(508, 296);
            this.panelContenedorFormasDePago.TabIndex = 4;
            // 
            // fxPagoEfectivo2
            // 
            this.fxPagoEfectivo2.BackColor = System.Drawing.Color.White;
            this.fxPagoEfectivo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fxPagoEfectivo2.Location = new System.Drawing.Point(0, 0);
            this.fxPagoEfectivo2.Name = "fxPagoEfectivo2";
            this.fxPagoEfectivo2.Size = new System.Drawing.Size(508, 296);
            this.fxPagoEfectivo2.TabIndex = 0;
            this.fxPagoEfectivo2.Load += new System.EventHandler(this.fxPagoEfectivo2_Load);
            // 
            // FacturacionFx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 514);
            this.Controls.Add(this.panelContenedorFormasDePago);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturacionFx";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContenedorFormasDePago.ResumeLayout(false);
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
    }
}