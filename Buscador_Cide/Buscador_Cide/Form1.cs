namespace Buscador_Cide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"No se pudo abrir la página: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPagina_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.cide.es";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"No se pudo abrir la página: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Usuario.Text))
            {
                pwd.Visible = true;
                btnAcceder.Visible = true;
                lblContra.Visible = true;
                btnmostrarocultar.Visible = true;
            }
            else
            {
                pwd.Visible = false;
                btnAcceder.Visible = false;
                lblContra.Visible = false;
                btnmostrarocultar.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (Usuario.Text == "admin-Cide" && pwd.Text == "Cide2024")
            {
                MessageBox.Show("Acceso correcto");
                Usuario.Clear();
                pwd.Clear();
                Form2 buscador = new Form2();
                buscador.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                Usuario.Clear();
                pwd.Clear();
            }
        }

        private void btnmostrarocultar_Click(object sender, EventArgs e)
        {
            // Cambiar entre mostrar y ocultar la contraseña
            if (pwd.UseSystemPasswordChar)
            {
                pwd.UseSystemPasswordChar = false; // Muestra la contraseña
                btnmostrarocultar.Text = "🙈";
            }
            else
            {
                pwd.UseSystemPasswordChar = true; // Oculta la contraseña
                btnmostrarocultar.Text = "👁"; 
            }
        }
    }
}
