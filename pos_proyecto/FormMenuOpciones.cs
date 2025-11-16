using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class FormMenuOpciones : Form
    {
        public FormMenuOpciones()
        {
            InitializeComponent();
            ConfigurarBotones();
        }

        private void ConfigurarBotones()
        {
            btn_inventario.Click += (s, e) => AbrirModuloInventario();
            btn_proveedores.Click += (s, e) => AbrirModuloProveedores();
            btn_ventas.Click += (s, e) => this.DialogResult = DialogResult.OK;
            btn_salir.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
        }

        private void AbrirModuloInventario()
        {
            this.Hide();
            FormInventario formInventario = new FormInventario();
            formInventario.ShowDialog();
            this.Show();
        }

        private void AbrirModuloProveedores()
        {
            this.Hide();
            FormProveedor formProveedor = new FormProveedor();
            formProveedor.ShowDialog();
            this.Show();
        }
    }
}