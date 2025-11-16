namespace pos_proyecto
{
    partial class FormBuscarProducto
    {
        private DataGridView dgvProductos;
        private Button btnSeleccionar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form
            this.Text = "Buscar Producto";
            this.Size = new System.Drawing.Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // DataGridView
            dgvProductos = new DataGridView();
            dgvProductos.Location = new System.Drawing.Point(12, 12);
            dgvProductos.Size = new System.Drawing.Size(460, 300);
            dgvProductos.ReadOnly = true;
            this.Controls.Add(dgvProductos);

            // Botón Seleccionar
            btnSeleccionar = new Button();
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.Location = new System.Drawing.Point(280, 320);
            btnSeleccionar.Size = new System.Drawing.Size(90, 30);
            btnSeleccionar.Click += btnSeleccionar_Click;
            this.Controls.Add(btnSeleccionar);

            // Botón Cancelar
            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new System.Drawing.Point(382, 320);
            btnCancelar.Size = new System.Drawing.Size(90, 30);
            btnCancelar.Click += btnCancelar_Click;
            this.Controls.Add(btnCancelar);

            this.ResumeLayout();
        }
    }
}