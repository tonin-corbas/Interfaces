using System;
using System.Windows.Forms;

namespace Calculadora_sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento cuando el usuario hace clic en el botón "Calcular"
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores desde los TextBox
                int horasTrabajadas = int.Parse(textBoxHoras.Text);
                float costeHora = float.Parse(textBoxCosteHora.Text);

                // Calcular el sueldo
                float sueldo = horasTrabajadas * costeHora;

                // Mostrar el resultado en el Label
                labelResultado.Text = $"Tu sueldo es: {sueldo:C}";
            }
            catch (FormatException)
            {
                // Mostrar un mensaje de error si los datos ingresados no son numéricos
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }
    }
}
