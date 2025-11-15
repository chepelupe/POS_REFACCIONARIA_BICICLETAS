using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pos_proyecto
{
    public partial class FormInventario : Form
    {
        private BindingList<Producto> productosFiltrados; // Lista para productos filtrados

        public FormInventario()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarBuscador();
            CargarDatosEnDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            // Configurar el DataGridView para edición directa
            dgv_listaInventario.AllowUserToAddRows = false;
            dgv_listaInventario.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void ConfigurarBuscador()
        {
            // Configurar opciones del ComboBox de búsqueda
            cb_categoria_busqueda.Items.AddRange(new string[] { "Nombre", "Categoría", "ID", "Descripción" });
            cb_categoria_busqueda.SelectedIndex = 0; // Seleccionar "Nombre" por defecto

            // Crear la lista filtrada
            productosFiltrados = new BindingList<Producto>();
        }

        private void CargarDatosEnDataGridView()
        {
            // Mostrar todos los productos
            productosFiltrados.Clear();
            foreach (var producto in DatosCompartidos.Productos)
            {
                productosFiltrados.Add(producto);
            }

            dgv_listaInventario.DataSource = productosFiltrados;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Abrir formulario para agregar productos
            FormMenuAgregarProductos formAgregar = new FormMenuAgregarProductos();
            formAgregar.ShowDialog();

            // Refrescar los datos después de cerrar el formulario
            CargarDatosEnDataGridView();
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            // Eliminar producto seleccionado
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
                    CargarDatosEnDataGridView(); // Recargar datos
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            // Modificar producto seleccionado
            if (dgv_listaInventario.CurrentRow != null && dgv_listaInventario.CurrentRow.DataBoundItem is Producto productoSeleccionado)
            {
                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de guardar los cambios en: {productoSeleccionado.Nombre}?",
                    "Confirmar modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Los cambios ya están en el BindingList, solo confirmamos
                    dgv_listaInventario.Refresh();
                    MessageBox.Show("Cambios guardados correctamente.");
                }
                else
                {
                    // Recargar los datos originales si el usuario cancela
                    CargarDatosEnDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para modificar.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar datos de ejemplo (opcional)
            CargarDatosEjemplo();
        }

        private void CargarDatosEjemplo()
        {
            // Agregar algunos productos de ejemplo si no existen
            if (DatosCompartidos.Productos.Count == 0)
            {
                DatosCompartidos.AgregarProducto(new Producto
                {
                    Nombre = "Laptop",
                    Categoria = "Electrónicos",
                    Precio = 15000,
                    Cantidad = 5,
                    Descripcion = "Laptop gaming"
                });

                DatosCompartidos.AgregarProducto(new Producto
                {
                    Nombre = "Mouse",
                    Categoria = "Electrónicos",
                    Precio = 250,
                    Cantidad = 10,
                    Descripcion = "Mouse inalámbrico"
                });

                DatosCompartidos.AgregarProducto(new Producto
                {
                    Nombre = "Camisa",
                    Categoria = "Ropa",
                    Precio = 300,
                    Cantidad = 15,
                    Descripcion = "Camisa de algodón"
                });
            }
        }

        // Método para manejar la búsqueda
        private void RealizarBusqueda()
        {
            string textoBusqueda = tb_abuscar.Text.Trim();
            string criterio = cb_categoria_busqueda.SelectedItem?.ToString() ?? "Nombre";

            // Si el texto de búsqueda está vacío, mostrar todos los productos
            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                CargarDatosEnDataGridView();
                return;
            }

            // Filtrar productos según el criterio seleccionado
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

            // Actualizar el DataGridView con los resultados filtrados
            dgv_listaInventario.DataSource = productosFiltrados;

            // Mostrar mensaje si no se encontraron resultados
            if (productosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento para el botón Buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        // Evento para buscar al presionar Enter en el TextBox (CORREGIDO)
        private void tb_abuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RealizarBusqueda();
                e.Handled = true; // Evitar el sonido del sistema
            }
        }

        // Evento para cuando cambia el ComboBox (CORREGIDO)
        private void cb_categoria_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcional: puedes agregar funcionalidad aquí si lo deseas
        }
    }
}