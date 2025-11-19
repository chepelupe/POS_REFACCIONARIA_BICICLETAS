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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CLAVE, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(11, 183);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(989, 175);
            dataGridView1.TabIndex = 0;
            // 
            // CLAVE
            // 
            CLAVE.HeaderText = "CLAVE";
            CLAVE.MinimumWidth = 8;
            CLAVE.Name = "CLAVE";
            CLAVE.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "CANT";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "UNIDAD";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "DESCRIPCIÓN";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 600;
            // 
            // Column4
            // 
            Column4.HeaderText = "PRECIO";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "IMPORTE";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(11, 442);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(989, 184);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // btn_f11_opciones
            // 
            btn_f11_opciones.Location = new Point(880, 66);
            btn_f11_opciones.Margin = new Padding(2, 2, 2, 2);
            btn_f11_opciones.Name = "btn_f11_opciones";
            btn_f11_opciones.Size = new Size(92, 59);
            btn_f11_opciones.TabIndex = 7;
            btn_f11_opciones.Text = "F11-Opciones";
            btn_f11_opciones.UseVisualStyleBackColor = true;
            // 
            // btn_f10_salir_venta
            // 
            btn_f10_salir_venta.Location = new Point(758, 97);
            btn_f10_salir_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f10_salir_venta.Name = "btn_f10_salir_venta";
            btn_f10_salir_venta.Size = new Size(92, 59);
            btn_f10_salir_venta.TabIndex = 11;
            btn_f10_salir_venta.Text = "F10-Salir";
            btn_f10_salir_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f9_precios_venta
            // 
            btn_f9_precios_venta.Location = new Point(573, 97);
            btn_f9_precios_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f9_precios_venta.Name = "btn_f9_precios_venta";
            btn_f9_precios_venta.Size = new Size(92, 59);
            btn_f9_precios_venta.TabIndex = 10;
            btn_f9_precios_venta.Text = "F9-Precios";
            btn_f9_precios_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f8_buscar_venta
            // 
            btn_f8_buscar_venta.Location = new Point(388, 97);
            btn_f8_buscar_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f8_buscar_venta.Name = "btn_f8_buscar_venta";
            btn_f8_buscar_venta.Size = new Size(92, 59);
            btn_f8_buscar_venta.TabIndex = 9;
            btn_f8_buscar_venta.Text = "F8-Buscar";
            btn_f8_buscar_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f7_imprimir_venta
            // 
            btn_f7_imprimir_venta.Location = new Point(204, 97);
            btn_f7_imprimir_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f7_imprimir_venta.Name = "btn_f7_imprimir_venta";
            btn_f7_imprimir_venta.Size = new Size(92, 59);
            btn_f7_imprimir_venta.TabIndex = 8;
            btn_f7_imprimir_venta.Text = "F7-Imprimir";
            btn_f7_imprimir_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f6_cancelar_venta
            // 
            btn_f6_cancelar_venta.Location = new Point(19, 97);
            btn_f6_cancelar_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f6_cancelar_venta.Name = "btn_f6_cancelar_venta";
            btn_f6_cancelar_venta.Size = new Size(92, 59);
            btn_f6_cancelar_venta.TabIndex = 7;
            btn_f6_cancelar_venta.Text = "F6-Cancelar";
            btn_f6_cancelar_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f5_cliente_venta
            // 
            btn_f5_cliente_venta.Location = new Point(758, 27);
            btn_f5_cliente_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f5_cliente_venta.Name = "btn_f5_cliente_venta";
            btn_f5_cliente_venta.Size = new Size(92, 59);
            btn_f5_cliente_venta.TabIndex = 6;
            btn_f5_cliente_venta.Text = "F5-Cliente";
            btn_f5_cliente_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f4_pago_venta
            // 
            btn_f4_pago_venta.Location = new Point(573, 27);
            btn_f4_pago_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f4_pago_venta.Name = "btn_f4_pago_venta";
            btn_f4_pago_venta.Size = new Size(92, 59);
            btn_f4_pago_venta.TabIndex = 5;
            btn_f4_pago_venta.Text = "F4-Pago";
            btn_f4_pago_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f3_descuento_venta
            // 
            btn_f3_descuento_venta.Location = new Point(388, 27);
            btn_f3_descuento_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f3_descuento_venta.Name = "btn_f3_descuento_venta";
            btn_f3_descuento_venta.Size = new Size(92, 59);
            btn_f3_descuento_venta.TabIndex = 4;
            btn_f3_descuento_venta.Text = "F3-Descuento";
            btn_f3_descuento_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f2_eliminar_venta
            // 
            btn_f2_eliminar_venta.Location = new Point(204, 27);
            btn_f2_eliminar_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f2_eliminar_venta.Name = "btn_f2_eliminar_venta";
            btn_f2_eliminar_venta.Size = new Size(92, 59);
            btn_f2_eliminar_venta.TabIndex = 3;
            btn_f2_eliminar_venta.Text = "F2-Eliminar";
            btn_f2_eliminar_venta.UseVisualStyleBackColor = true;
            // 
            // btn_f1_agregar_venta
            // 
            btn_f1_agregar_venta.Location = new Point(19, 27);
            btn_f1_agregar_venta.Margin = new Padding(2, 2, 2, 2);
            btn_f1_agregar_venta.Name = "btn_f1_agregar_venta";
            btn_f1_agregar_venta.Size = new Size(92, 59);
            btn_f1_agregar_venta.TabIndex = 2;
            btn_f1_agregar_venta.Text = "F1-Agregar";
            btn_f1_agregar_venta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            groupBox2.Location = new Point(11, 11);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(989, 111);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMACIÓN";
            // 
            // cb_metodopago_venta
            // 
            cb_metodopago_venta.FormattingEnabled = true;
            cb_metodopago_venta.Location = new Point(491, 59);
            cb_metodopago_venta.Margin = new Padding(2, 2, 2, 2);
            cb_metodopago_venta.Name = "cb_metodopago_venta";
            cb_metodopago_venta.Size = new Size(129, 23);
            cb_metodopago_venta.TabIndex = 14;
            // 
            // rb_credito_venta
            // 
            rb_credito_venta.AutoSize = true;
            rb_credito_venta.Location = new Point(246, 61);
            rb_credito_venta.Margin = new Padding(2, 2, 2, 2);
            rb_credito_venta.Name = "rb_credito_venta";
            rb_credito_venta.Size = new Size(64, 19);
            rb_credito_venta.TabIndex = 13;
            rb_credito_venta.TabStop = true;
            rb_credito_venta.Text = "Crédito";
            rb_credito_venta.UseVisualStyleBackColor = true;
            // 
            // rb_contado_venta
            // 
            rb_contado_venta.AutoSize = true;
            rb_contado_venta.Location = new Point(127, 61);
            rb_contado_venta.Margin = new Padding(2, 2, 2, 2);
            rb_contado_venta.Name = "rb_contado_venta";
            rb_contado_venta.Size = new Size(71, 19);
            rb_contado_venta.TabIndex = 12;
            rb_contado_venta.TabStop = true;
            rb_contado_venta.Text = "Contado";
            rb_contado_venta.UseVisualStyleBackColor = true;
            // 
            // lbl_folio_venta
            // 
            lbl_folio_venta.AutoSize = true;
            lbl_folio_venta.Location = new Point(489, 38);
            lbl_folio_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_folio_venta.Name = "lbl_folio_venta";
            lbl_folio_venta.Size = new Size(32, 15);
            lbl_folio_venta.TabIndex = 10;
            lbl_folio_venta.Text = "_____";
            // 
            // lbl_fecha_venta
            // 
            lbl_fecha_venta.AutoSize = true;
            lbl_fecha_venta.Location = new Point(489, 16);
            lbl_fecha_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_fecha_venta.Name = "lbl_fecha_venta";
            lbl_fecha_venta.Size = new Size(32, 15);
            lbl_fecha_venta.TabIndex = 9;
            lbl_fecha_venta.Text = "_____";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(400, 61);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 8;
            label9.Text = "Método Pago:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(446, 38);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Folio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 16);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha:";
            // 
            // lbl_cliente_venta
            // 
            lbl_cliente_venta.AutoSize = true;
            lbl_cliente_venta.Location = new Point(127, 38);
            lbl_cliente_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_cliente_venta.Name = "lbl_cliente_venta";
            lbl_cliente_venta.Size = new Size(32, 15);
            lbl_cliente_venta.TabIndex = 4;
            lbl_cliente_venta.Text = "_____";
            // 
            // lbl_empleado_venta
            // 
            lbl_empleado_venta.AutoSize = true;
            lbl_empleado_venta.Location = new Point(127, 16);
            lbl_empleado_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_empleado_venta.Name = "lbl_empleado_venta";
            lbl_empleado_venta.Size = new Size(32, 15);
            lbl_empleado_venta.TabIndex = 3;
            lbl_empleado_venta.Text = "_____";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo Venta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 38);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // groupBox3
            // 
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
            groupBox3.Location = new Point(11, 362);
            groupBox3.Margin = new Padding(2, 2, 2, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 2, 2, 2);
            groupBox3.Size = new Size(682, 68);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // lbl_stock_venta
            // 
            lbl_stock_venta.AutoSize = true;
            lbl_stock_venta.Location = new Point(388, 35);
            lbl_stock_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_stock_venta.Name = "lbl_stock_venta";
            lbl_stock_venta.Size = new Size(32, 15);
            lbl_stock_venta.TabIndex = 31;
            lbl_stock_venta.Text = "_____";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(328, 35);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(39, 15);
            label20.TabIndex = 30;
            label20.Text = "Stock:";
            // 
            // lbl_total_venta
            // 
            lbl_total_venta.AutoSize = true;
            lbl_total_venta.Location = new Point(388, 13);
            lbl_total_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_total_venta.Name = "lbl_total_venta";
            lbl_total_venta.Size = new Size(32, 15);
            lbl_total_venta.TabIndex = 29;
            lbl_total_venta.Text = "_____";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(332, 13);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 28;
            label17.Text = "Total:";
            // 
            // lbl_cambio_venta
            // 
            lbl_cambio_venta.AutoSize = true;
            lbl_cambio_venta.Location = new Point(246, 35);
            lbl_cambio_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_cambio_venta.Name = "lbl_cambio_venta";
            lbl_cambio_venta.Size = new Size(32, 15);
            lbl_cambio_venta.TabIndex = 24;
            lbl_cambio_venta.Text = "_____";
            // 
            // lbl_iva_venta
            // 
            lbl_iva_venta.AutoSize = true;
            lbl_iva_venta.Location = new Point(246, 13);
            lbl_iva_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_iva_venta.Name = "lbl_iva_venta";
            lbl_iva_venta.Size = new Size(32, 15);
            lbl_iva_venta.TabIndex = 23;
            lbl_iva_venta.Text = "_____";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(176, 35);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 21;
            label10.Text = "Cambio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(200, 13);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 20;
            label11.Text = "IVA:";
            // 
            // lbl_efectivo_venta
            // 
            lbl_efectivo_venta.AutoSize = true;
            lbl_efectivo_venta.Location = new Point(112, 35);
            lbl_efectivo_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_efectivo_venta.Name = "lbl_efectivo_venta";
            lbl_efectivo_venta.Size = new Size(32, 15);
            lbl_efectivo_venta.TabIndex = 19;
            lbl_efectivo_venta.Text = "_____";
            // 
            // lbl_subtotal_venta
            // 
            lbl_subtotal_venta.AutoSize = true;
            lbl_subtotal_venta.Location = new Point(112, 13);
            lbl_subtotal_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_subtotal_venta.Name = "lbl_subtotal_venta";
            lbl_subtotal_venta.Size = new Size(32, 15);
            lbl_subtotal_venta.TabIndex = 18;
            lbl_subtotal_venta.Text = "_____";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(57, 35);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 16;
            label15.Text = "Efectivo:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(53, 13);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 15;
            label16.Text = "Subtotal:";
            // 
            // tb_busqueda_ventas
            // 
            tb_busqueda_ventas.Location = new Point(12, 136);
            tb_busqueda_ventas.Name = "tb_busqueda_ventas";
            tb_busqueda_ventas.Size = new Size(988, 23);
            tb_busqueda_ventas.TabIndex = 4;
            // 
            // FormInterfazVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 633);
            Controls.Add(tb_busqueda_ventas);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormInterfazVentas";
            Text = "FormInterfazVentas";
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
    }
}