namespace pos_proyecto
{
    partial class FormComprasNuevaCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprasNuevaCompra));
            groupBox3 = new GroupBox();
            lbl_total_venta = new Label();
            label17 = new Label();
            lbl_iva_venta = new Label();
            label11 = new Label();
            lbl_subtotal_venta = new Label();
            label16 = new Label();
            dataGridView1 = new DataGridView();
            CLAVE = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btn_f6_productos_proveedores = new Button();
            btn_f5_pagos_proveedores = new Button();
            btn_f4_compras_proveedores = new Button();
            btn_f3_eliminar_proveedores = new Button();
            btn_f2_modificar_proveedores = new Button();
            btn_f1_agregar_proveedores = new Button();
            btn_regresar_proveedores = new Button();
            tb_busqueda_compras = new TextBox();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox2 = new GroupBox();
            lbl_proveedor_compra = new Label();
            lbl_folio_compra = new Label();
            lbl_fecha_compra = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lbl_total_venta);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(lbl_iva_venta);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lbl_subtotal_venta);
            groupBox3.Controls.Add(label16);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(30, 450);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(1000, 80);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales de Compra";
            // 
            // lbl_total_venta
            // 
            lbl_total_venta.AutoSize = true;
            lbl_total_venta.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_venta.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_total_venta.Location = new Point(850, 30);
            lbl_total_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_total_venta.Name = "lbl_total_venta";
            lbl_total_venta.Size = new Size(85, 38);
            lbl_total_venta.TabIndex = 29;
            lbl_total_venta.Text = "$0.00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(770, 35);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(70, 32);
            label17.TabIndex = 28;
            label17.Text = "Total:";
            // 
            // lbl_iva_venta
            // 
            lbl_iva_venta.AutoSize = true;
            lbl_iva_venta.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_iva_venta.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_iva_venta.Location = new Point(550, 35);
            lbl_iva_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_iva_venta.Name = "lbl_iva_venta";
            lbl_iva_venta.Size = new Size(85, 30);
            lbl_iva_venta.TabIndex = 23;
            lbl_iva_venta.Text = "$0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(500, 40);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(45, 28);
            label11.TabIndex = 20;
            label11.Text = "IVA:";
            // 
            // lbl_subtotal_venta
            // 
            lbl_subtotal_venta.AutoSize = true;
            lbl_subtotal_venta.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_subtotal_venta.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_subtotal_venta.Location = new Point(250, 35);
            lbl_subtotal_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_subtotal_venta.Name = "lbl_subtotal_venta";
            lbl_subtotal_venta.Size = new Size(85, 30);
            lbl_subtotal_venta.TabIndex = 18;
            lbl_subtotal_venta.Text = "$0.00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(160, 40);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(87, 28);
            label16.TabIndex = 15;
            label16.Text = "Subtotal:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CLAVE, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(30, 250);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1200, 180);
            dataGridView1.TabIndex = 4;
            // 
            // CLAVE
            // 
            CLAVE.FillWeight = 80F;
            CLAVE.HeaderText = "CLAVE";
            CLAVE.MinimumWidth = 8;
            CLAVE.Name = "CLAVE";
            // 
            // Column1
            // 
            Column1.FillWeight = 60F;
            Column1.HeaderText = "CANT";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 70F;
            Column2.HeaderText = "UNIDAD";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 200F;
            Column3.HeaderText = "DESCRIPCIÓN";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 80F;
            Column4.HeaderText = "PRECIO";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 90F;
            Column5.HeaderText = "IMPORTE";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btn_f6_productos_proveedores);
            groupBox1.Controls.Add(btn_f5_pagos_proveedores);
            groupBox1.Controls.Add(btn_f4_compras_proveedores);
            groupBox1.Controls.Add(btn_f3_eliminar_proveedores);
            groupBox1.Controls.Add(btn_f2_modificar_proveedores);
            groupBox1.Controls.Add(btn_f1_agregar_proveedores);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 550);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1000, 100);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones de Compra";
            // 
            // btn_f6_productos_proveedores
            // 
            btn_f6_productos_proveedores.BackColor = Color.FromArgb(40, 167, 69);
            btn_f6_productos_proveedores.FlatAppearance.BorderSize = 0;
            btn_f6_productos_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f6_productos_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f6_productos_proveedores.ForeColor = Color.White;
            btn_f6_productos_proveedores.Location = new Point(830, 25);
            btn_f6_productos_proveedores.Margin = new Padding(4);
            btn_f6_productos_proveedores.Name = "btn_f6_productos_proveedores";
            btn_f6_productos_proveedores.Size = new Size(150, 60);
            btn_f6_productos_proveedores.TabIndex = 9;
            btn_f6_productos_proveedores.Text = "F6 - Finalizar Compra";
            btn_f6_productos_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f5_pagos_proveedores
            // 
            btn_f5_pagos_proveedores.BackColor = Color.FromArgb(32, 201, 151);
            btn_f5_pagos_proveedores.FlatAppearance.BorderSize = 0;
            btn_f5_pagos_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f5_pagos_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f5_pagos_proveedores.ForeColor = Color.White;
            btn_f5_pagos_proveedores.Location = new Point(670, 25);
            btn_f5_pagos_proveedores.Margin = new Padding(4);
            btn_f5_pagos_proveedores.Name = "btn_f5_pagos_proveedores";
            btn_f5_pagos_proveedores.Size = new Size(150, 60);
            btn_f5_pagos_proveedores.TabIndex = 8;
            btn_f5_pagos_proveedores.Text = "F5 - Método Pago";
            btn_f5_pagos_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f4_compras_proveedores
            // 
            btn_f4_compras_proveedores.BackColor = Color.FromArgb(111, 66, 193);
            btn_f4_compras_proveedores.FlatAppearance.BorderSize = 0;
            btn_f4_compras_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f4_compras_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f4_compras_proveedores.ForeColor = Color.White;
            btn_f4_compras_proveedores.Location = new Point(510, 25);
            btn_f4_compras_proveedores.Margin = new Padding(4);
            btn_f4_compras_proveedores.Name = "btn_f4_compras_proveedores";
            btn_f4_compras_proveedores.Size = new Size(150, 60);
            btn_f4_compras_proveedores.TabIndex = 7;
            btn_f4_compras_proveedores.Text = "F4 - Historial Compras";
            btn_f4_compras_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f3_eliminar_proveedores
            // 
            btn_f3_eliminar_proveedores.BackColor = Color.FromArgb(220, 53, 69);
            btn_f3_eliminar_proveedores.FlatAppearance.BorderSize = 0;
            btn_f3_eliminar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f3_eliminar_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f3_eliminar_proveedores.ForeColor = Color.White;
            btn_f3_eliminar_proveedores.Location = new Point(350, 25);
            btn_f3_eliminar_proveedores.Margin = new Padding(4);
            btn_f3_eliminar_proveedores.Name = "btn_f3_eliminar_proveedores";
            btn_f3_eliminar_proveedores.Size = new Size(150, 60);
            btn_f3_eliminar_proveedores.TabIndex = 6;
            btn_f3_eliminar_proveedores.Text = "F3 - Eliminar";
            btn_f3_eliminar_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f2_modificar_proveedores
            // 
            btn_f2_modificar_proveedores.BackColor = Color.FromArgb(255, 193, 7);
            btn_f2_modificar_proveedores.FlatAppearance.BorderSize = 0;
            btn_f2_modificar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f2_modificar_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f2_modificar_proveedores.ForeColor = Color.White;
            btn_f2_modificar_proveedores.Location = new Point(190, 25);
            btn_f2_modificar_proveedores.Margin = new Padding(4);
            btn_f2_modificar_proveedores.Name = "btn_f2_modificar_proveedores";
            btn_f2_modificar_proveedores.Size = new Size(150, 60);
            btn_f2_modificar_proveedores.TabIndex = 5;
            btn_f2_modificar_proveedores.Text = "F2 - Modificar";
            btn_f2_modificar_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f1_agregar_proveedores
            // 
            btn_f1_agregar_proveedores.BackColor = Color.FromArgb(0, 122, 204);
            btn_f1_agregar_proveedores.FlatAppearance.BorderSize = 0;
            btn_f1_agregar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f1_agregar_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f1_agregar_proveedores.ForeColor = Color.White;
            btn_f1_agregar_proveedores.Location = new Point(30, 25);
            btn_f1_agregar_proveedores.Margin = new Padding(4);
            btn_f1_agregar_proveedores.Name = "btn_f1_agregar_proveedores";
            btn_f1_agregar_proveedores.Size = new Size(150, 60);
            btn_f1_agregar_proveedores.TabIndex = 4;
            btn_f1_agregar_proveedores.Text = "F1 - Agregar Producto";
            btn_f1_agregar_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_regresar_proveedores
            // 
            btn_regresar_proveedores.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_regresar_proveedores.BackColor = Color.FromArgb(108, 117, 125);
            btn_regresar_proveedores.FlatAppearance.BorderSize = 0;
            btn_regresar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_regresar_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_regresar_proveedores.ForeColor = Color.White;
            btn_regresar_proveedores.Location = new Point(1110, 580);
            btn_regresar_proveedores.Margin = new Padding(4);
            btn_regresar_proveedores.Name = "btn_regresar_proveedores";
            btn_regresar_proveedores.Size = new Size(120, 60);
            btn_regresar_proveedores.TabIndex = 16;
            btn_regresar_proveedores.Text = "Regresar";
            btn_regresar_proveedores.UseVisualStyleBackColor = false;
            // 
            // tb_busqueda_compras
            // 
            tb_busqueda_compras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_busqueda_compras.BorderStyle = BorderStyle.FixedSingle;
            tb_busqueda_compras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_busqueda_compras.Location = new Point(30, 200);
            tb_busqueda_compras.Margin = new Padding(4);
            tb_busqueda_compras.Name = "tb_busqueda_compras";
            tb_busqueda_compras.PlaceholderText = "Buscar producto por código, nombre o descripción...";
            tb_busqueda_compras.Size = new Size(1200, 39);
            tb_busqueda_compras.TabIndex = 17;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1264, 70);
            panelHeader.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(500, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(264, 45);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Nueva Compra";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lbl_proveedor_compra);
            groupBox2.Controls.Add(lbl_folio_compra);
            groupBox2.Controls.Add(lbl_fecha_compra);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(30, 80);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1200, 100);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Compra";
            // 
            // lbl_proveedor_compra
            // 
            lbl_proveedor_compra.AutoSize = true;
            lbl_proveedor_compra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_proveedor_compra.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_proveedor_compra.Location = new Point(180, 60);
            lbl_proveedor_compra.Margin = new Padding(4, 0, 4, 0);
            lbl_proveedor_compra.Name = "lbl_proveedor_compra";
            lbl_proveedor_compra.Size = new Size(178, 28);
            lbl_proveedor_compra.TabIndex = 6;
            lbl_proveedor_compra.Text = "Proveedor General";
            // 
            // lbl_folio_compra
            // 
            lbl_folio_compra.AutoSize = true;
            lbl_folio_compra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_folio_compra.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_folio_compra.Location = new Point(800, 35);
            lbl_folio_compra.Margin = new Padding(4, 0, 4, 0);
            lbl_folio_compra.Name = "lbl_folio_compra";
            lbl_folio_compra.Size = new Size(52, 28);
            lbl_folio_compra.TabIndex = 5;
            lbl_folio_compra.Text = "0001";
            // 
            // lbl_fecha_compra
            // 
            lbl_fecha_compra.AutoSize = true;
            lbl_fecha_compra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fecha_compra.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_fecha_compra.Location = new Point(800, 15);
            lbl_fecha_compra.Margin = new Padding(4, 0, 4, 0);
            lbl_fecha_compra.Name = "lbl_fecha_compra";
            lbl_fecha_compra.Size = new Size(140, 28);
            lbl_fecha_compra.TabIndex = 4;
            lbl_fecha_compra.Text = "01/01/2024";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(700, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 3;
            label4.Text = "Folio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(730, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Proveedor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // FormComprasNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1264, 680);
            Controls.Add(groupBox2);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(tb_busqueda_compras);
            Controls.Add(btn_regresar_proveedores);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1286, 736);
            Name = "FormComprasNuevaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Compra - POS Refaccionaria";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Label lbl_total_venta;
        private Label label17;
        private Label lbl_iva_venta;
        private Label label11;
        private Label lbl_subtotal_venta;
        private Label label16;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CLAVE;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox1;
        private Button btn_f6_productos_proveedores;
        private Button btn_f5_pagos_proveedores;
        private Button btn_f4_compras_proveedores;
        private Button btn_f3_eliminar_proveedores;
        private Button btn_f2_modificar_proveedores;
        private Button btn_f1_agregar_proveedores;
        private Button btn_regresar_proveedores;
        private TextBox tb_busqueda_compras;
        private Panel panelHeader;
        private Label lblTitulo;
        private GroupBox groupBox2;
        private Label lbl_proveedor_compra;
        private Label lbl_folio_compra;
        private Label lbl_fecha_compra;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}