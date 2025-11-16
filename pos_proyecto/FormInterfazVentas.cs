using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class FormInterfazVentas : Form
    {
        public FormInterfazVentas()
        {
            InitializeComponent();
            ConfigurarEventos();
            MostrarInformacionInicial();
        }

        private void ConfigurarEventos()
        {
            // Botones de navegación
            btn_f11_opciones.Click += btn_f11_opciones_Click;
            btn_f10_salir_venta.Click += btn_f10_salir_venta_Click;

            // Botones de ventas (implementación básica)
            btn_f1_agregar_venta.Click += btn_f1_agregar_venta_Click;
            btn_f2_eliminar_venta.Click += btn_f2_eliminar_venta_Click;
            btn_f6_cancelar_venta.Click += btn_f6_cancelar_venta_Click;

            // Configurar fecha actual
            lbl_fecha_venta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_empleado_venta.Text = "Administrador"; // Podrías pasar el usuario real
        }

        private void MostrarInformacionInicial()
        {
            // Configurar métodos de pago
            cb_metodopago_venta.Items.AddRange(new string[] { "Efectivo", "Tarjeta Crédito", "Tarjeta Débito", "Transferencia" });
            cb_metodopago_venta.SelectedIndex = 0;

            // Configurar tipo de venta
            rb_contado_venta.Checked = true;

            // Inicializar valores en cero
            lbl_subtotal_venta.Text = "$0.00";
            lbl_iva_venta.Text = "$0.00";
            lbl_total_venta.Text = "$0.00";
            lbl_efectivo_venta.Text = "$0.00";
            lbl_cambio_venta.Text = "$0.00";
        }

        private void btn_f11_opciones_Click(object sender, EventArgs e)
        {
            // Menú de opciones para acceder a otros módulos
            using (var formOpciones = new FormMenuOpciones())
            {
                if (formOpciones.ShowDialog() == DialogResult.OK)
                {
                    // Aquí podrías manejar alguna acción después de cerrar opciones
                }
            }
        }

        private void btn_f10_salir_venta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_f1_agregar_venta_Click(object sender, EventArgs e)
        {
            // Simular agregar producto a la venta
            AgregarProductoVenta();
        }

        private void btn_f2_eliminar_venta_Click(object sender, EventArgs e)
        {
            // Eliminar producto seleccionado
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                CalcularTotales();
            }
        }

        private void btn_f6_cancelar_venta_Click(object sender, EventArgs e)
        {
            // Cancelar venta actual
            DialogResult result = MessageBox.Show("¿Cancelar venta actual?", "Confirmar cancelación",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                CalcularTotales();
            }
        }

        private void AgregarProductoVenta()
        {
            // Simular búsqueda/agregado de producto
            using (var formBuscarProducto = new FormBuscarProducto())
            {
                if (formBuscarProducto.ShowDialog() == DialogResult.OK && formBuscarProducto.ProductoSeleccionado != null)
                {
                    var producto = formBuscarProducto.ProductoSeleccionado;

                    // Verificar stock
                    if (producto.Cantidad <= 0)
                    {
                        MessageBox.Show("Producto sin stock disponible", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Agregar a DataGridView
                    dataGridView1.Rows.Add(
                        producto.Id,
                        1, // Cantidad
                        "PZA", // Unidad
                        producto.Nombre,
                        producto.Precio.ToString("C2"),
                        producto.Precio.ToString("C2") // Importe
                    );

                    // Actualizar stock (reducir cantidad)
                    producto.Cantidad--;

                    CalcularTotales();
                }
            }
        }

        private void CalcularTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[1].Value != null)
                {
                    decimal precio = decimal.Parse(row.Cells[4].Value.ToString().Replace("$", "").Replace(",", ""));
                    int cantidad = int.Parse(row.Cells[1].Value.ToString());
                    subtotal += precio * cantidad;
                }
            }

            decimal iva = subtotal * 0.16m; // 16% de IVA
            decimal total = subtotal + iva;

            lbl_subtotal_venta.Text = subtotal.ToString("C2");
            lbl_iva_venta.Text = iva.ToString("C2");
            lbl_total_venta.Text = total.ToString("C2");
        }
    }
}