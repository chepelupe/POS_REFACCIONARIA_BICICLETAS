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
            btn_eliminar_inventario = new Button();
            btn_modificar_inventario = new Button();
            tb_abuscar_inventario = new TextBox();
            btn_buscar_inventario = new Button();
            groupBox1 = new GroupBox();
            btn_agregar_inventario = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            cb_categoria_busqueda_inventario = new ComboBox();
            btn_salir_inventario = new Button();
            dgv_lista_inventario_inventario = new DataGridView();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_lista_inventario_inventario).BeginInit();
            SuspendLayout();
            // 
            // btn_eliminar_inventario
            // 
            btn_eliminar_inventario.BackColor = Color.FromArgb(220, 53, 69);
            btn_eliminar_inventario.FlatAppearance.BorderSize = 0;
            btn_eliminar_inventario.FlatStyle = FlatStyle.Flat;
            btn_eliminar_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar_inventario.ForeColor = Color.White;
            btn_eliminar_inventario.Location = new Point(126, 21);
            btn_eliminar_inventario.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar_inventario.Name = "btn_eliminar_inventario";
            btn_eliminar_inventario.Size = new Size(84, 27);
            btn_eliminar_inventario.TabIndex = 2;
            btn_eliminar_inventario.Text = "Eliminar";
            btn_eliminar_inventario.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_inventario
            // 
            btn_modificar_inventario.BackColor = Color.FromArgb(255, 193, 7);
            btn_modificar_inventario.FlatAppearance.BorderSize = 0;
            btn_modificar_inventario.FlatStyle = FlatStyle.Flat;
            btn_modificar_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_inventario.ForeColor = Color.White;
            btn_modificar_inventario.Location = new Point(224, 21);
            btn_modificar_inventario.Margin = new Padding(3, 2, 3, 2);
            btn_modificar_inventario.Name = "btn_modificar_inventario";
            btn_modificar_inventario.Size = new Size(84, 27);
            btn_modificar_inventario.TabIndex = 3;
            btn_modificar_inventario.Text = "Modificar";
            btn_modificar_inventario.UseVisualStyleBackColor = false;
            // 
            // tb_abuscar_inventario
            // 
            tb_abuscar_inventario.BorderStyle = BorderStyle.FixedSingle;
            tb_abuscar_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_abuscar_inventario.Location = new Point(112, 24);
            tb_abuscar_inventario.Margin = new Padding(3, 2, 3, 2);
            tb_abuscar_inventario.Name = "tb_abuscar_inventario";
            tb_abuscar_inventario.PlaceholderText = "Ingrese texto a buscar...";
            tb_abuscar_inventario.Size = new Size(141, 23);
            tb_abuscar_inventario.TabIndex = 4;
            // 
            // btn_buscar_inventario
            // 
            btn_buscar_inventario.BackColor = Color.FromArgb(0, 122, 204);
            btn_buscar_inventario.FlatAppearance.BorderSize = 0;
            btn_buscar_inventario.FlatStyle = FlatStyle.Flat;
            btn_buscar_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_inventario.ForeColor = Color.White;
            btn_buscar_inventario.Location = new Point(18, 21);
            btn_buscar_inventario.Margin = new Padding(3, 2, 3, 2);
            btn_buscar_inventario.Name = "btn_buscar_inventario";
            btn_buscar_inventario.Size = new Size(84, 27);
            btn_buscar_inventario.TabIndex = 5;
            btn_buscar_inventario.Text = "Buscar";
            btn_buscar_inventario.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btn_agregar_inventario);
            groupBox1.Controls.Add(btn_eliminar_inventario);
            groupBox1.Controls.Add(btn_modificar_inventario);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 330);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(350, 60);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones del Inventario";
            // 
            // btn_agregar_inventario
            // 
            btn_agregar_inventario.BackColor = Color.FromArgb(40, 167, 69);
            btn_agregar_inventario.FlatAppearance.BorderSize = 0;
            btn_agregar_inventario.FlatStyle = FlatStyle.Flat;
            btn_agregar_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_inventario.ForeColor = Color.White;
            btn_agregar_inventario.Location = new Point(28, 21);
            btn_agregar_inventario.Margin = new Padding(3, 2, 3, 2);
            btn_agregar_inventario.Name = "btn_agregar_inventario";
            btn_agregar_inventario.Size = new Size(84, 27);
            btn_agregar_inventario.TabIndex = 1;
            btn_agregar_inventario.Text = "Agregar";
            btn_agregar_inventario.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cb_categoria_busqueda_inventario);
            groupBox2.Controls.Add(tb_abuscar_inventario);
            groupBox2.Controls.Add(btn_buscar_inventario);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(455, 48);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(280, 90);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Búsqueda y Filtros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 54);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 7;
            label1.Text = "Buscar por:";
            // 
            // cb_categoria_busqueda_inventario
            // 
            cb_categoria_busqueda_inventario.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoria_busqueda_inventario.FlatStyle = FlatStyle.Flat;
            cb_categoria_busqueda_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_categoria_busqueda_inventario.FormattingEnabled = true;
            cb_categoria_busqueda_inventario.Items.AddRange(new object[] { "Nombre", "Categoría", "ID", "Descripción", "Código de Barras" });
            cb_categoria_busqueda_inventario.Location = new Point(112, 51);
            cb_categoria_busqueda_inventario.Margin = new Padding(3, 2, 3, 2);
            cb_categoria_busqueda_inventario.Name = "cb_categoria_busqueda_inventario";
            cb_categoria_busqueda_inventario.Size = new Size(141, 23);
            cb_categoria_busqueda_inventario.TabIndex = 6;
            // 
            // btn_salir_inventario
            // 
            btn_salir_inventario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salir_inventario.BackColor = Color.FromArgb(108, 117, 125);
            btn_salir_inventario.FlatAppearance.BorderSize = 0;
            btn_salir_inventario.FlatStyle = FlatStyle.Flat;
            btn_salir_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salir_inventario.ForeColor = Color.White;
            btn_salir_inventario.Location = new Point(651, 348);
            btn_salir_inventario.Margin = new Padding(3, 2, 3, 2);
            btn_salir_inventario.Name = "btn_salir_inventario";
            btn_salir_inventario.Size = new Size(84, 36);
            btn_salir_inventario.TabIndex = 8;
            btn_salir_inventario.Text = "Salir";
            btn_salir_inventario.UseVisualStyleBackColor = false;
            // 
            // dgv_lista_inventario_inventario
            // 
            dgv_lista_inventario_inventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_lista_inventario_inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_lista_inventario_inventario.BackgroundColor = Color.White;
            dgv_lista_inventario_inventario.BorderStyle = BorderStyle.Fixed3D;
            dgv_lista_inventario_inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lista_inventario_inventario.GridColor = SystemColors.Control;
            dgv_lista_inventario_inventario.Location = new Point(21, 48);
            dgv_lista_inventario_inventario.Margin = new Padding(3, 2, 3, 2);
            dgv_lista_inventario_inventario.Name = "dgv_lista_inventario_inventario";
            dgv_lista_inventario_inventario.RowHeadersWidth = 62;
            dgv_lista_inventario_inventario.Size = new Size(420, 270);
            dgv_lista_inventario_inventario.TabIndex = 11;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(763, 42);
            panelHeader.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(315, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(119, 30);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Inventario";
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(763, 408);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(dgv_lista_inventario_inventario);
            Controls.Add(btn_salir_inventario);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(779, 446);
            Name = "FormInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Inventario - POS Refaccionaria";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_lista_inventario_inventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_eliminar_inventario;
        private Button btn_modificar_inventario;
        private TextBox tb_abuscar_inventario;
        private Button btn_buscar_inventario;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cb_categoria_busqueda_inventario;
        private Button btn_salir_inventario;
        private DataGridView dgv_lista_inventario_inventario;
        private Button btn_agregar_inventario;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}