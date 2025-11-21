namespace pos_proyecto
{
    partial class FormBuscarProducto
    {
        private DataGridView dgv_productos_buscarproducto;
        private Button btn_seleccionar_buscarproducto;
        private Button btn_cancelar_buscarproducto;
        private TextBox txt_buscar_buscarproducto;
        private Label lblBuscar;
        private Button btn_buscar_buscarproducto;
        private ComboBox cb_categoria_buscarproducto;
        private Label lblCategoria;
        private ComboBox cb_marca_buscarproducto;
        private Label lblMarca;

        private void InitializeComponent()
        {
            lblBuscar = new Label();
            txt_buscar_buscarproducto = new TextBox();
            lblCategoria = new Label();
            cb_categoria_buscarproducto = new ComboBox();
            lblMarca = new Label();
            cb_marca_buscarproducto = new ComboBox();
            btn_buscar_buscarproducto = new Button();
            dgv_productos_buscarproducto = new DataGridView();
            btn_seleccionar_buscarproducto = new Button();
            btn_cancelar_buscarproducto = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_productos_buscarproducto).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(12, 15);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            // 
            // txt_buscar_buscarproducto
            // 
            txt_buscar_buscarproducto.Location = new Point(60, 12);
            txt_buscar_buscarproducto.Name = "txt_buscar_buscarproducto";
            txt_buscar_buscarproducto.PlaceholderText = "Nombre, código de barras...";
            txt_buscar_buscarproducto.Size = new Size(200, 23);
            txt_buscar_buscarproducto.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(270, 15);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(65, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría:";
            // 
            // cb_categoria_buscarproducto
            // 
            cb_categoria_buscarproducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoria_buscarproducto.Location = new Point(340, 12);
            cb_categoria_buscarproducto.Name = "cb_categoria_buscarproducto";
            cb_categoria_buscarproducto.Size = new Size(130, 23);
            cb_categoria_buscarproducto.TabIndex = 3;
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(480, 15);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(45, 20);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca:";
            // 
            // cb_marca_buscarproducto
            // 
            cb_marca_buscarproducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_marca_buscarproducto.Location = new Point(530, 12);
            cb_marca_buscarproducto.Name = "cb_marca_buscarproducto";
            cb_marca_buscarproducto.Size = new Size(130, 23);
            cb_marca_buscarproducto.TabIndex = 5;
            // 
            // btn_buscar_buscarproducto
            // 
            btn_buscar_buscarproducto.Location = new Point(670, 12);
            btn_buscar_buscarproducto.Name = "btn_buscar_buscarproducto";
            btn_buscar_buscarproducto.Size = new Size(75, 23);
            btn_buscar_buscarproducto.TabIndex = 6;
            btn_buscar_buscarproducto.Text = "Buscar";
            // 
            // dgv_productos_buscarproducto
            // 
            dgv_productos_buscarproducto.AllowUserToAddRows = false;
            dgv_productos_buscarproducto.AllowUserToDeleteRows = false;
            dgv_productos_buscarproducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_productos_buscarproducto.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgv_productos_buscarproducto.Location = new Point(12, 45);
            dgv_productos_buscarproducto.Name = "dgv_productos_buscarproducto";
            dgv_productos_buscarproducto.ReadOnly = true;
            dgv_productos_buscarproducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos_buscarproducto.Size = new Size(760, 350);
            dgv_productos_buscarproducto.TabIndex = 7;
            // 
            // btn_seleccionar_buscarproducto
            // 
            btn_seleccionar_buscarproducto.Location = new Point(600, 410);
            btn_seleccionar_buscarproducto.Name = "btn_seleccionar_buscarproducto";
            btn_seleccionar_buscarproducto.Size = new Size(80, 35);
            btn_seleccionar_buscarproducto.TabIndex = 8;
            btn_seleccionar_buscarproducto.Text = "Seleccionar";
            btn_seleccionar_buscarproducto.UseVisualStyleBackColor = true;
            btn_seleccionar_buscarproducto.Click += btnSeleccionar_Click;
            // 
            // btn_cancelar_buscarproducto
            // 
            btn_cancelar_buscarproducto.Location = new Point(690, 410);
            btn_cancelar_buscarproducto.Name = "btn_cancelar_buscarproducto";
            btn_cancelar_buscarproducto.Size = new Size(80, 35);
            btn_cancelar_buscarproducto.TabIndex = 9;
            btn_cancelar_buscarproducto.Text = "Cancelar";
            btn_cancelar_buscarproducto.UseVisualStyleBackColor = true;
            btn_cancelar_buscarproducto.Click += btnCancelar_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Código Barras";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Precio Venta";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Precio Compra";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Stock";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Marca";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Categoría";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Unidad Medida";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // FormBuscarProducto
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(lblBuscar);
            Controls.Add(txt_buscar_buscarproducto);
            Controls.Add(lblCategoria);
            Controls.Add(cb_categoria_buscarproducto);
            Controls.Add(lblMarca);
            Controls.Add(cb_marca_buscarproducto);
            Controls.Add(btn_buscar_buscarproducto);
            Controls.Add(dgv_productos_buscarproducto);
            Controls.Add(btn_seleccionar_buscarproducto);
            Controls.Add(btn_cancelar_buscarproducto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuscarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buscar Producto - POS Refaccionaria";
            ((System.ComponentModel.ISupportInitialize)dgv_productos_buscarproducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}