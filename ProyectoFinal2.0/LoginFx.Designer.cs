namespace ProyectoFinal2._0
{
    partial class LoginFx
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
            panelContenedorLogin = new Panel();
            panel1 = new Panel();
            btnRegistrar = new LinkLabel();
            btnLogin = new Button();
            txtContraseña = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCerrarLogin = new Button();
            pictureBox1 = new PictureBox();
            panelContenedorLogin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedorLogin
            // 
            panelContenedorLogin.BackColor = Color.White;
            panelContenedorLogin.Controls.Add(panel1);
            panelContenedorLogin.Controls.Add(pictureBox1);
            panelContenedorLogin.Dock = DockStyle.Fill;
            panelContenedorLogin.Location = new Point(0, 0);
            panelContenedorLogin.Name = "panelContenedorLogin";
            panelContenedorLogin.Size = new Size(722, 419);
            panelContenedorLogin.TabIndex = 0;
            panelContenedorLogin.Paint += panelContenedorLogin_Paint;
            panelContenedorLogin.MouseDown += panelContenedorLogin_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarLogin);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(428, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 419);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSize = true;
            btnRegistrar.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.LinkColor = Color.FromArgb(123, 41, 210);
            btnRegistrar.Location = new Point(94, 376);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(103, 19);
            btnRegistrar.TabIndex = 22;
            btnRegistrar.TabStop = true;
            btnRegistrar.Text = "Create Account";
            btnRegistrar.LinkClicked += btnRegistrar_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(123, 41, 210);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(92, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 38);
            btnLogin.TabIndex = 21;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = SystemColors.GrayText;
            txtContraseña.Location = new Point(46, 236);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(222, 19);
            txtContraseña.TabIndex = 18;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.padlock;
            pictureBox5.Location = new Point(16, 232);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.menos_linea_recta_horizontal__1_1;
            pictureBox2.Location = new Point(16, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.user__1_;
            pictureBox4.Location = new Point(16, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.menos_linea_recta_horizontal__1_1;
            pictureBox3.Location = new Point(16, 193);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.GrayText;
            txtUsuario.Location = new Point(46, 175);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(222, 19);
            txtUsuario.TabIndex = 17;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 116);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 3;
            label3.Text = "Login your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 45);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 2;
            label2.Text = "Good Morning";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 26);
            label1.TabIndex = 1;
            label1.Text = "Hola!";
            // 
            // btnCerrarLogin
            // 
            btnCerrarLogin.FlatAppearance.BorderSize = 0;
            btnCerrarLogin.FlatStyle = FlatStyle.Flat;
            btnCerrarLogin.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarLogin.Location = new Point(255, 0);
            btnCerrarLogin.Name = "btnCerrarLogin";
            btnCerrarLogin.Size = new Size(39, 35);
            btnCerrarLogin.TabIndex = 0;
            btnCerrarLogin.Text = "X";
            btnCerrarLogin.UseVisualStyleBackColor = true;
            btnCerrarLogin.Click += btnCerrarLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.paisaje_montana_purpura;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 419);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginFx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 419);
            Controls.Add(panelContenedorLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFx";
            StartPosition = FormStartPosition.CenterScreen;
            Activated += LoginFx_Activated;
            ResizeEnd += LoginFx_ResizeEnd;
            SizeChanged += LoginFx_SizeChanged;
            Paint += LoginFx_Paint;
            MouseDown += LoginFx_MouseDown;
            panelContenedorLogin.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedorLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnCerrarLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private LinkLabel btnRegistrar;
    }
}