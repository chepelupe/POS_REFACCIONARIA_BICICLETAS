using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class FormInventario : Form
    {
        private BindingList<Producto> productosFiltrados;

        public FormInventario()
        {
            InitializeComponent();
            ConfigurarEventos();
            ConfigurarBuscador();
            CargarDatosEnDataGridView();
        }

        private void ConfigurarEventos()
        {
            btn_agregar.Click += btn_agregar_Click;
            btn_eliminar.Click += btn_eliminar_Click;
            btn_modificar.Click += btn_modificar_Click;
            button1.Click += button1_Click;
            btn_buscar.Click += btn_buscar_Click;

            // Permitir modificación directa en el DataGridView
            dgv_listaInventario.CellEndEdit += dgv_listaInventario_CellEndEdit;
        }

        private void ConfigurarBuscador()
        {
            cb_categoria_busqueda.Items.AddRange(new string[] { "Nombre", "Categoría", "ID", "Descripción" });
            cb_categoria_busqueda.SelectedIndex = 0;
            productosFiltrados = new BindingList<Producto>();
        }

        private void CargarDatosEnDataGridView()
        {
            productosFiltrados.Clear();
            foreach (var producto in DatosCompartidos.Productos)
            {
                productosFiltrados.Add(producto);
            }
            dgv_listaInventario.DataSource = productosFiltrados;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormMenuAgregarProductos formAgregar = new FormMenuAgregarProductos();
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                CargarDatosEnDataGridView();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_listaInventario.CurrentRow != null && dgv_listaInventario.CurrentRow.DataBoundItem is Producto productoSeleccionado)
            {
                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de eliminar el producto: {productoSeleccionado.Nombre}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DatosCompartidos.EliminarProductoForzado(productoSeleccionado.Id);
                    CargarDatosEnDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_listaInventario.CurrentRow != null && dgv_listaInventario.CurrentRow.DataBoundItem is Producto productoSeleccionado)
            {
                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de guardar los cambios en: {productoSeleccionado.Nombre}?",
                    "Confirmar modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    dgv_listaInventario.Refresh();
                    MessageBox.Show("Cambios guardados correctamente.");
                }
                else
                {
                    CargarDatosEnDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para modificar.");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void RealizarBusqueda()
        {
            string textoBusqueda = tb_abuscar.Text.Trim();
            string criterio = cb_categoria_busqueda.SelectedItem?.ToString() ?? "Nombre";

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                CargarDatosEnDataGridView();
                return;
            }

            productosFiltrados.Clear();

            foreach (var producto in DatosCompartidos.Productos)
            {
                bool coincide = false;

                switch (criterio)
                {
                    case "Nombre":
                        coincide = producto.Nombre?.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0;
                        break;
                    case "Categoría":
                        coincide = producto.Categoria?.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0;
                        break;
                    case "ID":
                        coincide = producto.Id.ToString().IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0;
                        break;
                    case "Descripción":
                        coincide = producto.Descripcion?.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0;
                        break;
                }

                if (coincide)
                {
                    productosFiltrados.Add(producto);
                }
            }

            dgv_listaInventario.DataSource = productosFiltrados;

            if (productosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tb_abuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RealizarBusqueda();
                e.Handled = true;
            }
        }

        private void cb_categoria_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcional: puedes agregar funcionalidad aquí si lo deseas
        }

        private void dgv_listaInventario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_listaInventario.Rows[e.RowIndex].DataBoundItem is Producto producto)
            {
                MessageBox.Show("Cambios guardados automáticamente", "Información",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}