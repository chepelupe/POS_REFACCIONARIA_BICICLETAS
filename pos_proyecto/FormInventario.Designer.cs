namespace pos_proyecto
{
    partial class FormInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            btn_eliminar = new Button();
            btn_modificar = new Button();
            tb_abuscar = new TextBox();
            btn_buscar = new Button();
            groupBox1 = new GroupBox();
            btn_agregar = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            cb_categoria_busqueda = new ComboBox();
            button1 = new Button();
            dgv_listaInventario = new DataGridView();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listaInventario).BeginInit();
            SuspendLayout();
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(220, 53, 69);
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(180, 35);
            btn_eliminar.Margin = new Padding(4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(120, 45);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(255, 193, 7);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar.ForeColor = Color.White;
            btn_modificar.Location = new Point(320, 35);
            btn_modificar.Margin = new Padding(4);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(120, 45);
            btn_modificar.TabIndex = 3;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            // 
            // tb_abuscar
            // 
            tb_abuscar.BorderStyle = BorderStyle.FixedSingle;
            tb_abuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_abuscar.Location = new Point(160, 40);
            tb_abuscar.Margin = new Padding(4);
            tb_abuscar.Name = "tb_abuscar";
            tb_abuscar.PlaceholderText = "Ingrese texto a buscar...";
            tb_abuscar.Size = new Size(200, 31);
            tb_abuscar.TabIndex = 4;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 122, 204);
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Location = new Point(25, 35);
            btn_buscar.Margin = new Padding(4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(120, 45);
            btn_buscar.TabIndex = 5;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(btn_modificar);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 550);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(500, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones del Inventario";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(40, 167, 69);
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = Color.White;
            btn_agregar.Location = new Point(40, 35);
            btn_agregar.Margin = new Padding(4);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(120, 45);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cb_categoria_busqueda);
            groupBox2.Controls.Add(tb_abuscar);
            groupBox2.Controls.Add(btn_buscar);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(650, 80);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(400, 150);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Búsqueda y Filtros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 7;
            label1.Text = "Buscar por:";
            // 
            // cb_categoria_busqueda
            // 
            cb_categoria_busqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoria_busqueda.FlatStyle = FlatStyle.Flat;
            cb_categoria_busqueda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_categoria_busqueda.FormattingEnabled = true;
            cb_categoria_busqueda.Items.AddRange(new object[] { "Nombre", "Categoría", "ID", "Descripción", "Código de Barras" });
            cb_categoria_busqueda.Location = new Point(160, 85);
            cb_categoria_busqueda.Margin = new Padding(4);
            cb_categoria_busqueda.Name = "cb_categoria_busqueda";
            cb_categoria_busqueda.Size = new Size(200, 33);
            cb_categoria_busqueda.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(108, 117, 125);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(930, 580);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(120, 60);
            button1.TabIndex = 8;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgv_listaInventario
            // 
            dgv_listaInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listaInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaInventario.BackgroundColor = Color.White;
            dgv_listaInventario.BorderStyle = BorderStyle.Fixed3D;
            dgv_listaInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaInventario.GridColor = SystemColors.Control;
            dgv_listaInventario.Location = new Point(30, 80);
            dgv_listaInventario.Margin = new Padding(4);
            dgv_listaInventario.Name = "dgv_listaInventario";
            dgv_listaInventario.RowHeadersWidth = 62;
            dgv_listaInventario.Size = new Size(600, 450);
            dgv_listaInventario.TabIndex = 11;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1084, 70);
            panelHeader.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(450, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 45);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Inventario";
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1084, 680);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(dgv_listaInventario);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1106, 736);
            Name = "FormInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Inventario - POS Refaccionaria";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listaInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_eliminar;
        private Button btn_modificar;
        private TextBox tb_abuscar;
        private Button btn_buscar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cb_categoria_busqueda;
        private Button button1;
        private DataGridView dgv_listaInventario;
        private Button btn_agregar;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}