namespace pos_proyecto
{
    partial class FormInterfazVentas
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
            dgv_venta_articulos_ventas = new DataGridView();
            CLAVE = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btn_f10_opciones_ventas = new Button();
            btn_f11_salir_ventas = new Button();
            btn_f9_precios_ventas = new Button();
            btn_f8_buscar_ventas = new Button();
            btn_f7_imprimir_ventas = new Button();
            btn_f6_cancelar_ventas = new Button();
            btn_f5_cliente_ventas = new Button();
            btn_f4_pago_ventas = new Button();
            btn_f3_descuento_ventas = new Button();
            btn_f1_agregar_ventas = new Button();
            groupBox2 = new GroupBox();
            cb_metodopago_ventas = new ComboBox();
            rb_credito_ventas = new RadioButton();
            rb_contado_ventas = new RadioButton();
            lbl_folio_ventas = new Label();
            lbl_fecha_ventas = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lbl_cliente_ventas = new Label();
            lbl_empleado_ventas = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            lbl_stock_ventas = new Label();
            label20 = new Label();
            lbl_total_ventas = new Label();
            label17 = new Label();
            lbl_cambio_ventas = new Label();
            lbl_iva_ventas = new Label();
            label10 = new Label();
            label11 = new Label();
            lbl_efectivo_ventas = new Label();
            lbl_subtotal_ventas = new Label();
            label15 = new Label();
            label16 = new Label();
            tb_busqueda_ventas = new TextBox();
            panelHeader = new Panel();
            lblTitulo = new Label();
            btn_f2_eliminar_ventas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_venta_articulos_ventas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_venta_articulos_ventas
            // 
            dgv_venta_articulos_ventas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_venta_articulos_ventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_venta_articulos_ventas.BackgroundColor = Color.White;
            dgv_venta_articulos_ventas.BorderStyle = BorderStyle.Fixed3D;
            dgv_venta_articulos_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_venta_articulos_ventas.Columns.AddRange(new DataGridViewColumn[] { CLAVE, Column1, Column2, Column3, Column4, Column5 });
            dgv_venta_articulos_ventas.GridColor = SystemColors.Control;
            dgv_venta_articulos_ventas.Location = new Point(21, 143);
            dgv_venta_articulos_ventas.Margin = new Padding(3, 2, 3, 2);
            dgv_venta_articulos_ventas.Name = "dgv_venta_articulos_ventas";
            dgv_venta_articulos_ventas.RowHeadersWidth = 62;
            dgv_venta_articulos_ventas.Size = new Size(1016, 150);
            dgv_venta_articulos_ventas.TabIndex = 0;
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
            groupBox1.Controls.Add(btn_f2_eliminar_ventas);
            groupBox1.Controls.Add(btn_f10_opciones_ventas);
            groupBox1.Controls.Add(btn_f11_salir_ventas);
            groupBox1.Controls.Add(btn_f9_precios_ventas);
            groupBox1.Controls.Add(btn_f8_buscar_ventas);
            groupBox1.Controls.Add(btn_f7_imprimir_ventas);
            groupBox1.Controls.Add(btn_f6_cancelar_ventas);
            groupBox1.Controls.Add(btn_f5_cliente_ventas);
            groupBox1.Controls.Add(btn_f4_pago_ventas);
            groupBox1.Controls.Add(btn_f3_descuento_ventas);
            groupBox1.Controls.Add(btn_f1_agregar_ventas);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 395);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1016, 91);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones de Venta";
            // 
            // btn_f10_opciones_ventas
            // 
            btn_f10_opciones_ventas.BackColor = Color.FromArgb(108, 117, 125);
            btn_f10_opciones_ventas.FlatAppearance.BorderSize = 0;
            btn_f10_opciones_ventas.FlatStyle = FlatStyle.Flat;
            btn_f10_opciones_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f10_opciones_ventas.ForeColor = Color.White;
            btn_f10_opciones_ventas.Location = new Point(807, 30);
            btn_f10_opciones_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f10_opciones_ventas.Name = "btn_f10_opciones_ventas";
            btn_f10_opciones_ventas.Size = new Size(81, 50);
            btn_f10_opciones_ventas.TabIndex = 7;
            btn_f10_opciones_ventas.Text = "F10 - Opciones";
            btn_f10_opciones_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f11_salir_ventas
            // 
            btn_f11_salir_ventas.BackColor = Color.FromArgb(220, 53, 69);
            btn_f11_salir_ventas.FlatAppearance.BorderSize = 0;
            btn_f11_salir_ventas.FlatStyle = FlatStyle.Flat;
            btn_f11_salir_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f11_salir_ventas.ForeColor = Color.White;
            btn_f11_salir_ventas.Location = new Point(894, 30);
            btn_f11_salir_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f11_salir_ventas.Name = "btn_f11_salir_ventas";
            btn_f11_salir_ventas.Size = new Size(81, 50);
            btn_f11_salir_ventas.TabIndex = 11;
            btn_f11_salir_ventas.Text = "F11 - Salir";
            btn_f11_salir_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f9_precios_ventas
            // 
            btn_f9_precios_ventas.BackColor = Color.FromArgb(111, 66, 193);
            btn_f9_precios_ventas.FlatAppearance.BorderSize = 0;
            btn_f9_precios_ventas.FlatStyle = FlatStyle.Flat;
            btn_f9_precios_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f9_precios_ventas.ForeColor = Color.White;
            btn_f9_precios_ventas.Location = new Point(720, 30);
            btn_f9_precios_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f9_precios_ventas.Name = "btn_f9_precios_ventas";
            btn_f9_precios_ventas.Size = new Size(81, 50);
            btn_f9_precios_ventas.TabIndex = 10;
            btn_f9_precios_ventas.Text = "F9 - Precios";
            btn_f9_precios_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f8_buscar_ventas
            // 
            btn_f8_buscar_ventas.BackColor = Color.FromArgb(23, 162, 184);
            btn_f8_buscar_ventas.FlatAppearance.BorderSize = 0;
            btn_f8_buscar_ventas.FlatStyle = FlatStyle.Flat;
            btn_f8_buscar_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f8_buscar_ventas.ForeColor = Color.White;
            btn_f8_buscar_ventas.Location = new Point(635, 30);
            btn_f8_buscar_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f8_buscar_ventas.Name = "btn_f8_buscar_ventas";
            btn_f8_buscar_ventas.Size = new Size(81, 50);
            btn_f8_buscar_ventas.TabIndex = 9;
            btn_f8_buscar_ventas.Text = "F8 - Buscar";
            btn_f8_buscar_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f7_imprimir_ventas
            // 
            btn_f7_imprimir_ventas.BackColor = Color.FromArgb(40, 167, 69);
            btn_f7_imprimir_ventas.FlatAppearance.BorderSize = 0;
            btn_f7_imprimir_ventas.FlatStyle = FlatStyle.Flat;
            btn_f7_imprimir_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f7_imprimir_ventas.ForeColor = Color.White;
            btn_f7_imprimir_ventas.Location = new Point(550, 30);
            btn_f7_imprimir_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f7_imprimir_ventas.Name = "btn_f7_imprimir_ventas";
            btn_f7_imprimir_ventas.Size = new Size(81, 50);
            btn_f7_imprimir_ventas.TabIndex = 8;
            btn_f7_imprimir_ventas.Text = "F7 - Imprimir";
            btn_f7_imprimir_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f6_cancelar_ventas
            // 
            btn_f6_cancelar_ventas.BackColor = Color.FromArgb(255, 193, 7);
            btn_f6_cancelar_ventas.FlatAppearance.BorderSize = 0;
            btn_f6_cancelar_ventas.FlatStyle = FlatStyle.Flat;
            btn_f6_cancelar_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f6_cancelar_ventas.ForeColor = Color.White;
            btn_f6_cancelar_ventas.Location = new Point(465, 30);
            btn_f6_cancelar_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f6_cancelar_ventas.Name = "btn_f6_cancelar_ventas";
            btn_f6_cancelar_ventas.Size = new Size(81, 50);
            btn_f6_cancelar_ventas.TabIndex = 7;
            btn_f6_cancelar_ventas.Text = "F6 - Cancelar";
            btn_f6_cancelar_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f5_cliente_ventas
            // 
            btn_f5_cliente_ventas.BackColor = Color.FromArgb(253, 126, 20);
            btn_f5_cliente_ventas.FlatAppearance.BorderSize = 0;
            btn_f5_cliente_ventas.FlatStyle = FlatStyle.Flat;
            btn_f5_cliente_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f5_cliente_ventas.ForeColor = Color.White;
            btn_f5_cliente_ventas.Location = new Point(380, 30);
            btn_f5_cliente_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f5_cliente_ventas.Name = "btn_f5_cliente_ventas";
            btn_f5_cliente_ventas.Size = new Size(81, 50);
            btn_f5_cliente_ventas.TabIndex = 6;
            btn_f5_cliente_ventas.Text = "F5 - Cliente";
            btn_f5_cliente_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f4_pago_ventas
            // 
            btn_f4_pago_ventas.BackColor = Color.FromArgb(32, 201, 151);
            btn_f4_pago_ventas.FlatAppearance.BorderSize = 0;
            btn_f4_pago_ventas.FlatStyle = FlatStyle.Flat;
            btn_f4_pago_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f4_pago_ventas.ForeColor = Color.White;
            btn_f4_pago_ventas.Location = new Point(295, 30);
            btn_f4_pago_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f4_pago_ventas.Name = "btn_f4_pago_ventas";
            btn_f4_pago_ventas.Size = new Size(81, 50);
            btn_f4_pago_ventas.TabIndex = 5;
            btn_f4_pago_ventas.Text = "F4 - Pago";
            btn_f4_pago_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f3_descuento_ventas
            // 
            btn_f3_descuento_ventas.BackColor = Color.FromArgb(13, 110, 253);
            btn_f3_descuento_ventas.FlatAppearance.BorderSize = 0;
            btn_f3_descuento_ventas.FlatStyle = FlatStyle.Flat;
            btn_f3_descuento_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f3_descuento_ventas.ForeColor = Color.White;
            btn_f3_descuento_ventas.Location = new Point(210, 30);
            btn_f3_descuento_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f3_descuento_ventas.Name = "btn_f3_descuento_ventas";
            btn_f3_descuento_ventas.Size = new Size(81, 50);
            btn_f3_descuento_ventas.TabIndex = 4;
            btn_f3_descuento_ventas.Text = "F3 - Descuento";
            btn_f3_descuento_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_f1_agregar_ventas
            // 
            btn_f1_agregar_ventas.BackColor = Color.FromArgb(0, 122, 204);
            btn_f1_agregar_ventas.FlatAppearance.BorderSize = 0;
            btn_f1_agregar_ventas.FlatStyle = FlatStyle.Flat;
            btn_f1_agregar_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f1_agregar_ventas.ForeColor = Color.White;
            btn_f1_agregar_ventas.Location = new Point(40, 30);
            btn_f1_agregar_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f1_agregar_ventas.Name = "btn_f1_agregar_ventas";
            btn_f1_agregar_ventas.Size = new Size(81, 50);
            btn_f1_agregar_ventas.TabIndex = 2;
            btn_f1_agregar_ventas.Text = "F1 - Agregar";
            btn_f1_agregar_ventas.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(cb_metodopago_ventas);
            groupBox2.Controls.Add(rb_credito_ventas);
            groupBox2.Controls.Add(rb_contado_ventas);
            groupBox2.Controls.Add(lbl_folio_ventas);
            groupBox2.Controls.Add(lbl_fecha_ventas);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lbl_cliente_ventas);
            groupBox2.Controls.Add(lbl_empleado_ventas);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 48);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1025, 91);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Venta";
            // 
            // cb_metodopago_ventas
            // 
            cb_metodopago_ventas.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_metodopago_ventas.FlatStyle = FlatStyle.Flat;
            cb_metodopago_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_metodopago_ventas.FormattingEnabled = true;
            cb_metodopago_ventas.Items.AddRange(new object[] { "Efectivo", "Tarjeta Crédito", "Tarjeta Débito", "Transferencia", "Cheque" });
            cb_metodopago_ventas.Location = new Point(489, 54);
            cb_metodopago_ventas.Margin = new Padding(3, 2, 3, 2);
            cb_metodopago_ventas.Name = "cb_metodopago_ventas";
            cb_metodopago_ventas.Size = new Size(141, 23);
            cb_metodopago_ventas.TabIndex = 14;
            // 
            // rb_credito_ventas
            // 
            rb_credito_ventas.AutoSize = true;
            rb_credito_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_credito_ventas.Location = new Point(244, 56);
            rb_credito_ventas.Margin = new Padding(3, 2, 3, 2);
            rb_credito_ventas.Name = "rb_credito_ventas";
            rb_credito_ventas.Size = new Size(64, 19);
            rb_credito_ventas.TabIndex = 13;
            rb_credito_ventas.TabStop = true;
            rb_credito_ventas.Text = "Crédito";
            rb_credito_ventas.UseVisualStyleBackColor = true;
            // 
            // rb_contado_ventas
            // 
            rb_contado_ventas.AutoSize = true;
            rb_contado_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_contado_ventas.Location = new Point(125, 56);
            rb_contado_ventas.Margin = new Padding(3, 2, 3, 2);
            rb_contado_ventas.Name = "rb_contado_ventas";
            rb_contado_ventas.Size = new Size(71, 19);
            rb_contado_ventas.TabIndex = 12;
            rb_contado_ventas.TabStop = true;
            rb_contado_ventas.Text = "Contado";
            rb_contado_ventas.UseVisualStyleBackColor = true;
            // 
            // lbl_folio_ventas
            // 
            lbl_folio_ventas.AutoSize = true;
            lbl_folio_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_folio_ventas.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_folio_ventas.Location = new Point(489, 36);
            lbl_folio_ventas.Name = "lbl_folio_ventas";
            lbl_folio_ventas.Size = new Size(41, 19);
            lbl_folio_ventas.TabIndex = 10;
            lbl_folio_ventas.Text = "0001";
            // 
            // lbl_fecha_ventas
            // 
            lbl_fecha_ventas.AutoSize = true;
            lbl_fecha_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fecha_ventas.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_fecha_ventas.Location = new Point(489, 18);
            lbl_fecha_ventas.Name = "lbl_fecha_ventas";
            lbl_fecha_ventas.Size = new Size(85, 19);
            lbl_fecha_ventas.TabIndex = 9;
            lbl_fecha_ventas.Text = "01/01/2024";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(398, 57);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 8;
            label9.Text = "Método Pago:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(447, 36);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Folio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(440, 18);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha:";
            // 
            // lbl_cliente_ventas
            // 
            lbl_cliente_ventas.AutoSize = true;
            lbl_cliente_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cliente_ventas.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_cliente_ventas.Location = new Point(125, 36);
            lbl_cliente_ventas.Name = "lbl_cliente_ventas";
            lbl_cliente_ventas.Size = new Size(111, 19);
            lbl_cliente_ventas.TabIndex = 4;
            lbl_cliente_ventas.Text = "Cliente General";
            // 
            // lbl_empleado_ventas
            // 
            lbl_empleado_ventas.AutoSize = true;
            lbl_empleado_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_empleado_ventas.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_empleado_ventas.Location = new Point(125, 18);
            lbl_empleado_ventas.Name = "lbl_empleado_ventas";
            lbl_empleado_ventas.Size = new Size(106, 19);
            lbl_empleado_ventas.TabIndex = 3;
            lbl_empleado_ventas.Text = "Administrador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 57);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo Venta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 36);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 18);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lbl_stock_ventas);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(lbl_total_ventas);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(lbl_cambio_ventas);
            groupBox3.Controls.Add(lbl_iva_ventas);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lbl_efectivo_ventas);
            groupBox3.Controls.Add(lbl_subtotal_ventas);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(753, 297);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(266, 90);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales";
            // 
            // lbl_stock_ventas
            // 
            lbl_stock_ventas.AutoSize = true;
            lbl_stock_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_stock_ventas.ForeColor = Color.FromArgb(40, 167, 69);
            lbl_stock_ventas.Location = new Point(196, 66);
            lbl_stock_ventas.Name = "lbl_stock_ventas";
            lbl_stock_ventas.Size = new Size(33, 19);
            lbl_stock_ventas.TabIndex = 31;
            lbl_stock_ventas.Text = "100";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(154, 69);
            label20.Name = "label20";
            label20.Size = new Size(39, 15);
            label20.TabIndex = 30;
            label20.Text = "Stock:";
            // 
            // lbl_total_ventas
            // 
            lbl_total_ventas.AutoSize = true;
            lbl_total_ventas.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_ventas.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_total_ventas.Location = new Point(196, 45);
            lbl_total_ventas.Name = "lbl_total_ventas";
            lbl_total_ventas.Size = new Size(61, 25);
            lbl_total_ventas.TabIndex = 29;
            lbl_total_ventas.Text = "$0.00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(147, 48);
            label17.Name = "label17";
            label17.Size = new Size(46, 19);
            label17.TabIndex = 28;
            label17.Text = "Total:";
            // 
            // lbl_cambio_ventas
            // 
            lbl_cambio_ventas.AutoSize = true;
            lbl_cambio_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cambio_ventas.ForeColor = Color.FromArgb(40, 167, 69);
            lbl_cambio_ventas.Location = new Point(84, 66);
            lbl_cambio_ventas.Name = "lbl_cambio_ventas";
            lbl_cambio_ventas.Size = new Size(45, 19);
            lbl_cambio_ventas.TabIndex = 24;
            lbl_cambio_ventas.Text = "$0.00";
            // 
            // lbl_iva_ventas
            // 
            lbl_iva_ventas.AutoSize = true;
            lbl_iva_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_iva_ventas.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_iva_ventas.Location = new Point(84, 27);
            lbl_iva_ventas.Name = "lbl_iva_ventas";
            lbl_iva_ventas.Size = new Size(45, 19);
            lbl_iva_ventas.TabIndex = 23;
            lbl_iva_ventas.Text = "$0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 69);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 21;
            label10.Text = "Cambio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(52, 30);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 20;
            label11.Text = "IVA:";
            // 
            // lbl_efectivo_ventas
            // 
            lbl_efectivo_ventas.AutoSize = true;
            lbl_efectivo_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_efectivo_ventas.ForeColor = Color.FromArgb(40, 167, 69);
            lbl_efectivo_ventas.Location = new Point(84, 48);
            lbl_efectivo_ventas.Name = "lbl_efectivo_ventas";
            lbl_efectivo_ventas.Size = new Size(45, 19);
            lbl_efectivo_ventas.TabIndex = 19;
            lbl_efectivo_ventas.Text = "$0.00";
            // 
            // lbl_subtotal_ventas
            // 
            lbl_subtotal_ventas.AutoSize = true;
            lbl_subtotal_ventas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_subtotal_ventas.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_subtotal_ventas.Location = new Point(84, 9);
            lbl_subtotal_ventas.Name = "lbl_subtotal_ventas";
            lbl_subtotal_ventas.Size = new Size(45, 19);
            lbl_subtotal_ventas.TabIndex = 18;
            lbl_subtotal_ventas.Text = "$0.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(24, 51);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 16;
            label15.Text = "Efectivo:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(21, 12);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 15;
            label16.Text = "Subtotal:";
            // 
            // tb_busqueda_ventas
            // 
            tb_busqueda_ventas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_busqueda_ventas.BorderStyle = BorderStyle.FixedSingle;
            tb_busqueda_ventas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_busqueda_ventas.Location = new Point(21, 297);
            tb_busqueda_ventas.Margin = new Padding(3, 2, 3, 2);
            tb_busqueda_ventas.Name = "tb_busqueda_ventas";
            tb_busqueda_ventas.PlaceholderText = "Buscar producto por código, nombre o descripción...";
            tb_busqueda_ventas.Size = new Size(661, 29);
            tb_busqueda_ventas.TabIndex = 4;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1049, 42);
            panelHeader.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(455, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(173, 30);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Punto de Venta";
            // 
            // btn_f2_eliminar_ventas
            // 
            btn_f2_eliminar_ventas.BackColor = Color.FromArgb(102, 16, 242);
            btn_f2_eliminar_ventas.FlatAppearance.BorderSize = 0;
            btn_f2_eliminar_ventas.FlatStyle = FlatStyle.Flat;
            btn_f2_eliminar_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f2_eliminar_ventas.ForeColor = Color.White;
            btn_f2_eliminar_ventas.Location = new Point(125, 30);
            btn_f2_eliminar_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_f2_eliminar_ventas.Name = "btn_f2_eliminar_ventas";
            btn_f2_eliminar_ventas.Size = new Size(81, 50);
            btn_f2_eliminar_ventas.TabIndex = 12;
            btn_f2_eliminar_ventas.Text = "F2 - Eliminar";
            btn_f2_eliminar_ventas.UseVisualStyleBackColor = false;
            // 
            // FormInterfazVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1049, 497);
            Controls.Add(groupBox2);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(tb_busqueda_ventas);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgv_venta_articulos_ventas);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(955, 446);
            Name = "FormInterfazVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punto de Venta - POS Refaccionaria";
            ((System.ComponentModel.ISupportInitialize)dgv_venta_articulos_ventas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_venta_articulos_ventas;
        private DataGridViewTextBoxColumn CLAVE;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox1;
        private Button btn_f1_agregar_ventas;
        private GroupBox groupBox2;
        private Label label7;
        private Label lbl_cliente_ventas;
        private Label lbl_empleado_ventas;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_folio_ventas;
        private Label lbl_fecha_ventas;
        private Label label9;
        private Label label8;
        private ComboBox cb_metodopago_ventas;
        private RadioButton rb_credito_ventas;
        private RadioButton rb_contado_ventas;
        private GroupBox groupBox3;
        private Label lbl_cambio_ventas;
        private Label lbl_iva_ventas;
        private Label label10;
        private Label label11;
        private Label lbl_efectivo_ventas;
        private Label lbl_subtotal_ventas;
        private Label label15;
        private Label label16;
        private Label lbl_stock_ventas;
        private Label label20;
        private Label lbl_total_ventas;
        private Label label17;
        private Button btn_f11_salir_ventas;
        private Button btn_f9_precios_ventas;
        private Button btn_f8_buscar_ventas;
        private Button btn_f7_imprimir_ventas;
        private Button btn_f6_cancelar_ventas;
        private Button btn_f5_cliente_ventas;
        private Button btn_f4_pago_ventas;
        private Button btn_f3_descuento_ventas;
        private Button btn_f10_opciones_ventas;
        private TextBox tb_busqueda_ventas;
        private Panel panelHeader;
        private Label lblTitulo;
        private Button btn_f2_eliminar_ventas;
    }
}