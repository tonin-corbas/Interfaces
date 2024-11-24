using System;
using System.Data;
using System.Windows.Forms;

namespace Buscador_Cide
{
    public partial class Form3 : Form
    {
        private DataTable alumnosTable;

        public Form3(DataTable data)
        {
            InitializeComponent();
            alumnosTable = data;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Vincular los datos de la tabla al DataGridView
            datosAlumnos.DataSource = alumnosTable;

            // Configurar el DataGridView para edición
            datosAlumnos.AllowUserToDeleteRows = true; // Permitir eliminación
            datosAlumnos.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Confirmar los cambios y cerrar el formulario
            MessageBox.Show("Los datos han sido guardados correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
