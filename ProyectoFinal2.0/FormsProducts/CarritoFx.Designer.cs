namespace ProyectoFinal2._0.FormsProducts
{
    partial class CarritoFx
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
            lvInfoProductos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnPagar = new Button();
            btnCerrarCarrito = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvInfoProductos
            // 
            lvInfoProductos.BorderStyle = BorderStyle.None;
            lvInfoProductos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvInfoProductos.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lvInfoProductos.GridLines = true;
            lvInfoProductos.Location = new Point(3, 120);
            lvInfoProductos.Name = "lvInfoProductos";
            lvInfoProductos.Size = new Size(542, 276);
            lvInfoProductos.TabIndex = 0;
            lvInfoProductos.UseCompatibleStateImageBehavior = false;
            lvInfoProductos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre del Producto";
            columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Unidades";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Precio Unit";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Total";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnPagar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(539, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 426);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Swis721 BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 15);
            label1.Name = "label1";
            label1.Size = new Size(118, 18);
            label1.TabIndex = 0;
            label1.Text = "INFORMACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Swis721 BT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(173, 58);
            label2.TabIndex = 2;
            label2.Text = "Productos en \r\nmi carrito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 83);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 1;
            label3.Text = "SubTotal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(28, 16);
            label4.TabIndex = 2;
            label4.Text = "IVA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 309);
            label5.Name = "label5";
            label5.Size = new Size(50, 16);
            label5.TabIndex = 3;
            label5.Text = "TOTAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 83);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 121);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 5;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(156, 309);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 6;
            label8.Text = "label8";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(123, 41, 210);
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(31, 373);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(141, 38);
            btnPagar.TabIndex = 22;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnCerrarCarrito
            // 
            btnCerrarCarrito.FlatAppearance.BorderSize = 0;
            btnCerrarCarrito.FlatStyle = FlatStyle.Flat;
            btnCerrarCarrito.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarCarrito.Location = new Point(0, -2);
            btnCerrarCarrito.Name = "btnCerrarCarrito";
            btnCerrarCarrito.Size = new Size(39, 35);
            btnCerrarCarrito.TabIndex = 3;
            btnCerrarCarrito.Text = "X";
            btnCerrarCarrito.UseVisualStyleBackColor = true;
            btnCerrarCarrito.Click += btnCerrarCarrito_Click;
            // 
            // CarritoFx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCerrarCarrito);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(lvInfoProductos);
            Name = "CarritoFx";
            Size = new Size(746, 429);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvInfoProductos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnPagar;
        private Button btnCerrarCarrito;
    }
}
