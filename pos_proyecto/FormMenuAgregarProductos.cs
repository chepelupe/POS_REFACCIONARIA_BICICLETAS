using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class FormMenuAgregarProductos : Form
    {
        private controlDeUsuarioAgregarProducto ucAgregarProducto;
        private controlDeUsuarioProductosCategorias ucCategorias;

        public FormMenuAgregarProductos()
        {
            InitializeComponent();
            InicializarControlesUsuario();
        }

        private void InicializarControlesUsuario()
        {
            ucAgregarProducto = new controlDeUsuarioAgregarProducto();
            ucCategorias = new controlDeUsuarioProductosCategorias();

            // Configurar los controles en el panel
            ucAgregarProducto.Dock = DockStyle.Fill;
            ucCategorias.Dock = DockStyle.Fill;
        }

        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            // Mostrar control de usuario para agregar productos
            PanelProCat.Controls.Clear();
            PanelProCat.Controls.Add(ucAgregarProducto);
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            // Mostrar control de usuario para categorías
            PanelProCat.Controls.Clear();
            PanelProCat.Controls.Add(ucCategorias);
        }
    }
}