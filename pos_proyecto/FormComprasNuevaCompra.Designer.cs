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
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_total_venta);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(lbl_iva_venta);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lbl_subtotal_venta);
            groupBox3.Controls.Add(label16);
            groupBox3.Location = new Point(36, 227);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(682, 55);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lbl_total_venta
            // 
            lbl_total_venta.AutoSize = true;
            lbl_total_venta.Location = new Point(387, 12);
            lbl_total_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_total_venta.Name = "lbl_total_venta";
            lbl_total_venta.Size = new Size(32, 15);
            lbl_total_venta.TabIndex = 29;
            lbl_total_venta.Text = "_____";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(331, 12);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 28;
            label17.Text = "Total:";
            // 
            // lbl_iva_venta
            // 
            lbl_iva_venta.AutoSize = true;
            lbl_iva_venta.Location = new Point(245, 12);
            lbl_iva_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_iva_venta.Name = "lbl_iva_venta";
            lbl_iva_venta.Size = new Size(32, 15);
            lbl_iva_venta.TabIndex = 23;
            lbl_iva_venta.Text = "_____";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(199, 12);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 20;
            label11.Text = "IVA:";
            // 
            // lbl_subtotal_venta
            // 
            lbl_subtotal_venta.AutoSize = true;
            lbl_subtotal_venta.Location = new Point(111, 12);
            lbl_subtotal_venta.Margin = new Padding(2, 0, 2, 0);
            lbl_subtotal_venta.Name = "lbl_subtotal_venta";
            lbl_subtotal_venta.Size = new Size(32, 15);
            lbl_subtotal_venta.TabIndex = 18;
            lbl_subtotal_venta.Text = "_____";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(52, 12);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 15;
            label16.Text = "Subtotal:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CLAVE, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(36, 48);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(819, 175);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
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
            groupBox1.Controls.Add(btn_f6_productos_proveedores);
            groupBox1.Controls.Add(btn_f5_pagos_proveedores);
            groupBox1.Controls.Add(btn_f4_compras_proveedores);
            groupBox1.Controls.Add(btn_f3_eliminar_proveedores);
            groupBox1.Controls.Add(btn_f2_modificar_proveedores);
            groupBox1.Controls.Add(btn_f1_agregar_proveedores);
            groupBox1.Location = new Point(36, 286);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(766, 90);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // btn_f6_productos_proveedores
            // 
            btn_f6_productos_proveedores.Location = new Point(629, 18);
            btn_f6_productos_proveedores.Margin = new Padding(2);
            btn_f6_productos_proveedores.Name = "btn_f6_productos_proveedores";
            btn_f6_productos_proveedores.Size = new Size(92, 59);
            btn_f6_productos_proveedores.TabIndex = 9;
            btn_f6_productos_proveedores.Text = "F6-Productos";
            btn_f6_productos_proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_f5_pagos_proveedores
            // 
            btn_f5_pagos_proveedores.Location = new Point(507, 18);
            btn_f5_pagos_proveedores.Margin = new Padding(2);
            btn_f5_pagos_proveedores.Name = "btn_f5_pagos_proveedores";
            btn_f5_pagos_proveedores.Size = new Size(92, 59);
            btn_f5_pagos_proveedores.TabIndex = 8;
            btn_f5_pagos_proveedores.Text = "F5-Pagos";
            btn_f5_pagos_proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_f4_compras_proveedores
            // 
            btn_f4_compras_proveedores.Location = new Point(385, 18);
            btn_f4_compras_proveedores.Margin = new Padding(2);
            btn_f4_compras_proveedores.Name = "btn_f4_compras_proveedores";
            btn_f4_compras_proveedores.Size = new Size(92, 59);
            btn_f4_compras_proveedores.TabIndex = 7;
            btn_f4_compras_proveedores.Text = "F4-Historial Compras";
            btn_f4_compras_proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_f3_eliminar_proveedores
            // 
            btn_f3_eliminar_proveedores.Location = new Point(263, 18);
            btn_f3_eliminar_proveedores.Margin = new Padding(2);
            btn_f3_eliminar_proveedores.Name = "btn_f3_eliminar_proveedores";
            btn_f3_eliminar_proveedores.Size = new Size(92, 59);
            btn_f3_eliminar_proveedores.TabIndex = 6;
            btn_f3_eliminar_proveedores.Text = "F3-Eliminar";
            btn_f3_eliminar_proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_f2_modificar_proveedores
            // 
            btn_f2_modificar_proveedores.Location = new Point(141, 18);
            btn_f2_modificar_proveedores.Margin = new Padding(2);
            btn_f2_modificar_proveedores.Name = "btn_f2_modificar_proveedores";
            btn_f2_modificar_proveedores.Size = new Size(92, 59);
            btn_f2_modificar_proveedores.TabIndex = 5;
            btn_f2_modificar_proveedores.Text = "F2-Modificar";
            btn_f2_modificar_proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_f1_agregar_proveedores
            // 
            btn_f1_agregar_proveedores.Location = new Point(20, 18);
            btn_f1_agregar_proveedores.Margin = new Padding(2);
            btn_f1_agregar_proveedores.Name = "btn_f1_agregar_proveedores";
            btn_f1_agregar_proveedores.Size = new Size(92, 59);
            btn_f1_agregar_proveedores.TabIndex = 4;
            btn_f1_agregar_proveedores.Text = "F1-Agregar nuevo producto";
            btn_f1_agregar_proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_regresar_proveedores
            // 
            btn_regresar_proveedores.Location = new Point(806, 304);
            btn_regresar_proveedores.Margin = new Padding(2);
            btn_regresar_proveedores.Name = "btn_regresar_proveedores";
            btn_regresar_proveedores.Size = new Size(92, 59);
            btn_regresar_proveedores.TabIndex = 16;
            btn_regresar_proveedores.Text = "Regresar";
            btn_regresar_proveedores.UseVisualStyleBackColor = true;
            // 
            // tb_busqueda_compras
            // 
            tb_busqueda_compras.Location = new Point(36, 12);
            tb_busqueda_compras.Name = "tb_busqueda_compras";
            tb_busqueda_compras.Size = new Size(819, 23);
            tb_busqueda_compras.TabIndex = 17;
            // 
            // FormComprasNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 395);
            Controls.Add(tb_busqueda_compras);
            Controls.Add(btn_regresar_proveedores);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Name = "FormComprasNuevaCompra";
            Text = "FormComprasNuevaCompra";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
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
    }
}