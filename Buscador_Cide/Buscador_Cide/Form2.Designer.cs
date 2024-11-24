namespace Buscador_Cide
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblid = new Label();
            idAsignatura = new TextBox();
            nAsignatura = new TextBox();
            lblClase = new Label();
            datosAlumnos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            NombreAlumno = new DataGridViewTextBoxColumn();
            Asignatura = new DataGridViewTextBoxColumn();
            btn = new Button();
            editarDatos = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datosAlumnos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 438);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 81);
            label1.TabIndex = 2;
            label1.Text = "Buscador";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(386, 114);
            lblid.Name = "lblid";
            lblid.Size = new Size(22, 20);
            lblid.TabIndex = 3;
            lblid.Text = "id";
            // 
            // idAsignatura
            // 
            idAsignatura.Location = new Point(492, 111);
            idAsignatura.Name = "idAsignatura";
            idAsignatura.Size = new Size(150, 27);
            idAsignatura.TabIndex = 4;
            // 
            // nAsignatura
            // 
            nAsignatura.Location = new Point(492, 152);
            nAsignatura.Name = "nAsignatura";
            nAsignatura.Size = new Size(150, 27);
            nAsignatura.TabIndex = 6;
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Location = new Point(386, 152);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(80, 20);
            lblClase.TabIndex = 5;
            lblClase.Text = "Asignatura";
            // 
            // datosAlumnos
            // 
            datosAlumnos.AllowUserToAddRows = false;
            datosAlumnos.AllowUserToDeleteRows = false;
            datosAlumnos.BackgroundColor = Color.FromArgb(176, 253, 188);
            datosAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosAlumnos.Columns.AddRange(new DataGridViewColumn[] { id, NombreAlumno, Asignatura });
            datosAlumnos.Location = new Point(314, 275);
            datosAlumnos.Name = "datosAlumnos";
            datosAlumnos.RowHeadersWidth = 51;
            datosAlumnos.Size = new Size(429, 174);
            datosAlumnos.TabIndex = 8;
            datosAlumnos.Visible = false;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // NombreAlumno
            // 
            NombreAlumno.HeaderText = "Nombre del Alumno";
            NombreAlumno.MinimumWidth = 6;
            NombreAlumno.Name = "NombreAlumno";
            NombreAlumno.Width = 125;
            // 
            // Asignatura
            // 
            Asignatura.HeaderText = "Asignatura";
            Asignatura.MinimumWidth = 6;
            Asignatura.Name = "Asignatura";
            Asignatura.Width = 125;
            // 
            // btn
            // 
            btn.Location = new Point(386, 203);
            btn.Name = "btn";
            btn.Size = new Size(119, 40);
            btn.TabIndex = 9;
            btn.Text = "Buscar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btnbuscar_Click;
            // 
            // editarDatos
            // 
            editarDatos.Location = new Point(526, 203);
            editarDatos.Name = "editarDatos";
            editarDatos.Size = new Size(119, 40);
            editarDatos.TabIndex = 10;
            editarDatos.Text = "Editar datos";
            editarDatos.UseVisualStyleBackColor = true;
            editarDatos.Click += btnEditar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Location = new Point(443, 464);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(163, 40);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 253, 188);
            ClientSize = new Size(997, 528);
            Controls.Add(btnCerrar);
            Controls.Add(editarDatos);
            Controls.Add(btn);
            Controls.Add(datosAlumnos);
            Controls.Add(nAsignatura);
            Controls.Add(lblClase);
            Controls.Add(idAsignatura);
            Controls.Add(lblid);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Buscador";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datosAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblid;
        private TextBox idAsignatura;
        private TextBox nAsignatura;
        private Label lblClase;
        private DataGridView datosAlumnos;
        private Button btn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NombreAlumno;
        private DataGridViewTextBoxColumn Asignatura;
        private Button editarDatos;
        private Button btnCerrar;
    }
}