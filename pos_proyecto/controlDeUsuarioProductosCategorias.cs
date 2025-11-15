using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class controlDeUsuarioProductosCategorias : UserControl
    {
        public controlDeUsuarioProductosCategorias()
        {
            InitializeComponent();
            CargarCategorias();

            // Suscribirse al evento de actualización de categorías
            DatosCompartidos.CategoriasActualizadas += CargarCategorias;
        }

        private void CargarCategorias()
        {
            // Guardar la categoría seleccionada actualmente
            string categoriaSeleccionada = cbEliminarCat.SelectedItem?.ToString();

            cbEliminarCat.Items.Clear();
            foreach (string categoria in DatosCompartidos.Categorias)
            {
                cbEliminarCat.Items.Add(categoria);
            }

            // Restaurar la categoría seleccionada si aún existe
            if (!string.IsNullOrEmpty(categoriaSeleccionada) && cbEliminarCat.Items.Contains(categoriaSeleccionada))
            {
                cbEliminarCat.SelectedItem = categoriaSeleccionada;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agregar categoría
            if (!string.IsNullOrWhiteSpace(txtAgregarCat.Text))
            {
                DatosCompartidos.AgregarCategoria(txtAgregarCat.Text);
                txtAgregarCat.Clear();
                MessageBox.Show("Categoría agregada correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre para la categoría.");
            }
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            // Eliminar categoría
            if (cbEliminarCat.SelectedItem != null)
            {
                string categoriaSeleccionada = cbEliminarCat.SelectedItem.ToString();

                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de eliminar la categoría: {categoriaSeleccionada}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DatosCompartidos.EliminarCategoria(categoriaSeleccionada);
                    MessageBox.Show("Categoría eliminada correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría para eliminar.");
            }
        }

        // Importante: Limpiar el evento cuando se destruya el control
        protected override void OnHandleDestroyed(EventArgs e)
        {
            DatosCompartidos.CategoriasActualizadas -= CargarCategorias;
            base.OnHandleDestroyed(e);
        }

        // Opcional: Evento para cuando se selecciona una categoría en el ComboBox
        private void cbEliminarCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Puedes usar este evento para mostrar la categoría seleccionada en el TextBox
            // si quieres que sea más fácil modificar
            if (cbEliminarCat.SelectedItem != null)
            {
                //txtAgregarCat.Text = cbEliminarCat.SelectedItem.ToString(); // Descomenta si quieres esta funcionalidad
            }
        }


        private void btnModificarCat_Click(object sender, EventArgs e)
        {
            // Modificar categoría
            if (cbEliminarCat.SelectedItem != null && !string.IsNullOrWhiteSpace(txtAgregarCat.Text))
            {
                string categoriaVieja = cbEliminarCat.SelectedItem.ToString();
                string categoriaNueva = txtAgregarCat.Text.Trim();

                // Verificar si la categoría nueva ya existe
                if (DatosCompartidos.Categorias.Contains(categoriaNueva))
                {
                    MessageBox.Show($"La categoría '{categoriaNueva}' ya existe. Por favor, elige un nombre diferente.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostrar mensaje de confirmación
                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de modificar la categoría '{categoriaVieja}' por '{categoriaNueva}'?\n\n" +
                    "Esta acción también actualizará todos los productos que pertenecen a esta categoría.",
                    "Confirmar modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        DatosCompartidos.ModificarCategoria(categoriaVieja, categoriaNueva);
                        txtAgregarCat.Clear();
                        MessageBox.Show($"Categoría modificada correctamente de '{categoriaVieja}' a '{categoriaNueva}'.",
                                      "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al modificar la categoría: {ex.Message}",
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (cbEliminarCat.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una categoría para modificar.",
                                  "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Por favor, escribe el nuevo nombre para la categoría en el campo 'Agregar categoría'.",
                                  "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}