namespace Buscador_Cide
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            datosAlumnos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            NombreAlumno = new DataGridViewTextBoxColumn();
            Asignatura = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
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
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // datosAlumnos
            // 
            datosAlumnos.BackgroundColor = Color.FromArgb(176, 253, 188);
            datosAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosAlumnos.AutoGenerateColumns = true;
            datosAlumnos.Location = new Point(278, 135);
            datosAlumnos.Name = "datosAlumnos";
            datosAlumnos.RowHeadersWidth = 51;
            datosAlumnos.Size = new Size(442, 244);
            datosAlumnos.TabIndex = 9;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 81);
            label1.TabIndex = 10;
            label1.Text = "Editor";
            // 
            // button1
            // 
            button1.Location = new Point(315, 395);
            button1.Name = "button1";
            button1.Size = new Size(122, 36);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Location = new Point(540, 391);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(122, 36);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 253, 188);
            ClientSize = new Size(997, 528);
            Controls.Add(btnCerrar);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(datosAlumnos);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datosAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView datosAlumnos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NombreAlumno;
        private DataGridViewTextBoxColumn Asignatura;
        private Label label1;
        private Button button1;
        private Button btnCerrar;
    }
}