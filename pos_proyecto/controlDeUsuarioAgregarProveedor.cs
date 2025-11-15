using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class ControlDeUsuarioAgregarProveedor : UserControl
    {
        public ControlDeUsuarioAgregarProveedor()
        {
            InitializeComponent();
            btn_agregar.Click += btn_agregar_Click;
            CargarCategorias();
            DatosCompartidos.CategoriasProveedoresActualizadas += CargarCategorias;
        }

        private void CargarCategorias()
        {
            string? seleccionAnterior = cb_categoria.SelectedItem?.ToString();

            cb_categoria.Items.Clear();
            foreach (var categoria in DatosCompartidos.CategoriasProveedores)
            {
                cb_categoria.Items.Add(categoria);
            }

            if (!string.IsNullOrEmpty(seleccionAnterior) && cb_categoria.Items.Contains(seleccionAnterior))
            {
                cb_categoria.SelectedItem = seleccionAnterior;
            }
            else if (cb_categoria.Items.Count > 0)
            {
                cb_categoria.SelectedIndex = 0;
            }
        }

        private void btn_agregar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            var nuevoProveedor = new Proveedor
            {
                Nombre = txb_nombre.Text.Trim(),
                Rfc = txb_rfc.Text.Trim(),
                Telefono = txb_telefono.Text.Trim(),
                CorreoElectronico = txb_correo.Text.Trim(),
                Categoria = cb_categoria.SelectedItem?.ToString() ?? string.Empty
            };

            DatosCompartidos.AgregarProveedor(nuevoProveedor);
            LimpiarFormulario();

            MessageBox.Show("Proveedor agregado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txb_nombre.Text))
            {
                MessageBox.Show("Ingresa el nombre del proveedor.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txb_rfc.Text))
            {
                MessageBox.Show("Ingresa el RFC del proveedor.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txb_telefono.Text))
            {
                MessageBox.Show("Ingresa el teléfono del proveedor.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txb_correo.Text))
            {
                MessageBox.Show("Ingresa el correo electrónico del proveedor.");
                return false;
            }

            if (cb_categoria.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una categoría.");
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            txb_nombre.Clear();
            txb_rfc.Clear();
            txb_telefono.Clear();
            txb_correo.Clear();
            if (cb_categoria.Items.Count > 0)
            {
                cb_categoria.SelectedIndex = 0;
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            DatosCompartidos.CategoriasProveedoresActualizadas -= CargarCategorias;
            base.OnHandleDestroyed(e);
        }
    }
}
