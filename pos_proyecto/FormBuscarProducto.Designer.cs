namespace pos_proyecto
{
    partial class FormBuscarProducto
    {
        private DataGridView dgvProductos;
        private Button btnSeleccionar;
        private Button btnCancelar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Button btnBuscar;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private ComboBox cmbMarca;
        private Label lblMarca;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form
            this.Text = "Buscar Producto - POS Refaccionaria";
            this.Size = new System.Drawing.Size(800, 500);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Label Buscar
            lblBuscar = new Label();
            lblBuscar.Text = "Buscar:";
            lblBuscar.Location = new System.Drawing.Point(12, 15);
            lblBuscar.Size = new System.Drawing.Size(45, 20);
            this.Controls.Add(lblBuscar);

            // TextBox Buscar
            txtBuscar = new TextBox();
            txtBuscar.Location = new System.Drawing.Point(60, 12);
            txtBuscar.Size = new System.Drawing.Size(200, 23);
            txtBuscar.PlaceholderText = "Nombre, código de barras...";
            this.Controls.Add(txtBuscar);

            // Label Categoría
            lblCategoria = new Label();
            lblCategoria.Text = "Categoría:";
            lblCategoria.Location = new System.Drawing.Point(270, 15);
            lblCategoria.Size = new System.Drawing.Size(65, 20);
            this.Controls.Add(lblCategoria);

            // ComboBox Categoría
            cmbCategoria = new ComboBox();
            cmbCategoria.Location = new System.Drawing.Point(340, 12);
            cmbCategoria.Size = new System.Drawing.Size(130, 23);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbCategoria);

            // Label Marca
            lblMarca = new Label();
            lblMarca.Text = "Marca:";
            lblMarca.Location = new System.Drawing.Point(480, 15);
            lblMarca.Size = new System.Drawing.Size(45, 20);
            this.Controls.Add(lblMarca);

            // ComboBox Marca
            cmbMarca = new ComboBox();
            cmbMarca.Location = new System.Drawing.Point(530, 12);
            cmbMarca.Size = new System.Drawing.Size(130, 23);
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbMarca);

            // Botón Buscar
            btnBuscar = new Button();
            btnBuscar.Text = "Buscar";
            btnBuscar.Location = new System.Drawing.Point(670, 12);
            btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.Controls.Add(btnBuscar);

            // DataGridView
            dgvProductos = new DataGridView();
            dgvProductos.Location = new System.Drawing.Point(12, 45);
            dgvProductos.Size = new System.Drawing.Size(760, 350);
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;

            // Configurar columnas según la base de datos POS_Refaccionaria
            dgvProductos.Columns.Add("id_productos", "ID");
            dgvProductos.Columns.Add("codigo_barras", "Código Barras");
            dgvProductos.Columns.Add("nombre", "Nombre");
            dgvProductos.Columns.Add("precio_venta", "Precio Venta");
            dgvProductos.Columns.Add("precio_compra", "Precio Compra");
            dgvProductos.Columns.Add("stock_actual", "Stock");
            dgvProductos.Columns.Add("nombre_marca", "Marca");
            dgvProductos.Columns.Add("nombre_categoria", "Categoría");
            dgvProductos.Columns.Add("nombre_unidad_medida", "Unidad Medida");

            // Ajustar anchos de columnas específicas
            dgvProductos.Columns["id_productos"].Width = 50;
            dgvProductos.Columns["codigo_barras"].Width = 120;
            dgvProductos.Columns["nombre"].Width = 200;
            dgvProductos.Columns["precio_venta"].Width = 90;
            dgvProductos.Columns["precio_compra"].Width = 90;
            dgvProductos.Columns["stock_actual"].Width = 70;
            dgvProductos.Columns["nombre_marca"].Width = 120;
            dgvProductos.Columns["nombre_categoria"].Width = 120;
            dgvProductos.Columns["nombre_unidad_medida"].Width = 100;

            // Formato para columnas de precio
            dgvProductos.Columns["precio_venta"].DefaultCellStyle.Format = "C2";
            dgvProductos.Columns["precio_compra"].DefaultCellStyle.Format = "C2";

            // Alineación de columnas numéricas
            dgvProductos.Columns["precio_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns["precio_compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns["stock_actual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.Controls.Add(dgvProductos);

            // Botón Seleccionar
            btnSeleccionar = new Button();
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.Location = new System.Drawing.Point(600, 410);
            btnSeleccionar.Size = new System.Drawing.Size(80, 35);
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            this.Controls.Add(btnSeleccionar);

            // Botón Cancelar
            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new System.Drawing.Point(690, 410);
            btnCancelar.Size = new System.Drawing.Size(80, 35);
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            this.Controls.Add(btnCancelar);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}