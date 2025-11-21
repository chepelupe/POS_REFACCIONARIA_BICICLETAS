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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInterfazVentas));
            dataGridView1 = new DataGridView();
            CLAVE = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btn_f11_opciones = new Button();
            btn_f10_salir_venta = new Button();
            btn_f9_precios_venta = new Button();
            btn_f8_buscar_venta = new Button();
            btn_f7_imprimir_venta = new Button();
            btn_f6_cancelar_venta = new Button();
            btn_f5_cliente_venta = new Button();
            btn_f4_pago_venta = new Button();
            btn_f3_descuento_venta = new Button();
            btn_f2_eliminar_venta = new Button();
            btn_f1_agregar_venta = new Button();
            groupBox2 = new GroupBox();
            cb_metodopago_venta = new ComboBox();
            rb_credito_venta = new RadioButton();
            rb_contado_venta = new RadioButton();
            lbl_folio_venta = new Label();
            lbl_fecha_venta = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lbl_cliente_venta = new Label();
            lbl_empleado_venta = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            lbl_stock_venta = new Label();
            label20 = new Label();
            lbl_total_venta = new Label();
            label17 = new Label();
            lbl_cambio_venta = new Label();
            lbl_iva_venta = new Label();
            label10 = new Label();
            label11 = new Label();
            lbl_efectivo_venta = new Label();
            lbl_subtotal_venta = new Label();
            label15 = new Label();
            label16 = new Label();
            tb_busqueda_ventas = new TextBox();
            panelHeader = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CLAVE, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(30, 220);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1400, 250);
            dataGridView1.TabIndex = 0;
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
            groupBox1.Controls.Add(btn_f11_opciones);
            groupBox1.Controls.Add(btn_f10_salir_venta);
            groupBox1.Controls.Add(btn_f9_precios_venta);
            groupBox1.Controls.Add(btn_f8_buscar_venta);
            groupBox1.Controls.Add(btn_f7_imprimir_venta);
            groupBox1.Controls.Add(btn_f6_cancelar_venta);
            groupBox1.Controls.Add(btn_f5_cliente_venta);
            groupBox1.Controls.Add(btn_f4_pago_venta);
            groupBox1.Controls.Add(btn_f3_descuento_venta);
            groupBox1.Controls.Add(btn_f2_eliminar_venta);
            groupBox1.Controls.Add(btn_f1_agregar_venta);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 550);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1400, 120);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones de Venta";
            // 
            // btn_f11_opciones
            // 
            btn_f11_opciones.BackColor = Color.FromArgb(108, 117, 125);
            btn_f11_opciones.FlatAppearance.BorderSize = 0;
            btn_f11_opciones.FlatStyle = FlatStyle.Flat;
            btn_f11_opciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f11_opciones.ForeColor = Color.White;
            btn_f11_opciones.Location = new Point(1250, 35);
            btn_f11_opciones.Margin = new Padding(4);
            btn_f11_opciones.Name = "btn_f11_opciones";
            btn_f11_opciones.Size = new Size(120, 60);
            btn_f11_opciones.TabIndex = 7;
            btn_f11_opciones.Text = "F11 - Opciones";
            btn_f11_opciones.UseVisualStyleBackColor = false;
            // 
            // btn_f10_salir_venta
            // 
            btn_f10_salir_venta.BackColor = Color.FromArgb(220, 53, 69);
            btn_f10_salir_venta.FlatAppearance.BorderSize = 0;
            btn_f10_salir_venta.FlatStyle = FlatStyle.Flat;
            btn_f10_salir_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f10_salir_venta.ForeColor = Color.White;
            btn_f10_salir_venta.Location = new Point(1120, 35);
            btn_f10_salir_venta.Margin = new Padding(4);
            btn_f10_salir_venta.Name = "btn_f10_salir_venta";
            btn_f10_salir_venta.Size = new Size(120, 60);
            btn_f10_salir_venta.TabIndex = 11;
            btn_f10_salir_venta.Text = "F10 - Salir";
            btn_f10_salir_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f9_precios_venta
            // 
            btn_f9_precios_venta.BackColor = Color.FromArgb(111, 66, 193);
            btn_f9_precios_venta.FlatAppearance.BorderSize = 0;
            btn_f9_precios_venta.FlatStyle = FlatStyle.Flat;
            btn_f9_precios_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f9_precios_venta.ForeColor = Color.White;
            btn_f9_precios_venta.Location = new Point(860, 35);
            btn_f9_precios_venta.Margin = new Padding(4);
            btn_f9_precios_venta.Name = "btn_f9_precios_venta";
            btn_f9_precios_venta.Size = new Size(120, 60);
            btn_f9_precios_venta.TabIndex = 10;
            btn_f9_precios_venta.Text = "F9 - Precios";
            btn_f9_precios_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f8_buscar_venta
            // 
            btn_f8_buscar_venta.BackColor = Color.FromArgb(23, 162, 184);
            btn_f8_buscar_venta.FlatAppearance.BorderSize = 0;
            btn_f8_buscar_venta.FlatStyle = FlatStyle.Flat;
            btn_f8_buscar_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f8_buscar_venta.ForeColor = Color.White;
            btn_f8_buscar_venta.Location = new Point(730, 35);
            btn_f8_buscar_venta.Margin = new Padding(4);
            btn_f8_buscar_venta.Name = "btn_f8_buscar_venta";
            btn_f8_buscar_venta.Size = new Size(120, 60);
            btn_f8_buscar_venta.TabIndex = 9;
            btn_f8_buscar_venta.Text = "F8 - Buscar";
            btn_f8_buscar_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f7_imprimir_venta
            // 
            btn_f7_imprimir_venta.BackColor = Color.FromArgb(40, 167, 69);
            btn_f7_imprimir_venta.FlatAppearance.BorderSize = 0;
            btn_f7_imprimir_venta.FlatStyle = FlatStyle.Flat;
            btn_f7_imprimir_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f7_imprimir_venta.ForeColor = Color.White;
            btn_f7_imprimir_venta.Location = new Point(600, 35);
            btn_f7_imprimir_venta.Margin = new Padding(4);
            btn_f7_imprimir_venta.Name = "btn_f7_imprimir_venta";
            btn_f7_imprimir_venta.Size = new Size(120, 60);
            btn_f7_imprimir_venta.TabIndex = 8;
            btn_f7_imprimir_venta.Text = "F7 - Imprimir";
            btn_f7_imprimir_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f6_cancelar_venta
            // 
            btn_f6_cancelar_venta.BackColor = Color.FromArgb(255, 193, 7);
            btn_f6_cancelar_venta.FlatAppearance.BorderSize = 0;
            btn_f6_cancelar_venta.FlatStyle = FlatStyle.Flat;
            btn_f6_cancelar_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f6_cancelar_venta.ForeColor = Color.White;
            btn_f6_cancelar_venta.Location = new Point(470, 35);
            btn_f6_cancelar_venta.Margin = new Padding(4);
            btn_f6_cancelar_venta.Name = "btn_f6_cancelar_venta";
            btn_f6_cancelar_venta.Size = new Size(120, 60);
            btn_f6_cancelar_venta.TabIndex = 7;
            btn_f6_cancelar_venta.Text = "F6 - Cancelar";
            btn_f6_cancelar_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f5_cliente_venta
            // 
            btn_f5_cliente_venta.BackColor = Color.FromArgb(253, 126, 20);
            btn_f5_cliente_venta.FlatAppearance.BorderSize = 0;
            btn_f5_cliente_venta.FlatStyle = FlatStyle.Flat;
            btn_f5_cliente_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f5_cliente_venta.ForeColor = Color.White;
            btn_f5_cliente_venta.Location = new Point(340, 35);
            btn_f5_cliente_venta.Margin = new Padding(4);
            btn_f5_cliente_venta.Name = "btn_f5_cliente_venta";
            btn_f5_cliente_venta.Size = new Size(120, 60);
            btn_f5_cliente_venta.TabIndex = 6;
            btn_f5_cliente_venta.Text = "F5 - Cliente";
            btn_f5_cliente_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f4_pago_venta
            // 
            btn_f4_pago_venta.BackColor = Color.FromArgb(32, 201, 151);
            btn_f4_pago_venta.FlatAppearance.BorderSize = 0;
            btn_f4_pago_venta.FlatStyle = FlatStyle.Flat;
            btn_f4_pago_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f4_pago_venta.ForeColor = Color.White;
            btn_f4_pago_venta.Location = new Point(210, 35);
            btn_f4_pago_venta.Margin = new Padding(4);
            btn_f4_pago_venta.Name = "btn_f4_pago_venta";
            btn_f4_pago_venta.Size = new Size(120, 60);
            btn_f4_pago_venta.TabIndex = 5;
            btn_f4_pago_venta.Text = "F4 - Pago";
            btn_f4_pago_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f3_descuento_venta
            // 
            btn_f3_descuento_venta.BackColor = Color.FromArgb(13, 110, 253);
            btn_f3_descuento_venta.FlatAppearance.BorderSize = 0;
            btn_f3_descuento_venta.FlatStyle = FlatStyle.Flat;
            btn_f3_descuento_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f3_descuento_venta.ForeColor = Color.White;
            btn_f3_descuento_venta.Location = new Point(80, 35);
            btn_f3_descuento_venta.Margin = new Padding(4);
            btn_f3_descuento_venta.Name = "btn_f3_descuento_venta";
            btn_f3_descuento_venta.Size = new Size(120, 60);
            btn_f3_descuento_venta.TabIndex = 4;
            btn_f3_descuento_venta.Text = "F3 - Descuento";
            btn_f3_descuento_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f2_eliminar_venta
            // 
            btn_f2_eliminar_venta.BackColor = Color.FromArgb(102, 16, 242);
            btn_f2_eliminar_venta.FlatAppearance.BorderSize = 0;
            btn_f2_eliminar_venta.FlatStyle = FlatStyle.Flat;
            btn_f2_eliminar_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f2_eliminar_venta.ForeColor = Color.White;
            btn_f2_eliminar_venta.Location = new Point(990, 35);
            btn_f2_eliminar_venta.Margin = new Padding(4);
            btn_f2_eliminar_venta.Name = "btn_f2_eliminar_venta";
            btn_f2_eliminar_venta.Size = new Size(120, 60);
            btn_f2_eliminar_venta.TabIndex = 3;
            btn_f2_eliminar_venta.Text = "F2 - Eliminar";
            btn_f2_eliminar_venta.UseVisualStyleBackColor = false;
            // 
            // btn_f1_agregar_venta
            // 
            btn_f1_agregar_venta.BackColor = Color.FromArgb(0, 122, 204);
            btn_f1_agregar_venta.FlatAppearance.BorderSize = 0;
            btn_f1_agregar_venta.FlatStyle = FlatStyle.Flat;
            btn_f1_agregar_venta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f1_agregar_venta.ForeColor = Color.White;
            btn_f1_agregar_venta.Location = new Point(30, 35);
            btn_f1_agregar_venta.Margin = new Padding(4);
            btn_f1_agregar_venta.Name = "btn_f1_agregar_venta";
            btn_f1_agregar_venta.Size = new Size(120, 60);
            btn_f1_agregar_venta.TabIndex = 2;
            btn_f1_agregar_venta.Text = "F1 - Agregar";
            btn_f1_agregar_venta.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(cb_metodopago_venta);
            groupBox2.Controls.Add(rb_credito_venta);
            groupBox2.Controls.Add(rb_contado_venta);
            groupBox2.Controls.Add(lbl_folio_venta);
            groupBox2.Controls.Add(lbl_fecha_venta);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lbl_cliente_venta);
            groupBox2.Controls.Add(lbl_empleado_venta);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(30, 80);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1400, 120);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Venta";
            // 
            // cb_metodopago_venta
            // 
            cb_metodopago_venta.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_metodopago_venta.FlatStyle = FlatStyle.Flat;
            cb_metodopago_venta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_metodopago_venta.FormattingEnabled = true;
            cb_metodopago_venta.Items.AddRange(new object[] { "Efectivo", "Tarjeta Crédito", "Tarjeta Débito", "Transferencia", "Cheque" });
            cb_metodopago_venta.Location = new Point(700, 75);
            cb_metodopago_venta.Margin = new Padding(4);
            cb_metodopago_venta.Name = "cb_metodopago_venta";
            cb_metodopago_venta.Size = new Size(200, 33);
            cb_metodopago_venta.TabIndex = 14;
            // 
            // rb_credito_venta
            // 
            rb_credito_venta.AutoSize = true;
            rb_credito_venta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_credito_venta.Location = new Point(350, 78);
            rb_credito_venta.Margin = new Padding(4);
            rb_credito_venta.Name = "rb_credito_venta";
            rb_credito_venta.Size = new Size(88, 29);
            rb_credito_venta.TabIndex = 13;
            rb_credito_venta.TabStop = true;
            rb_credito_venta.Text = "Crédito";
            rb_credito_venta.UseVisualStyleBackColor = true;
            // 
            // rb_contado_venta
            // 
            rb_contado_venta.AutoSize = true;
            rb_contado_venta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_contado_venta.Location = new Point(180, 78);
            rb_contado_venta.Margin = new Padding(4);
            rb_contado_venta.Name = "rb_contado_venta";
            rb_contado_venta.Size = new Size(98, 29);
            rb_contado_venta.TabIndex = 12;
            rb_contado_venta.TabStop = true;
            rb_contado_venta.Text = "Contado";
            rb_contado_venta.UseVisualStyleBackColor = true;
            // 
            // lbl_folio_venta
            // 
            lbl_folio_venta.AutoSize = true;
            lbl_folio_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_folio_venta.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_folio_venta.Location = new Point(700, 45);
            lbl_folio_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_folio_venta.Name = "lbl_folio_venta";
            lbl_folio_venta.Size = new Size(52, 28);
            lbl_folio_venta.TabIndex = 10;
            lbl_folio_venta.Text = "0001";
            // 
            // lbl_fecha_venta
            // 
            lbl_fecha_venta.AutoSize = true;
            lbl_fecha_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fecha_venta.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_fecha_venta.Location = new Point(700, 15);
            lbl_fecha_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_fecha_venta.Name = "lbl_fecha_venta";
            lbl_fecha_venta.Size = new Size(140, 28);
            lbl_fecha_venta.TabIndex = 9;
            lbl_fecha_venta.Text = "01/01/2024";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(570, 80);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(122, 25);
            label9.TabIndex = 8;
            label9.Text = "Método Pago:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(640, 45);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 7;
            label8.Text = "Folio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(630, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 6;
            label7.Text = "Fecha:";
            // 
            // lbl_cliente_venta
            // 
            lbl_cliente_venta.AutoSize = true;
            lbl_cliente_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cliente_venta.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_cliente_venta.Location = new Point(180, 45);
            lbl_cliente_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_cliente_venta.Name = "lbl_cliente_venta";
            lbl_cliente_venta.Size = new Size(178, 28);
            lbl_cliente_venta.TabIndex = 4;
            lbl_cliente_venta.Text = "Cliente General";
            // 
            // lbl_empleado_venta
            // 
            lbl_empleado_venta.AutoSize = true;
            lbl_empleado_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_empleado_venta.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_empleado_venta.Location = new Point(180, 15);
            lbl_empleado_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_empleado_venta.Name = "lbl_empleado_venta";
            lbl_empleado_venta.Size = new Size(154, 28);
            lbl_empleado_venta.TabIndex = 3;
            lbl_empleado_venta.Text = "Administrador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 2;
            label3.Text = "Tipo Venta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lbl_stock_venta);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(lbl_total_venta);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(lbl_cambio_venta);
            groupBox3.Controls.Add(lbl_iva_venta);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lbl_efectivo_venta);
            groupBox3.Controls.Add(lbl_subtotal_venta);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1050, 480);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(380, 150);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales";
            // 
            // lbl_stock_venta
            // 
            lbl_stock_venta.AutoSize = true;
            lbl_stock_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_stock_venta.ForeColor = Color.FromArgb(40, 167, 69);
            lbl_stock_venta.Location = new Point(280, 110);
            lbl_stock_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_stock_venta.Name = "lbl_stock_venta";
            lbl_stock_venta.Size = new Size(52, 28);
            lbl_stock_venta.TabIndex = 31;
            lbl_stock_venta.Text = "100";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(220, 115);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(55, 25);
            label20.TabIndex = 30;
            label20.Text = "Stock:";
            // 
            // lbl_total_venta
            // 
            lbl_total_venta.AutoSize = true;
            lbl_total_venta.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_venta.ForeColor = Color.FromArgb(0, 122, 204);
            lbl_total_venta.Location = new Point(280, 75);
            lbl_total_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_total_venta.Name = "lbl_total_venta";
            lbl_total_venta.Size = new Size(85, 38);
            lbl_total_venta.TabIndex = 29;
            lbl_total_venta.Text = "$0.00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(210, 80);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(62, 28);
            label17.TabIndex = 28;
            label17.Text = "Total:";
            // 
            // lbl_cambio_venta
            // 
            lbl_cambio_venta.AutoSize = true;
            lbl_cambio_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cambio_venta.ForeColor = Color.FromArgb(40, 167, 69);
            lbl_cambio_venta.Location = new Point(120, 110);
            lbl_cambio_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_cambio_venta.Name = "lbl_cambio_venta";
            lbl_cambio_venta.Size = new Size(85, 28);
            lbl_cambio_venta.TabIndex = 24;
            lbl_cambio_venta.Text = "$0.00";
            // 
            // lbl_iva_venta
            // 
            lbl_iva_venta.AutoSize = true;
            lbl_iva_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_iva_venta.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_iva_venta.Location = new Point(120, 45);
            lbl_iva_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_iva_venta.Name = "lbl_iva_venta";
            lbl_iva_venta.Size = new Size(85, 28);
            lbl_iva_venta.TabIndex = 23;
            lbl_iva_venta.Text = "$0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(40, 115);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(78, 25);
            label10.TabIndex = 21;
            label10.Text = "Cambio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(75, 50);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(40, 25);
            label11.TabIndex = 20;
            label11.Text = "IVA:";
            // 
            // lbl_efectivo_venta
            // 
            lbl_efectivo_venta.AutoSize = true;
            lbl_efectivo_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_efectivo_venta.ForeColor = Color.FromArgb(40, 167, 69);
            lbl_efectivo_venta.Location = new Point(120, 80);
            lbl_efectivo_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_efectivo_venta.Name = "lbl_efectivo_venta";
            lbl_efectivo_venta.Size = new Size(85, 28);
            lbl_efectivo_venta.TabIndex = 19;
            lbl_efectivo_venta.Text = "$0.00";
            // 
            // lbl_subtotal_venta
            // 
            lbl_subtotal_venta.AutoSize = true;
            lbl_subtotal_venta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_subtotal_venta.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_subtotal_venta.Location = new Point(120, 15);
            lbl_subtotal_venta.Margin = new Padding(4, 0, 4, 0);
            lbl_subtotal_venta.Name = "lbl_subtotal_venta";
            lbl_subtotal_venta.Size = new Size(85, 28);
            lbl_subtotal_venta.TabIndex = 18;
            lbl_subtotal_venta.Text = "$0.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(35, 85);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(77, 25);
            label15.TabIndex = 16;
            label15.Text = "Efectivo:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(30, 20);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(82, 25);
            label16.TabIndex = 15;
            label16.Text = "Subtotal:";
            // 
            // tb_busqueda_ventas
            // 
            tb_busqueda_ventas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_busqueda_ventas.BorderStyle = BorderStyle.FixedSingle;
            tb_busqueda_ventas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_busqueda_ventas.Location = new Point(30, 480);
            tb_busqueda_ventas.Margin = new Padding(4);
            tb_busqueda_ventas.Name = "tb_busqueda_ventas";
            tb_busqueda_ventas.PlaceholderText = "Buscar producto por código, nombre o descripción...";
            tb_busqueda_ventas.Size = new Size(1000, 39);
            tb_busqueda_ventas.TabIndex = 4;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1464, 70);
            panelHeader.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(650, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 45);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Punto de Venta";
            // 
            // FormInterfazVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1464, 700);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(tb_busqueda_ventas);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1486, 756);
            Name = "FormInterfazVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punto de Venta - POS Refaccionaria";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CLAVE;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox1;
        private Button btn_f1_agregar_venta;
        private GroupBox groupBox2;
        private Label label7;
        private Label lbl_cliente_venta;
        private Label lbl_empleado_venta;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_folio_venta;
        private Label lbl_fecha_venta;
        private Label label9;
        private Label label8;
        private ComboBox cb_metodopago_venta;
        private RadioButton rb_credito_venta;
        private RadioButton rb_contado_venta;
        private GroupBox groupBox3;
        private Label lbl_cambio_venta;
        private Label lbl_iva_venta;
        private Label label10;
        private Label label11;
        private Label lbl_efectivo_venta;
        private Label lbl_subtotal_venta;
        private Label label15;
        private Label label16;
        private Label lbl_stock_venta;
        private Label label20;
        private Label lbl_total_venta;
        private Label label17;
        private Button btn_f10_salir_venta;
        private Button btn_f9_precios_venta;
        private Button btn_f8_buscar_venta;
        private Button btn_f7_imprimir_venta;
        private Button btn_f6_cancelar_venta;
        private Button btn_f5_cliente_venta;
        private Button btn_f4_pago_venta;
        private Button btn_f3_descuento_venta;
        private Button btn_f2_eliminar_venta;
        private Button btn_f11_opciones;
        private TextBox tb_busqueda_ventas;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}