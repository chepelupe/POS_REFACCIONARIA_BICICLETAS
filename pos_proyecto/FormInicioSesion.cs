using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class FormInicioSesion : Form
    {
        // Credenciales por defecto
        private const string USUARIO_DEFAULT = "admin";
        private const string CONTRASENA_DEFAULT = "1234";

        public FormInicioSesion()
        {
            InitializeComponent();
            btn_iniciar_sesion.Click += btn_iniciar_sesion_Click;
            btn_salir.Click += btn_salir_Click;

            // Permitir iniciar con Enter
            tb_contra.KeyPress += (s, e) => {
                if (e.KeyChar == (char)Keys.Enter)
                    btn_iniciar_sesion_Click(s, e);
            };
        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            string usuario = tb_usuario.Text.Trim();
            string contrasena = tb_contra.Text;

            if (usuario == USUARIO_DEFAULT && contrasena == CONTRASENA_DEFAULT)
            {
                // Inicio de sesión exitoso
                this.Hide();
                FormInterfazVentas formVentas = new FormInterfazVentas();
                formVentas.Closed += (s, args) => this.Close();
                formVentas.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_contra.Clear();
                tb_usuario.Focus();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}