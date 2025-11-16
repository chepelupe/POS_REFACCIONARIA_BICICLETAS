using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    public partial class FormBuscarProducto : Form
    {
        public Producto ProductoSeleccionado { get; private set; }

        public FormBuscarProducto()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarProductos();
        }

        private void ConfigurarDataGridView()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configurar columnas
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 150
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Width = 80
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Stock",
                Width = 60
            });
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = DatosCompartidos.Productos;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && dgvProductos.CurrentRow.DataBoundItem is Producto producto)
            {
                ProductoSeleccionado = producto;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un producto", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}