namespace Calculadora_sueldo
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
            label1 = new Label();
            textBoxHoras = new TextBox();
            label2 = new Label();
            textBoxCosteHora = new TextBox();
            botonCalcular = new Button();
            label3 = new Label();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 107);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduce las horas trabajadas";
            // 
            // textBoxHoras
            // 
            textBoxHoras.Location = new Point(428, 100);
            textBoxHoras.Name = "textBoxHoras";
            textBoxHoras.Size = new Size(142, 27);
            textBoxHoras.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 194);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 2;
            label2.Text = "Introduce el costo de hora";
            // 
            // textBoxCosteHora
            // 
            textBoxCosteHora.Location = new Point(428, 187);
            textBoxCosteHora.Name = "textBoxCosteHora";
            textBoxCosteHora.Size = new Size(142, 27);
            textBoxCosteHora.TabIndex = 3;
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(307, 252);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(129, 32);
            botonCalcular.TabIndex = 4;
            botonCalcular.Text = "Calcular sueldo";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 301);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 5;
            label3.Text = "El resultado del sueldo es:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(436, 301);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 20);
            labelResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado);
            Controls.Add(label3);
            Controls.Add(botonCalcular);
            Controls.Add(textBoxCosteHora);
            Controls.Add(label2);
            Controls.Add(textBoxHoras);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxHoras;
        private Label label2;
        private TextBox textBoxCosteHora;
        private Button botonCalcular;
        private Label label3;
        private Label labelResultado;
    }
}
