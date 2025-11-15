using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class controlDeUsuarioAgregarProducto : UserControl
    {
        public controlDeUsuarioAgregarProducto()
        {
            InitializeComponent();
            CargarCategorias();

            // Suscribirse al evento de actualización de categorías
            DatosCompartidos.CategoriasActualizadas += CargarCategorias;
        }

        private void CargarCategorias()
        {
            // Guardar la categoría seleccionada actualmente
            string categoriaSeleccionada = cb_categoria.SelectedItem?.ToString();

            cb_categoria.Items.Clear();
            foreach (string categoria in DatosCompartidos.Categorias)
            {
                cb_categoria.Items.Add(categoria);
            }

            // Restaurar la categoría seleccionada si aún existe
            if (!string.IsNullOrEmpty(categoriaSeleccionada) && cb_categoria.Items.Contains(categoriaSeleccionada))
            {
                cb_categoria.SelectedItem = categoriaSeleccionada;
            }
            else if (cb_categoria.Items.Count > 0)
            {
                cb_categoria.SelectedIndex = 0;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Validar campos básicos
            if (string.IsNullOrWhiteSpace(txb_nombre.Text) ||
                cb_categoria.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txb_precio.Text) ||
                string.IsNullOrWhiteSpace(txb_cantidad.Text))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios: Nombre, Categoría, Precio y Cantidad.");
                return;
            }

            try
            {
                // Crear nuevo producto
                Producto nuevoProducto = new Producto
                {
                    Nombre = txb_nombre.Text,
                    Categoria = cb_categoria.SelectedItem.ToString(),
                    Precio = decimal.Parse(txb_precio.Text),
                    Cantidad = int.Parse(txb_cantidad.Text),
                    Descripcion = txb_descripcion.Text
                };

                // Agregar producto
                DatosCompartidos.AgregarProducto(nuevoProducto);

                // Limpiar formulario
                LimpiarFormulario();

                MessageBox.Show("Producto agregado correctamente!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos para Precio y Cantidad.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}");
            }
        }

        private void LimpiarFormulario()
        {
            txb_nombre.Clear();
            txb_descripcion.Clear();
            txb_precio.Clear();
            txb_cantidad.Clear();
            if (cb_categoria.Items.Count > 0)
                cb_categoria.SelectedIndex = 0;
        }

        // Importante: Limpiar el evento cuando se destruya el control
        protected override void OnHandleDestroyed(EventArgs e)
        {
            DatosCompartidos.CategoriasActualizadas -= CargarCategorias;
            base.OnHandleDestroyed(e);
        }
    }
}