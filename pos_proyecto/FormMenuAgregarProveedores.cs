using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class FormMenuAgregarProveedores : Form
    {
        private ControlDeUsuarioAgregarProveedor? controlAgregarProveedor;
        private controlDeUsuarioProveedoresCategorias? controlCategoriasProveedor;

        public FormMenuAgregarProveedores()
        {
            InitializeComponent();
            InicializarControlesUsuario();
            btn_agregar_proveedor_proveedores.Click += BtnAgregarProveedorClick;
            btn_agregar_categoria_proveedores.Click += BtnAgregarCategoriaClick;
        }

        private void InicializarControlesUsuario()
        {
            controlAgregarProveedor = new ControlDeUsuarioAgregarProveedor { Dock = DockStyle.Fill };
            controlCategoriasProveedor = new controlDeUsuarioProveedoresCategorias { Dock = DockStyle.Fill };
            MostrarControl(controlAgregarProveedor);
        }

        private void BtnAgregarProveedorClick(object? sender, EventArgs e)
        {
            MostrarControl(controlAgregarProveedor);
        }

        private void BtnAgregarCategoriaClick(object? sender, EventArgs e)
        {
            MostrarControl(controlCategoriasProveedor);
        }

        private void MostrarControl(UserControl? control)
        {
            if (control == null)
            {
                return;
            }

            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }
    }
}
