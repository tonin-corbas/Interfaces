namespace Buscador_Cide
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblTexto = new Label();
            Usuario = new TextBox();
            lblContra = new Label();
            pwd = new TextBox();
            btnAcceder = new Button();
            btnCerrar = new Button();
            btnPagina = new Button();
            btnmostrarocultar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 111);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(276, 184);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(173, 25);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Introduce el usuario:";
            // 
            // Usuario
            // 
            Usuario.Location = new Point(490, 185);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(218, 27);
            Usuario.TabIndex = 2;
            Usuario.TextChanged += Usuario_TextChanged;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContra.Location = new Point(276, 258);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(201, 25);
            lblContra.TabIndex = 3;
            lblContra.Text = "Introduce la contraseña:";
            lblContra.Visible = false;
            // 
            // pwd
            // 
            pwd.Location = new Point(490, 259);
            pwd.Name = "pwd";
            pwd.Size = new Size(218, 27);
            pwd.TabIndex = 4;
            pwd.UseSystemPasswordChar = true;
            pwd.Visible = false;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(401, 323);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(163, 40);
            btnAcceder.TabIndex = 5;
            btnAcceder.Text = "Iniciar sesión";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Visible = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Location = new Point(401, 395);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(163, 40);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnPagina
            // 
            btnPagina.BackColor = Color.FromArgb(4, 92, 28);
            btnPagina.ForeColor = SystemColors.Control;
            btnPagina.Location = new Point(768, 423);
            btnPagina.Name = "btnPagina";
            btnPagina.Size = new Size(170, 72);
            btnPagina.TabIndex = 7;
            btnPagina.Text = "Ir a la página web oficial";
            btnPagina.UseVisualStyleBackColor = false;
            btnPagina.Click += btnPagina_Click;
            // 
            // btnmostrarocultar
            // 
            btnmostrarocultar.Location = new Point(718, 261);
            btnmostrarocultar.Name = "btnmostrarocultar";
            btnmostrarocultar.Size = new Size(32, 25);
            btnmostrarocultar.TabIndex = 8;
            btnmostrarocultar.Text = "🙈";
            btnmostrarocultar.UseVisualStyleBackColor = true;
            btnmostrarocultar.Visible = false;
            btnmostrarocultar.Click += btnmostrarocultar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 253, 188);
            ClientSize = new Size(997, 528);
            Controls.Add(btnmostrarocultar);
            Controls.Add(btnPagina);
            Controls.Add(btnCerrar);
            Controls.Add(btnAcceder);
            Controls.Add(pwd);
            Controls.Add(lblContra);
            Controls.Add(Usuario);
            Controls.Add(lblTexto);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Inicie sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTexto;
        private TextBox Usuario;
        private Label lblContra;
        private TextBox pwd;
        private Button btnAcceder;
        private Button btnCerrar;
        private Button btnPagina;
        private Button btnmostrarocultar;
    }
}
