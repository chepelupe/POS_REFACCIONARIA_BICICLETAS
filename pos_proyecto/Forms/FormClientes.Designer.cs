namespace pos_proyecto
{
    partial class FormClientes
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
            btn_regresar_clientes = new Button();
            groupBox4 = new GroupBox();
            tc_clientes = new TabControl();
            tp_clientes = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            groupBox3 = new GroupBox();
            lv_lista_clientes = new ListView();
            groupBox2 = new GroupBox();
            btn_reportes_clientes = new Button();
            btn_nuevo_clientes = new Button();
            cb_filtros_clientes = new ComboBox();
            label2 = new Label();
            tb_busqueda_clientes = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_f6_productos_clientes = new Button();
            btn_f5_pagos_clientes = new Button();
            btn_f4_compras_clientes = new Button();
            btn_f3_eliminar_clientes = new Button();
            btn_f2_modificar_clientes = new Button();
            btn_f1_agregar_clientes = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox4.SuspendLayout();
            tc_clientes.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_regresar_clientes
            // 
            btn_regresar_clientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_regresar_clientes.BackColor = Color.FromArgb(108, 117, 125);
            btn_regresar_clientes.FlatAppearance.BorderSize = 0;
            btn_regresar_clientes.FlatStyle = FlatStyle.Flat;
            btn_regresar_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_regresar_clientes.ForeColor = Color.White;
            btn_regresar_clientes.Location = new Point(805, 348);
            btn_regresar_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_regresar_clientes.Name = "btn_regresar_clientes";
            btn_regresar_clientes.Size = new Size(84, 36);
            btn_regresar_clientes.TabIndex = 15;
            btn_regresar_clientes.Text = "Regresar";
            btn_regresar_clientes.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(tc_clientes);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(245, 120);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(644, 210);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detalles del Cliente";
            // 
            // tc_clientes
            // 
            tc_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tc_clientes.Controls.Add(tp_clientes);
            tc_clientes.Controls.Add(tabPage2);
            tc_clientes.Controls.Add(tabPage3);
            tc_clientes.Controls.Add(tabPage4);
            tc_clientes.Controls.Add(tabPage5);
            tc_clientes.Controls.Add(tabPage6);
            tc_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tc_clientes.Location = new Point(10, 21);
            tc_clientes.Margin = new Padding(3, 2, 3, 2);
            tc_clientes.Name = "tc_clientes";
            tc_clientes.SelectedIndex = 0;
            tc_clientes.Size = new Size(623, 180);
            tc_clientes.TabIndex = 1;
            // 
            // tp_clientes
            // 
            tp_clientes.Location = new Point(4, 24);
            tp_clientes.Margin = new Padding(3, 2, 3, 2);
            tp_clientes.Name = "tp_clientes";
            tp_clientes.Padding = new Padding(3, 2, 3, 2);
            tp_clientes.Size = new Size(615, 152);
            tp_clientes.TabIndex = 0;
            tp_clientes.Text = "Información Personal";
            tp_clientes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(615, 152);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Historial de Ventas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(615, 152);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Límite de Crédito";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(615, 152);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pagos y Estado de Cuenta";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(615, 152);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Documentación";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Margin = new Padding(3, 2, 3, 2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(615, 152);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Preferencias y Contacto";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lv_lista_clientes);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(21, 120);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(210, 210);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de Clientes";
            // 
            // lv_lista_clientes
            // 
            lv_lista_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lv_lista_clientes.BorderStyle = BorderStyle.FixedSingle;
            lv_lista_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_lista_clientes.FullRowSelect = true;
            lv_lista_clientes.GridLines = true;
            lv_lista_clientes.Location = new Point(10, 21);
            lv_lista_clientes.Margin = new Padding(3, 2, 3, 2);
            lv_lista_clientes.Name = "lv_lista_clientes";
            lv_lista_clientes.Size = new Size(190, 181);
            lv_lista_clientes.TabIndex = 4;
            lv_lista_clientes.UseCompatibleStateImageBehavior = false;
            lv_lista_clientes.View = View.Details;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btn_reportes_clientes);
            groupBox2.Controls.Add(btn_nuevo_clientes);
            groupBox2.Controls.Add(cb_filtros_clientes);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tb_busqueda_clientes);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 48);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(868, 60);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Búsqueda y Filtros";
            // 
            // btn_reportes_clientes
            // 
            btn_reportes_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_reportes_clientes.BackColor = Color.FromArgb(108, 117, 125);
            btn_reportes_clientes.FlatAppearance.BorderSize = 0;
            btn_reportes_clientes.FlatStyle = FlatStyle.Flat;
            btn_reportes_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reportes_clientes.ForeColor = Color.White;
            btn_reportes_clientes.Location = new Point(770, 18);
            btn_reportes_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_reportes_clientes.Name = "btn_reportes_clientes";
            btn_reportes_clientes.Size = new Size(84, 27);
            btn_reportes_clientes.TabIndex = 6;
            btn_reportes_clientes.Text = "Reportes";
            btn_reportes_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo_clientes
            // 
            btn_nuevo_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo_clientes.BackColor = Color.FromArgb(0, 122, 204);
            btn_nuevo_clientes.FlatAppearance.BorderSize = 0;
            btn_nuevo_clientes.FlatStyle = FlatStyle.Flat;
            btn_nuevo_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nuevo_clientes.ForeColor = Color.White;
            btn_nuevo_clientes.Location = new Point(665, 18);
            btn_nuevo_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_nuevo_clientes.Name = "btn_nuevo_clientes";
            btn_nuevo_clientes.Size = new Size(84, 27);
            btn_nuevo_clientes.TabIndex = 5;
            btn_nuevo_clientes.Text = "Nuevo Cliente";
            btn_nuevo_clientes.UseVisualStyleBackColor = false;
            // 
            // cb_filtros_clientes
            // 
            cb_filtros_clientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_filtros_clientes.FlatStyle = FlatStyle.Flat;
            cb_filtros_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_filtros_clientes.FormattingEnabled = true;
            cb_filtros_clientes.Items.AddRange(new object[] { "Todos", "Activos", "Con Crédito", "Morosos", "Por Zona", "Frecuentes" });
            cb_filtros_clientes.Location = new Point(420, 24);
            cb_filtros_clientes.Margin = new Padding(3, 2, 3, 2);
            cb_filtros_clientes.Name = "cb_filtros_clientes";
            cb_filtros_clientes.Size = new Size(141, 23);
            cb_filtros_clientes.TabIndex = 3;
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
            // tb_busqueda_clientes
            // 
            tb_busqueda_clientes.BorderStyle = BorderStyle.FixedSingle;
            tb_busqueda_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_busqueda_clientes.Location = new Point(140, 24);
            tb_busqueda_clientes.Margin = new Padding(3, 2, 3, 2);
            tb_busqueda_clientes.Name = "tb_busqueda_clientes";
            tb_busqueda_clientes.PlaceholderText = "Buscar cliente por nombre, RFC o teléfono...";
            tb_busqueda_clientes.Size = new Size(211, 23);
            tb_busqueda_clientes.TabIndex = 1;
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btn_f6_productos_clientes);
            groupBox1.Controls.Add(btn_f5_pagos_clientes);
            groupBox1.Controls.Add(btn_f4_compras_clientes);
            groupBox1.Controls.Add(btn_f3_eliminar_clientes);
            groupBox1.Controls.Add(btn_f2_modificar_clientes);
            groupBox1.Controls.Add(btn_f1_agregar_clientes);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 342);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(778, 76);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones de Clientes";
            // 
            // btn_f6_productos_clientes
            // 
            btn_f6_productos_clientes.BackColor = Color.FromArgb(111, 66, 193);
            btn_f6_productos_clientes.FlatAppearance.BorderSize = 0;
            btn_f6_productos_clientes.FlatStyle = FlatStyle.Flat;
            btn_f6_productos_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f6_productos_clientes.ForeColor = Color.White;
            btn_f6_productos_clientes.Location = new Point(644, 15);
            btn_f6_productos_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_f6_productos_clientes.Name = "btn_f6_productos_clientes";
            btn_f6_productos_clientes.Size = new Size(105, 43);
            btn_f6_productos_clientes.TabIndex = 9;
            btn_f6_productos_clientes.Text = "F6 - Preferencias";
            btn_f6_productos_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_f5_pagos_clientes
            // 
            btn_f5_pagos_clientes.BackColor = Color.FromArgb(32, 201, 151);
            btn_f5_pagos_clientes.FlatAppearance.BorderSize = 0;
            btn_f5_pagos_clientes.FlatStyle = FlatStyle.Flat;
            btn_f5_pagos_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f5_pagos_clientes.ForeColor = Color.White;
            btn_f5_pagos_clientes.Location = new Point(518, 15);
            btn_f5_pagos_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_f5_pagos_clientes.Name = "btn_f5_pagos_clientes";
            btn_f5_pagos_clientes.Size = new Size(105, 43);
            btn_f5_pagos_clientes.TabIndex = 8;
            btn_f5_pagos_clientes.Text = "F5 - Estado Cuenta";
            btn_f5_pagos_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_f4_compras_clientes
            // 
            btn_f4_compras_clientes.BackColor = Color.FromArgb(255, 193, 7);
            btn_f4_compras_clientes.FlatAppearance.BorderSize = 0;
            btn_f4_compras_clientes.FlatStyle = FlatStyle.Flat;
            btn_f4_compras_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f4_compras_clientes.ForeColor = Color.White;
            btn_f4_compras_clientes.Location = new Point(392, 15);
            btn_f4_compras_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_f4_compras_clientes.Name = "btn_f4_compras_clientes";
            btn_f4_compras_clientes.Size = new Size(105, 43);
            btn_f4_compras_clientes.TabIndex = 7;
            btn_f4_compras_clientes.Text = "F4 - Historial Ventas";
            btn_f4_compras_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_f3_eliminar_clientes
            // 
            btn_f3_eliminar_clientes.BackColor = Color.FromArgb(220, 53, 69);
            btn_f3_eliminar_clientes.FlatAppearance.BorderSize = 0;
            btn_f3_eliminar_clientes.FlatStyle = FlatStyle.Flat;
            btn_f3_eliminar_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f3_eliminar_clientes.ForeColor = Color.White;
            btn_f3_eliminar_clientes.Location = new Point(266, 15);
            btn_f3_eliminar_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_f3_eliminar_clientes.Name = "btn_f3_eliminar_clientes";
            btn_f3_eliminar_clientes.Size = new Size(105, 43);
            btn_f3_eliminar_clientes.TabIndex = 6;
            btn_f3_eliminar_clientes.Text = "F3 - Eliminar";
            btn_f3_eliminar_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_f2_modificar_clientes
            // 
            btn_f2_modificar_clientes.BackColor = Color.FromArgb(23, 162, 184);
            btn_f2_modificar_clientes.FlatAppearance.BorderSize = 0;
            btn_f2_modificar_clientes.FlatStyle = FlatStyle.Flat;
            btn_f2_modificar_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f2_modificar_clientes.ForeColor = Color.White;
            btn_f2_modificar_clientes.Location = new Point(140, 15);
            btn_f2_modificar_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_f2_modificar_clientes.Name = "btn_f2_modificar_clientes";
            btn_f2_modificar_clientes.Size = new Size(105, 43);
            btn_f2_modificar_clientes.TabIndex = 5;
            btn_f2_modificar_clientes.Text = "F2 - Modificar";
            btn_f2_modificar_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_f1_agregar_clientes
            // 
            btn_f1_agregar_clientes.BackColor = Color.FromArgb(0, 122, 204);
            btn_f1_agregar_clientes.FlatAppearance.BorderSize = 0;
            btn_f1_agregar_clientes.FlatStyle = FlatStyle.Flat;
            btn_f1_agregar_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f1_agregar_clientes.ForeColor = Color.White;
            btn_f1_agregar_clientes.Location = new Point(14, 15);
            btn_f1_agregar_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_f1_agregar_clientes.Name = "btn_f1_agregar_clientes";
            btn_f1_agregar_clientes.Size = new Size(105, 43);
            btn_f1_agregar_clientes.TabIndex = 4;
            btn_f1_agregar_clientes.Text = "F1 - Agregar";
            btn_f1_agregar_clientes.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(914, 42);
            panelHeader.TabIndex = 16;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(385, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(95, 30);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Clientes";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(914, 420);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(btn_regresar_clientes);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(930, 446);
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes - POS Refaccionaria";
            groupBox4.ResumeLayout(false);
            tc_clientes.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_regresar_clientes;
        private GroupBox groupBox4;
        private TabControl tc_clientes;
        private TabPage tp_clientes;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private GroupBox groupBox3;
        private ListView lv_lista_clientes;
        private GroupBox groupBox2;
        private Button btn_reportes_clientes;
        private Button btn_nuevo_clientes;
        private ComboBox cb_filtros_clientes;
        private Label label2;
        private TextBox tb_busqueda_clientes;
        private Label label1;
        private GroupBox groupBox1;
        private Button btn_f6_productos_clientes;
        private Button btn_f5_pagos_clientes;
        private Button btn_f4_compras_clientes;
        private Button btn_f3_eliminar_clientes;
        private Button btn_f2_modificar_clientes;
        private Button btn_f1_agregar_clientes;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}