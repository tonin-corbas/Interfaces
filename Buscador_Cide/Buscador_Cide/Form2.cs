using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Buscador_Cide
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Añade los datos de la tabla cuando se carga el formulario
            datosAlumnos.Rows.Add("1", "Juan Pérez", "Matemáticas");
            datosAlumnos.Rows.Add("2", "María López", "Historia");
            datosAlumnos.Rows.Add("3", "Luis García", "Matemáticas");
            datosAlumnos.Rows.Add("4", "Ana Torres", "Química");
            datosAlumnos.Rows.Add("5", "Pedro Sánchez", "Historia");
            datosAlumnos.Rows.Add("6", "Laura Martín", "Matemáticas");
            datosAlumnos.Rows.Add("7", "José González", "Inglés");
            datosAlumnos.Rows.Add("8", "Elena Díaz", "Geografía");
            datosAlumnos.Rows.Add("9", "Miguel Fernández", "Historia");
            datosAlumnos.Rows.Add("10", "Clara Herrera", "Educación Física");
            datosAlumnos.Rows.Add("11", "Carlos Romero", "Arte");
            datosAlumnos.Rows.Add("12", "Lucía Ruiz", "Historia");
            datosAlumnos.Rows.Add("13", "Sofía Gómez", "Filosofía");
            datosAlumnos.Rows.Add("14", "Manuel Ortiz", "Matemáticas");
            datosAlumnos.Rows.Add("15", "Victoria Castro", "Historia del Arte");
            datosAlumnos.Rows.Add("16", "Raúl Navarro", "Historia");
            datosAlumnos.Rows.Add("17", "Paula Vázquez", "Geografía");
            datosAlumnos.Rows.Add("18", "Diego Blanco", "Química");
            datosAlumnos.Rows.Add("19", "Isabel Morales", "Inglés");
            datosAlumnos.Rows.Add("20", "Roberto Méndez", "Matemáticas");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            datosAlumnos.Visible = true;
            // Obtener los criterios de búsqueda
            string asignaturaCriterio = nAsignatura.Text.ToLower();
            int idCriterio = 0;
            bool idEsNumero = int.TryParse(idAsignatura.Text, out idCriterio);

            // Recorrer todas las filas de la tabla y aplicar el filtro
            foreach (DataGridViewRow row in datosAlumnos.Rows)
            {
                // Saltar filas vacías o nulas
                if (row.IsNewRow) continue;

                // Manejar valores nulos
                string asignatura = row.Cells["Asignatura"].Value?.ToString()?.ToLower() ?? string.Empty;
                string idString = row.Cells["id"].Value?.ToString();

                int idFila = 0;
                if (!int.TryParse(idString, out idFila))
                {
                    // Si no se puede convertir el ID a un número, ignorar esta fila
                    continue;
                }

                // Aplicar lógica de filtro
                bool visible = (!idEsNumero || idFila == idCriterio) &&
                               (string.IsNullOrWhiteSpace(asignaturaCriterio) || asignatura.Contains(asignaturaCriterio));

                // Mostrar u ocultar la fila según el resultado del filtro
                row.Visible = visible;

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Crear un DataTable para pasar los datos actuales al Form3
            DataTable table = new DataTable();

            // Agregar las columnas del DataGridView al DataTable
            foreach (DataGridViewColumn column in datosAlumnos.Columns)
            {
                table.Columns.Add(column.Name, typeof(string));
            }

            // Agregar las filas del DataGridView al DataTable
            foreach (DataGridViewRow row in datosAlumnos.Rows)
            {
                if (!row.IsNewRow) // Ignorar la fila vacía
                {
                    DataRow newRow = table.NewRow();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        newRow[i] = row.Cells[i].Value?.ToString() ?? string.Empty;
                    }
                    table.Rows.Add(newRow);
                }
            }

            // Abrir el Form3 y pasar el DataTable
            Form3 editor = new Form3(table);
            editor.ShowDialog();

            // Actualizar los datos en el DataGridView del Form2 después de cerrar el editor
            datosAlumnos.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                datosAlumnos.Rows.Add(row.ItemArray);
            }
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
