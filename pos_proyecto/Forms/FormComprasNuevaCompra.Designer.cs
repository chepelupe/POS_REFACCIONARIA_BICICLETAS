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
            groupBox3 = new GroupBox();
            lbl_total_venta_nuevacompra = new Label();
            label17 = new Label();
            lbl_iva_venta_nuevacompra = new Label();
            label11 = new Label();
            lbl_subtotal_venta_nuevacompra = new Label();
            label16 = new Label();
            dgv_compras_nuevacompra = new DataGridView();
            CLAVE = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btn_f6_productos_nuevacompra = new Button();
            btn_f5_pagos_nuevacompra = new Button();
            btn_f4_compras_nuevacompra = new Button();
            btn_f3_eliminar_nuevacompra = new Button();
            btn_f2_modificar_nuevacompra = new Button();
            btn_f1_agregar_nuevacompra = new Button();
            btn_regresar_nuevacompra = new Button();
            tb_busqueda_nuevacompra = new TextBox();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox2 = new GroupBox();
            lbl_proveedor_nuevacompra = new Label();
            lbl_folio_nuevacompra = new Label();
            lbl_fecha_compra_nuevacompra = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_nombre_empleado_nuevacompra = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_compras_nuevacompra).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lbl_total_venta_nuevacompra);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(lbl_iva_venta_nuevacompra);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lbl_subtotal_venta_nuevacompra);
            groupBox3.Controls.Add(label16);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(21, 288);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(700, 48);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales de Compra";
            // 
            // lbl_total_venta_nuevacompra
            // 
            lbl_total_venta_nuevacompra.AutoSize = true;
            lbl_total_venta_nuevacompra.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_venta_nuevacompra.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_total_venta_nuevacompra.Location = new Point(595, 18);
            lbl_total_venta_nuevacompra.Name = "lbl_total_venta_nuevacompra";
            lbl_total_venta_nuevacompra.Size = new Size(61, 25);
            lbl_total_venta_nuevacompra.TabIndex = 29;
            lbl_total_venta_nuevacompra.Text = "$0.00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(539, 21);
            label17.Name = "label17";
            label17.Size = new Size(52, 21);
            label17.TabIndex = 28;
            label17.Text = "Total:";
            // 
            // lbl_iva_venta_nuevacompra
            // 
            lbl_iva_venta_nuevacompra.AutoSize = true;
            lbl_iva_venta_nuevacompra.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_iva_venta_nuevacompra.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_iva_venta_nuevacompra.Location = new Point(385, 21);
            lbl_iva_venta_nuevacompra.Name = "lbl_iva_venta_nuevacompra";
            lbl_iva_venta_nuevacompra.Size = new Size(49, 20);
            lbl_iva_venta_nuevacompra.TabIndex = 23;
            lbl_iva_venta_nuevacompra.Text = "$0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(350, 24);
            label11.Name = "label11";
            label11.Size = new Size(33, 19);
            label11.TabIndex = 20;
            label11.Text = "IVA:";
            // 
            // lbl_subtotal_venta_nuevacompra
            // 
            lbl_subtotal_venta_nuevacompra.AutoSize = true;
            lbl_subtotal_venta_nuevacompra.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_subtotal_venta_nuevacompra.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_subtotal_venta_nuevacompra.Location = new Point(175, 21);
            lbl_subtotal_venta_nuevacompra.Name = "lbl_subtotal_venta_nuevacompra";
            lbl_subtotal_venta_nuevacompra.Size = new Size(49, 20);
            lbl_subtotal_venta_nuevacompra.TabIndex = 18;
            lbl_subtotal_venta_nuevacompra.Text = "$0.00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(112, 24);
            label16.Name = "label16";
            label16.Size = new Size(63, 19);
            label16.TabIndex = 15;
            label16.Text = "Subtotal:";
            // 
            // dgv_compras_nuevacompra
            // 
            dgv_compras_nuevacompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_compras_nuevacompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_compras_nuevacompra.BackgroundColor = Color.White;
            dgv_compras_nuevacompra.BorderStyle = BorderStyle.Fixed3D;
            dgv_compras_nuevacompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_compras_nuevacompra.Columns.AddRange(new DataGridViewColumn[] { CLAVE, Column1, Column2, Column3, Column4, Column5 });
            dgv_compras_nuevacompra.GridColor = SystemColors.Control;
            dgv_compras_nuevacompra.Location = new Point(21, 150);
            dgv_compras_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            dgv_compras_nuevacompra.Name = "dgv_compras_nuevacompra";
            dgv_compras_nuevacompra.RowHeadersWidth = 62;
            dgv_compras_nuevacompra.Size = new Size(840, 126);
            dgv_compras_nuevacompra.TabIndex = 4;
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
            groupBox1.Controls.Add(btn_f6_productos_nuevacompra);
            groupBox1.Controls.Add(btn_f5_pagos_nuevacompra);
            groupBox1.Controls.Add(btn_f4_compras_nuevacompra);
            groupBox1.Controls.Add(btn_f3_eliminar_nuevacompra);
            groupBox1.Controls.Add(btn_f2_modificar_nuevacompra);
            groupBox1.Controls.Add(btn_f1_agregar_nuevacompra);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 348);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(700, 60);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones de Compra";
            // 
            // btn_f6_productos_nuevacompra
            // 
            btn_f6_productos_nuevacompra.BackColor = Color.FromArgb(40, 167, 69);
            btn_f6_productos_nuevacompra.FlatAppearance.BorderSize = 0;
            btn_f6_productos_nuevacompra.FlatStyle = FlatStyle.Flat;
            btn_f6_productos_nuevacompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f6_productos_nuevacompra.ForeColor = Color.White;
            btn_f6_productos_nuevacompra.Location = new Point(581, 15);
            btn_f6_productos_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            btn_f6_productos_nuevacompra.Name = "btn_f6_productos_nuevacompra";
            btn_f6_productos_nuevacompra.Size = new Size(105, 36);
            btn_f6_productos_nuevacompra.TabIndex = 9;
            btn_f6_productos_nuevacompra.Text = "F6 - Finalizar Compra";
            btn_f6_productos_nuevacompra.UseVisualStyleBackColor = false;
            // 
            // btn_f5_pagos_nuevacompra
            // 
            btn_f5_pagos_nuevacompra.BackColor = Color.FromArgb(32, 201, 151);
            btn_f5_pagos_nuevacompra.FlatAppearance.BorderSize = 0;
            btn_f5_pagos_nuevacompra.FlatStyle = FlatStyle.Flat;
            btn_f5_pagos_nuevacompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f5_pagos_nuevacompra.ForeColor = Color.White;
            btn_f5_pagos_nuevacompra.Location = new Point(469, 15);
            btn_f5_pagos_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            btn_f5_pagos_nuevacompra.Name = "btn_f5_pagos_nuevacompra";
            btn_f5_pagos_nuevacompra.Size = new Size(105, 36);
            btn_f5_pagos_nuevacompra.TabIndex = 8;
            btn_f5_pagos_nuevacompra.Text = "F5 - Método Pago";
            btn_f5_pagos_nuevacompra.UseVisualStyleBackColor = false;
            // 
            // btn_f4_compras_nuevacompra
            // 
            btn_f4_compras_nuevacompra.BackColor = Color.FromArgb(111, 66, 193);
            btn_f4_compras_nuevacompra.FlatAppearance.BorderSize = 0;
            btn_f4_compras_nuevacompra.FlatStyle = FlatStyle.Flat;
            btn_f4_compras_nuevacompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f4_compras_nuevacompra.ForeColor = Color.White;
            btn_f4_compras_nuevacompra.Location = new Point(357, 15);
            btn_f4_compras_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            btn_f4_compras_nuevacompra.Name = "btn_f4_compras_nuevacompra";
            btn_f4_compras_nuevacompra.Size = new Size(105, 36);
            btn_f4_compras_nuevacompra.TabIndex = 7;
            btn_f4_compras_nuevacompra.Text = "F4 - Historial Compras";
            btn_f4_compras_nuevacompra.UseVisualStyleBackColor = false;
            // 
            // btn_f3_eliminar_nuevacompra
            // 
            btn_f3_eliminar_nuevacompra.BackColor = Color.FromArgb(220, 53, 69);
            btn_f3_eliminar_nuevacompra.FlatAppearance.BorderSize = 0;
            btn_f3_eliminar_nuevacompra.FlatStyle = FlatStyle.Flat;
            btn_f3_eliminar_nuevacompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f3_eliminar_nuevacompra.ForeColor = Color.White;
            btn_f3_eliminar_nuevacompra.Location = new Point(245, 15);
            btn_f3_eliminar_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            btn_f3_eliminar_nuevacompra.Name = "btn_f3_eliminar_nuevacompra";
            btn_f3_eliminar_nuevacompra.Size = new Size(105, 36);
            btn_f3_eliminar_nuevacompra.TabIndex = 6;
            btn_f3_eliminar_nuevacompra.Text = "F3 - Eliminar";
            btn_f3_eliminar_nuevacompra.UseVisualStyleBackColor = false;
            // 
            // btn_f2_modificar_nuevacompra
            // 
            btn_f2_modificar_nuevacompra.BackColor = Color.FromArgb(255, 193, 7);
            btn_f2_modificar_nuevacompra.FlatAppearance.BorderSize = 0;
            btn_f2_modificar_nuevacompra.FlatStyle = FlatStyle.Flat;
            btn_f2_modificar_nuevacompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f2_modificar_nuevacompra.ForeColor = Color.White;
            btn_f2_modificar_nuevacompra.Location = new Point(133, 15);
            btn_f2_modificar_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            btn_f2_modificar_nuevacompra.Name = "btn_f2_modificar_nuevacompra";
            btn_f2_modificar_nuevacompra.Size = new Size(105, 36);
            btn_f2_modificar_nuevacompra.TabIndex = 5;
            btn_f2_modificar_nuevacompra.Text = "F2 - Modificar";
            btn_f2_modificar_nuevacompra.UseVisualStyleBackColor = false;
            // 
            // btn_f1_agregar_nuevacompra
            // 
            btn_f1_agregar_nuevacompra.BackColor = Color.FromArgb(0, 122, 204);
            btn_f1_agregar_nuevacompra.FlatAppearance.BorderSize = 0;
            btn_f1_agregar_nuevacompra.FlatStyle = FlatStyle.Flat;
            btn_f1_agregar_nuevacompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f1_agregar_nuevacompra.ForeColor = Color.White;
            btn_f1_agregar_nuevacompra.Location = new Point(21, 15);
            btn_f1_agregar_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            btn_f1_agregar_nuevacompra.Name = "btn_f1_agregar_nuevacompra";
            btn_f1_agregar_nuevacompra.Size = new Size(105, 36);
            btn_f1_agregar_nuevacompra.TabIndex = 4;
            btn_f1_agregar_nuevacompra.Text = "F1 - Agregar Producto";
            btn_f1_agregar_nuevacompra.UseVisualStyleBackColor = false;
            // 
            // btn_regresar_nuevacompra
            // 
            btn_regresar_nuevacompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_regresar_nuevacompra.BackColor = Color.FromArgb(108, 117, 125);
            btn_regresar_nuevacompra.FlatAppearance.BorderSize = 0;
            btn_regresar_nuevacompra.FlatStyle = FlatStyle.Flat;
            btn_regresar_nuevacompra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_regresar_nuevacompra.ForeColor = Color.White;
            btn_regresar_nuevacompra.Location = new Point(777, 366);
            btn_regresar_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            btn_regresar_nuevacompra.Name = "btn_regresar_nuevacompra";
            btn_regresar_nuevacompra.Size = new Size(84, 36);
            btn_regresar_nuevacompra.TabIndex = 16;
            btn_regresar_nuevacompra.Text = "Regresar";
            btn_regresar_nuevacompra.UseVisualStyleBackColor = false;
            // 
            // tb_busqueda_nuevacompra
            // 
            tb_busqueda_nuevacompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_busqueda_nuevacompra.BorderStyle = BorderStyle.FixedSingle;
            tb_busqueda_nuevacompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_busqueda_nuevacompra.Location = new Point(21, 120);
            tb_busqueda_nuevacompra.Margin = new Padding(3, 2, 3, 2);
            tb_busqueda_nuevacompra.Name = "tb_busqueda_nuevacompra";
            tb_busqueda_nuevacompra.PlaceholderText = "Buscar producto por código, nombre o descripción...";
            tb_busqueda_nuevacompra.Size = new Size(841, 29);
            tb_busqueda_nuevacompra.TabIndex = 17;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(889, 42);
            panelHeader.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(350, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(167, 30);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Nueva Compra";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lbl_nombre_empleado_nuevacompra);
            groupBox2.Controls.Add(lbl_proveedor_nuevacompra);
            groupBox2.Controls.Add(lbl_folio_nuevacompra);
            groupBox2.Controls.Add(lbl_fecha_compra_nuevacompra);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 48);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(840, 60);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Compra";
            // 
            // lbl_proveedor_nuevacompra
            // 
            lbl_proveedor_nuevacompra.AutoSize = true;
            lbl_proveedor_nuevacompra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_proveedor_nuevacompra.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_proveedor_nuevacompra.Location = new Point(126, 36);
            lbl_proveedor_nuevacompra.Name = "lbl_proveedor_nuevacompra";
            lbl_proveedor_nuevacompra.Size = new Size(137, 19);
            lbl_proveedor_nuevacompra.TabIndex = 6;
            lbl_proveedor_nuevacompra.Text = "Proveedor General";
            // 
            // lbl_folio_nuevacompra
            // 
            lbl_folio_nuevacompra.AutoSize = true;
            lbl_folio_nuevacompra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_folio_nuevacompra.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_folio_nuevacompra.Location = new Point(581, 28);
            lbl_folio_nuevacompra.Name = "lbl_folio_nuevacompra";
            lbl_folio_nuevacompra.Size = new Size(41, 19);
            lbl_folio_nuevacompra.TabIndex = 5;
            lbl_folio_nuevacompra.Text = "0001";
            // 
            // lbl_fecha_compra_nuevacompra
            // 
            lbl_fecha_compra_nuevacompra.AutoSize = true;
            lbl_fecha_compra_nuevacompra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fecha_compra_nuevacompra.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_fecha_compra_nuevacompra.Location = new Point(560, 9);
            lbl_fecha_compra_nuevacompra.Name = "lbl_fecha_compra_nuevacompra";
            lbl_fecha_compra_nuevacompra.Size = new Size(85, 19);
            lbl_fecha_compra_nuevacompra.TabIndex = 4;
            lbl_fecha_compra_nuevacompra.Text = "01/01/2024";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(511, 31);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Folio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(511, 12);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Proveedor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // lbl_nombre_empleado_nuevacompra
            // 
            lbl_nombre_empleado_nuevacompra.AutoSize = true;
            lbl_nombre_empleado_nuevacompra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre_empleado_nuevacompra.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_nombre_empleado_nuevacompra.Location = new Point(134, 12);
            lbl_nombre_empleado_nuevacompra.Name = "lbl_nombre_empleado_nuevacompra";
            lbl_nombre_empleado_nuevacompra.Size = new Size(41, 19);
            lbl_nombre_empleado_nuevacompra.TabIndex = 7;
            lbl_nombre_empleado_nuevacompra.Text = "0001";
            // 
            // FormComprasNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(889, 426);
            Controls.Add(groupBox2);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(tb_busqueda_nuevacompra);
            Controls.Add(btn_regresar_nuevacompra);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(dgv_compras_nuevacompra);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(905, 446);
            Name = "FormComprasNuevaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Compra - POS Refaccionaria";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_compras_nuevacompra).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Label lbl_total_venta_nuevacompra;
        private Label label17;
        private Label lbl_iva_venta_nuevacompra;
        private Label label11;
        private Label lbl_subtotal_venta_nuevacompra;
        private Label label16;
        private DataGridView dgv_compras_nuevacompra;
        private DataGridViewTextBoxColumn CLAVE;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox1;
        private Button btn_f6_productos_nuevacompra;
        private Button btn_f5_pagos_nuevacompra;
        private Button btn_f4_compras_nuevacompra;
        private Button btn_f3_eliminar_nuevacompra;
        private Button btn_f2_modificar_nuevacompra;
        private Button btn_f1_agregar_nuevacompra;
        private Button btn_regresar_nuevacompra;
        private TextBox tb_busqueda_nuevacompra;
        private Panel panelHeader;
        private Label lblTitulo;
        private GroupBox groupBox2;
        private Label lbl_proveedor_nuevacompra;
        private Label lbl_folio_nuevacompra;
        private Label lbl_fecha_compra_nuevacompra;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_nombre_empleado_nuevacompra;
    }
}