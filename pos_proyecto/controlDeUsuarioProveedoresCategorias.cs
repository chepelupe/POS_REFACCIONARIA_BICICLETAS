using System;
using System.Linq;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class controlDeUsuarioProveedoresCategorias : UserControl
    {
        public controlDeUsuarioProveedoresCategorias()
        {
            InitializeComponent();
            btn_agregar.Click += btn_agregar_Click;
            CargarCategorias();
            DatosCompartidos.CategoriasProveedoresActualizadas += CargarCategorias;
        }

        private void btn_agregar_Click(object? sender, EventArgs e)
        {
            string categoria = txb_nombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Ingresa el nombre de la categoría.");
                return;
            }

            if (DatosCompartidos.CategoriasProveedores.Any(c => c.Equals(categoria, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("La categoría ya existe.");
                return;
            }

            DatosCompartidos.AgregarCategoriaProveedor(categoria);
            txb_nombre.Clear();
        }

        private void CargarCategorias()
        {
            lb_categorias.DataSource = null;
            lb_categorias.DataSource = DatosCompartidos.CategoriasProveedores.ToList();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            DatosCompartidos.CategoriasProveedoresActualizadas -= CargarCategorias;
            base.OnHandleDestroyed(e);
        }
    }
}
