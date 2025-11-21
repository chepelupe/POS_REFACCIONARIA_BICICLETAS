namespace pos_proyecto
{
    partial class FormCompras
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
            groupBox2 = new GroupBox();
            btn_reportes_compras = new Button();
            btn_nuevo_compras = new Button();
            cb_filtros_compras = new ComboBox();
            label2 = new Label();
            tb_busqueda_compras = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            lv_lista_compras = new ListView();
            groupBox4 = new GroupBox();
            tc_compra = new TabControl();
            tp_compras = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            btn_regresar_compras = new Button();
            groupBox1 = new GroupBox();
            btn_f6_productos_compras = new Button();
            btn_f5_pagos_compras = new Button();
            btn_f4_compras_compras = new Button();
            btn_f3_eliminar_compras = new Button();
            btn_f2_modificar_compras = new Button();
            btn_f1_agregar_compras = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tc_compra.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btn_reportes_compras);
            groupBox2.Controls.Add(btn_nuevo_compras);
            groupBox2.Controls.Add(cb_filtros_compras);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tb_busqueda_compras);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 48);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(914, 60);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Búsqueda y Filtros";
            // 
            // btn_reportes_compras
            // 
            btn_reportes_compras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_reportes_compras.BackColor = Color.FromArgb(108, 117, 125);
            btn_reportes_compras.FlatAppearance.BorderSize = 0;
            btn_reportes_compras.FlatStyle = FlatStyle.Flat;
            btn_reportes_compras.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reportes_compras.ForeColor = Color.White;
            btn_reportes_compras.Location = new Point(816, 18);
            btn_reportes_compras.Margin = new Padding(3, 2, 3, 2);
            btn_reportes_compras.Name = "btn_reportes_compras";
            btn_reportes_compras.Size = new Size(84, 27);
            btn_reportes_compras.TabIndex = 6;
            btn_reportes_compras.Text = "Reportes";
            btn_reportes_compras.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo_compras
            // 
            btn_nuevo_compras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo_compras.BackColor = Color.FromArgb(0, 122, 204);
            btn_nuevo_compras.FlatAppearance.BorderSize = 0;
            btn_nuevo_compras.FlatStyle = FlatStyle.Flat;
            btn_nuevo_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nuevo_compras.ForeColor = Color.White;
            btn_nuevo_compras.Location = new Point(711, 18);
            btn_nuevo_compras.Margin = new Padding(3, 2, 3, 2);
            btn_nuevo_compras.Name = "btn_nuevo_compras";
            btn_nuevo_compras.Size = new Size(84, 27);
            btn_nuevo_compras.TabIndex = 5;
            btn_nuevo_compras.Text = "Nueva Compra";
            btn_nuevo_compras.UseVisualStyleBackColor = false;
            // 
            // cb_filtros_compras
            // 
            cb_filtros_compras.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_filtros_compras.FlatStyle = FlatStyle.Flat;
            cb_filtros_compras.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_filtros_compras.FormattingEnabled = true;
            cb_filtros_compras.Items.AddRange(new object[] { "Todos", "Pendientes", "Completadas", "Canceladas", "Por Proveedor", "Por Fecha" });
            cb_filtros_compras.Location = new Point(417, 27);
            cb_filtros_compras.Margin = new Padding(3, 2, 3, 2);
            cb_filtros_compras.Name = "cb_filtros_compras";
            cb_filtros_compras.Size = new Size(141, 23);
            cb_filtros_compras.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(371, 27);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Filtrar:";
            // 
            // tb_busqueda_compras
            // 
            tb_busqueda_compras.BorderStyle = BorderStyle.FixedSingle;
            tb_busqueda_compras.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_busqueda_compras.Location = new Point(140, 24);
            tb_busqueda_compras.Margin = new Padding(3, 2, 3, 2);
            tb_busqueda_compras.Name = "tb_busqueda_compras";
            tb_busqueda_compras.PlaceholderText = "Buscar compra, proveedor o producto...";
            tb_busqueda_compras.Size = new Size(211, 23);
            tb_busqueda_compras.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lv_lista_compras);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(21, 120);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(245, 240);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de Compras";
            // 
            // lv_lista_compras
            // 
            lv_lista_compras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lv_lista_compras.BorderStyle = BorderStyle.FixedSingle;
            lv_lista_compras.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_lista_compras.FullRowSelect = true;
            lv_lista_compras.GridLines = true;
            lv_lista_compras.Location = new Point(10, 21);
            lv_lista_compras.Margin = new Padding(3, 2, 3, 2);
            lv_lista_compras.Name = "lv_lista_compras";
            lv_lista_compras.Size = new Size(225, 211);
            lv_lista_compras.TabIndex = 4;
            lv_lista_compras.UseCompatibleStateImageBehavior = false;
            lv_lista_compras.View = View.Details;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(tc_compra);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(280, 120);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(655, 240);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detalles de la Compra";
            // 
            // tc_compra
            // 
            tc_compra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tc_compra.Controls.Add(tp_compras);
            tc_compra.Controls.Add(tabPage2);
            tc_compra.Controls.Add(tabPage3);
            tc_compra.Controls.Add(tabPage4);
            tc_compra.Controls.Add(tabPage5);
            tc_compra.Controls.Add(tabPage6);
            tc_compra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tc_compra.Location = new Point(10, 21);
            tc_compra.Margin = new Padding(3, 2, 3, 2);
            tc_compra.Name = "tc_compra";
            tc_compra.SelectedIndex = 0;
            tc_compra.Size = new Size(634, 210);
            tc_compra.TabIndex = 1;
            // 
            // tp_compras
            // 
            tp_compras.Location = new Point(4, 24);
            tp_compras.Margin = new Padding(3, 2, 3, 2);
            tp_compras.Name = "tp_compras";
            tp_compras.Padding = new Padding(3, 2, 3, 2);
            tp_compras.Size = new Size(626, 182);
            tp_compras.TabIndex = 0;
            tp_compras.Text = "Historial de Compras";
            tp_compras.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(580, 182);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detalles de Compra";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(580, 182);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Líneas de Compra";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(580, 182);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pagos y Crédito";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(580, 182);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Documentación";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Margin = new Padding(3, 2, 3, 2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(580, 182);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Proveedores";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_regresar_compras
            // 
            btn_regresar_compras.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_regresar_compras.BackColor = Color.FromArgb(108, 117, 125);
            btn_regresar_compras.FlatAppearance.BorderSize = 0;
            btn_regresar_compras.FlatStyle = FlatStyle.Flat;
            btn_regresar_compras.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_regresar_compras.ForeColor = Color.White;
            btn_regresar_compras.Location = new Point(851, 387);
            btn_regresar_compras.Margin = new Padding(3, 2, 3, 2);
            btn_regresar_compras.Name = "btn_regresar_compras";
            btn_regresar_compras.Size = new Size(84, 36);
            btn_regresar_compras.TabIndex = 17;
            btn_regresar_compras.Text = "Regresar";
            btn_regresar_compras.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btn_f6_productos_compras);
            groupBox1.Controls.Add(btn_f5_pagos_compras);
            groupBox1.Controls.Add(btn_f4_compras_compras);
            groupBox1.Controls.Add(btn_f3_eliminar_compras);
            groupBox1.Controls.Add(btn_f2_modificar_compras);
            groupBox1.Controls.Add(btn_f1_agregar_compras);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 372);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(816, 66);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones de Compras";
            // 
            // btn_f6_productos_compras
            // 
            btn_f6_productos_compras.BackColor = Color.FromArgb(111, 66, 193);
            btn_f6_productos_compras.FlatAppearance.BorderSize = 0;
            btn_f6_productos_compras.FlatStyle = FlatStyle.Flat;
            btn_f6_productos_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f6_productos_compras.ForeColor = Color.White;
            btn_f6_productos_compras.Location = new Point(644, 15);
            btn_f6_productos_compras.Margin = new Padding(3, 2, 3, 2);
            btn_f6_productos_compras.Name = "btn_f6_productos_compras";
            btn_f6_productos_compras.Size = new Size(113, 47);
            btn_f6_productos_compras.TabIndex = 9;
            btn_f6_productos_compras.Text = "F6 - Proveedores";
            btn_f6_productos_compras.UseVisualStyleBackColor = false;
            // 
            // btn_f5_pagos_compras
            // 
            btn_f5_pagos_compras.BackColor = Color.FromArgb(32, 201, 151);
            btn_f5_pagos_compras.FlatAppearance.BorderSize = 0;
            btn_f5_pagos_compras.FlatStyle = FlatStyle.Flat;
            btn_f5_pagos_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f5_pagos_compras.ForeColor = Color.White;
            btn_f5_pagos_compras.Location = new Point(518, 15);
            btn_f5_pagos_compras.Margin = new Padding(3, 2, 3, 2);
            btn_f5_pagos_compras.Name = "btn_f5_pagos_compras";
            btn_f5_pagos_compras.Size = new Size(113, 47);
            btn_f5_pagos_compras.TabIndex = 8;
            btn_f5_pagos_compras.Text = "F5 - Pagos";
            btn_f5_pagos_compras.UseVisualStyleBackColor = false;
            // 
            // btn_f4_compras_compras
            // 
            btn_f4_compras_compras.BackColor = Color.FromArgb(255, 193, 7);
            btn_f4_compras_compras.FlatAppearance.BorderSize = 0;
            btn_f4_compras_compras.FlatStyle = FlatStyle.Flat;
            btn_f4_compras_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f4_compras_compras.ForeColor = Color.White;
            btn_f4_compras_compras.Location = new Point(392, 15);
            btn_f4_compras_compras.Margin = new Padding(3, 2, 3, 2);
            btn_f4_compras_compras.Name = "btn_f4_compras_compras";
            btn_f4_compras_compras.Size = new Size(113, 47);
            btn_f4_compras_compras.TabIndex = 7;
            btn_f4_compras_compras.Text = "F4 - Historial";
            btn_f4_compras_compras.UseVisualStyleBackColor = false;
            // 
            // btn_f3_eliminar_compras
            // 
            btn_f3_eliminar_compras.BackColor = Color.FromArgb(220, 53, 69);
            btn_f3_eliminar_compras.FlatAppearance.BorderSize = 0;
            btn_f3_eliminar_compras.FlatStyle = FlatStyle.Flat;
            btn_f3_eliminar_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f3_eliminar_compras.ForeColor = Color.White;
            btn_f3_eliminar_compras.Location = new Point(266, 15);
            btn_f3_eliminar_compras.Margin = new Padding(3, 2, 3, 2);
            btn_f3_eliminar_compras.Name = "btn_f3_eliminar_compras";
            btn_f3_eliminar_compras.Size = new Size(113, 47);
            btn_f3_eliminar_compras.TabIndex = 6;
            btn_f3_eliminar_compras.Text = "F3 - Eliminar";
            btn_f3_eliminar_compras.UseVisualStyleBackColor = false;
            // 
            // btn_f2_modificar_compras
            // 
            btn_f2_modificar_compras.BackColor = Color.FromArgb(23, 162, 184);
            btn_f2_modificar_compras.FlatAppearance.BorderSize = 0;
            btn_f2_modificar_compras.FlatStyle = FlatStyle.Flat;
            btn_f2_modificar_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f2_modificar_compras.ForeColor = Color.White;
            btn_f2_modificar_compras.Location = new Point(140, 15);
            btn_f2_modificar_compras.Margin = new Padding(3, 2, 3, 2);
            btn_f2_modificar_compras.Name = "btn_f2_modificar_compras";
            btn_f2_modificar_compras.Size = new Size(113, 47);
            btn_f2_modificar_compras.TabIndex = 5;
            btn_f2_modificar_compras.Text = "F2 - Modificar";
            btn_f2_modificar_compras.UseVisualStyleBackColor = false;
            // 
            // btn_f1_agregar_compras
            // 
            btn_f1_agregar_compras.BackColor = Color.FromArgb(0, 122, 204);
            btn_f1_agregar_compras.FlatAppearance.BorderSize = 0;
            btn_f1_agregar_compras.FlatStyle = FlatStyle.Flat;
            btn_f1_agregar_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f1_agregar_compras.ForeColor = Color.White;
            btn_f1_agregar_compras.Location = new Point(14, 15);
            btn_f1_agregar_compras.Margin = new Padding(3, 2, 3, 2);
            btn_f1_agregar_compras.Name = "btn_f1_agregar_compras";
            btn_f1_agregar_compras.Size = new Size(113, 47);
            btn_f1_agregar_compras.TabIndex = 4;
            btn_f1_agregar_compras.Text = "F1 - Nueva Compra";
            btn_f1_agregar_compras.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(960, 42);
            panelHeader.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(385, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(105, 30);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Compras";
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(960, 449);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(btn_regresar_compras);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(930, 446);
            Name = "FormCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Compras - POS Refaccionaria";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tc_compra.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_reportes_compras;
        private Button btn_nuevo_compras;
        private ComboBox cb_filtros_compras;
        private Label label2;
        private TextBox tb_busqueda_compras;
        private Label label1;
        private GroupBox groupBox3;
        private ListView lv_lista_compras;
        private GroupBox groupBox4;
        private TabControl tc_compra;
        private TabPage tp_compras;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button btn_regresar_compras;
        private GroupBox groupBox1;
        private Button btn_f6_productos_compras;
        private Button btn_f5_pagos_compras;
        private Button btn_f4_compras_compras;
        private Button btn_f3_eliminar_compras;
        private Button btn_f2_modificar_compras;
        private Button btn_f1_agregar_compras;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}