namespace pos_proyecto
{
    partial class FormEmpleados
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
            btn_regresar_proveedores = new Button();
            groupBox4 = new GroupBox();
            tc_proveedores = new TabControl();
            tp_empleados = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            groupBox3 = new GroupBox();
            lv_lista__empleados = new ListView();
            groupBox2 = new GroupBox();
            btn_reportes_empleados = new Button();
            btn_nuevo_empleados = new Button();
            cb_filtros_empleados = new ComboBox();
            label2 = new Label();
            tb_busqueda_empleados = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_f6_productos_empleados = new Button();
            btn_f5_pagos_empleados = new Button();
            btn_f4_compras_empleados = new Button();
            btn_f3_eliminar_empleados = new Button();
            btn_f2_modificar_empleados = new Button();
            btn_f1_agregar_empleados = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox4.SuspendLayout();
            tc_proveedores.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_regresar_proveedores
            // 
            btn_regresar_proveedores.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_regresar_proveedores.BackColor = Color.FromArgb(108, 117, 125);
            btn_regresar_proveedores.FlatAppearance.BorderSize = 0;
            btn_regresar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_regresar_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_regresar_proveedores.ForeColor = Color.White;
            btn_regresar_proveedores.Location = new Point(818, 357);
            btn_regresar_proveedores.Margin = new Padding(3, 2, 3, 2);
            btn_regresar_proveedores.Name = "btn_regresar_proveedores";
            btn_regresar_proveedores.Size = new Size(84, 36);
            btn_regresar_proveedores.TabIndex = 20;
            btn_regresar_proveedores.Text = "Regresar";
            btn_regresar_proveedores.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(tc_proveedores);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(245, 120);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(644, 210);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detalles del Empleado";
            // 
            // tc_proveedores
            // 
            tc_proveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tc_proveedores.Controls.Add(tp_empleados);
            tc_proveedores.Controls.Add(tabPage2);
            tc_proveedores.Controls.Add(tabPage3);
            tc_proveedores.Controls.Add(tabPage5);
            tc_proveedores.Controls.Add(tabPage6);
            tc_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tc_proveedores.Location = new Point(10, 21);
            tc_proveedores.Margin = new Padding(3, 2, 3, 2);
            tc_proveedores.Name = "tc_proveedores";
            tc_proveedores.SelectedIndex = 0;
            tc_proveedores.Size = new Size(623, 180);
            tc_proveedores.TabIndex = 1;
            // 
            // tp_empleados
            // 
            tp_empleados.Location = new Point(4, 24);
            tp_empleados.Margin = new Padding(3, 2, 3, 2);
            tp_empleados.Name = "tp_empleados";
            tp_empleados.Padding = new Padding(3, 2, 3, 2);
            tp_empleados.Size = new Size(615, 152);
            tp_empleados.TabIndex = 0;
            tp_empleados.Text = "Información Personal";
            tp_empleados.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(615, 152);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Información Laboral";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(615, 152);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Nómina y Salarios";
            tabPage3.UseVisualStyleBackColor = true;
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
            tabPage6.Text = "Evaluación y Desempeño";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lv_lista__empleados);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(21, 120);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(210, 210);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de Empleados";
            // 
            // lv_lista__empleados
            // 
            lv_lista__empleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lv_lista__empleados.BorderStyle = BorderStyle.FixedSingle;
            lv_lista__empleados.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_lista__empleados.FullRowSelect = true;
            lv_lista__empleados.GridLines = true;
            lv_lista__empleados.Location = new Point(10, 21);
            lv_lista__empleados.Margin = new Padding(3, 2, 3, 2);
            lv_lista__empleados.Name = "lv_lista__empleados";
            lv_lista__empleados.Size = new Size(190, 181);
            lv_lista__empleados.TabIndex = 4;
            lv_lista__empleados.UseCompatibleStateImageBehavior = false;
            lv_lista__empleados.View = View.Details;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btn_reportes_empleados);
            groupBox2.Controls.Add(btn_nuevo_empleados);
            groupBox2.Controls.Add(cb_filtros_empleados);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tb_busqueda_empleados);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 48);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(868, 60);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Búsqueda y Filtros";
            // 
            // btn_reportes_empleados
            // 
            btn_reportes_empleados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_reportes_empleados.BackColor = Color.FromArgb(108, 117, 125);
            btn_reportes_empleados.FlatAppearance.BorderSize = 0;
            btn_reportes_empleados.FlatStyle = FlatStyle.Flat;
            btn_reportes_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reportes_empleados.ForeColor = Color.White;
            btn_reportes_empleados.Location = new Point(770, 18);
            btn_reportes_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_reportes_empleados.Name = "btn_reportes_empleados";
            btn_reportes_empleados.Size = new Size(84, 27);
            btn_reportes_empleados.TabIndex = 6;
            btn_reportes_empleados.Text = "Reportes";
            btn_reportes_empleados.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo_empleados
            // 
            btn_nuevo_empleados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo_empleados.BackColor = Color.FromArgb(0, 122, 204);
            btn_nuevo_empleados.FlatAppearance.BorderSize = 0;
            btn_nuevo_empleados.FlatStyle = FlatStyle.Flat;
            btn_nuevo_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nuevo_empleados.ForeColor = Color.White;
            btn_nuevo_empleados.Location = new Point(665, 18);
            btn_nuevo_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_nuevo_empleados.Name = "btn_nuevo_empleados";
            btn_nuevo_empleados.Size = new Size(84, 27);
            btn_nuevo_empleados.TabIndex = 5;
            btn_nuevo_empleados.Text = "Nuevo";
            btn_nuevo_empleados.UseVisualStyleBackColor = false;
            // 
            // cb_filtros_empleados
            // 
            cb_filtros_empleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_filtros_empleados.FlatStyle = FlatStyle.Flat;
            cb_filtros_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_filtros_empleados.FormattingEnabled = true;
            cb_filtros_empleados.Items.AddRange(new object[] { "Todos", "Activos", "Inactivos", "Por Departamento", "Por Puesto" });
            cb_filtros_empleados.Location = new Point(420, 24);
            cb_filtros_empleados.Margin = new Padding(3, 2, 3, 2);
            cb_filtros_empleados.Name = "cb_filtros_empleados";
            cb_filtros_empleados.Size = new Size(141, 23);
            cb_filtros_empleados.TabIndex = 3;
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
            // tb_busqueda_empleados
            // 
            tb_busqueda_empleados.BorderStyle = BorderStyle.FixedSingle;
            tb_busqueda_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_busqueda_empleados.Location = new Point(140, 24);
            tb_busqueda_empleados.Margin = new Padding(3, 2, 3, 2);
            tb_busqueda_empleados.Name = "tb_busqueda_empleados";
            tb_busqueda_empleados.PlaceholderText = "Buscar empleado...";
            tb_busqueda_empleados.Size = new Size(211, 23);
            tb_busqueda_empleados.TabIndex = 1;
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
            groupBox1.Controls.Add(btn_f6_productos_empleados);
            groupBox1.Controls.Add(btn_f5_pagos_empleados);
            groupBox1.Controls.Add(btn_f4_compras_empleados);
            groupBox1.Controls.Add(btn_f3_eliminar_empleados);
            groupBox1.Controls.Add(btn_f2_modificar_empleados);
            groupBox1.Controls.Add(btn_f1_agregar_empleados);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 342);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(791, 67);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones de Empleados";
            // 
            // btn_f6_productos_empleados
            // 
            btn_f6_productos_empleados.BackColor = Color.FromArgb(111, 66, 193);
            btn_f6_productos_empleados.FlatAppearance.BorderSize = 0;
            btn_f6_productos_empleados.FlatStyle = FlatStyle.Flat;
            btn_f6_productos_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f6_productos_empleados.ForeColor = Color.White;
            btn_f6_productos_empleados.Location = new Point(644, 15);
            btn_f6_productos_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_f6_productos_empleados.Name = "btn_f6_productos_empleados";
            btn_f6_productos_empleados.Size = new Size(105, 48);
            btn_f6_productos_empleados.TabIndex = 9;
            btn_f6_productos_empleados.Text = "F6 - Evaluación";
            btn_f6_productos_empleados.UseVisualStyleBackColor = false;
            // 
            // btn_f5_pagos_empleados
            // 
            btn_f5_pagos_empleados.BackColor = Color.FromArgb(32, 201, 151);
            btn_f5_pagos_empleados.FlatAppearance.BorderSize = 0;
            btn_f5_pagos_empleados.FlatStyle = FlatStyle.Flat;
            btn_f5_pagos_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f5_pagos_empleados.ForeColor = Color.White;
            btn_f5_pagos_empleados.Location = new Point(518, 15);
            btn_f5_pagos_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_f5_pagos_empleados.Name = "btn_f5_pagos_empleados";
            btn_f5_pagos_empleados.Size = new Size(105, 48);
            btn_f5_pagos_empleados.TabIndex = 8;
            btn_f5_pagos_empleados.Text = "F5 - Desempeño";
            btn_f5_pagos_empleados.UseVisualStyleBackColor = false;
            // 
            // btn_f4_compras_empleados
            // 
            btn_f4_compras_empleados.BackColor = Color.FromArgb(255, 193, 7);
            btn_f4_compras_empleados.FlatAppearance.BorderSize = 0;
            btn_f4_compras_empleados.FlatStyle = FlatStyle.Flat;
            btn_f4_compras_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f4_compras_empleados.ForeColor = Color.White;
            btn_f4_compras_empleados.Location = new Point(392, 15);
            btn_f4_compras_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_f4_compras_empleados.Name = "btn_f4_compras_empleados";
            btn_f4_compras_empleados.Size = new Size(105, 48);
            btn_f4_compras_empleados.TabIndex = 7;
            btn_f4_compras_empleados.Text = "F4 - Nómina";
            btn_f4_compras_empleados.UseVisualStyleBackColor = false;
            // 
            // btn_f3_eliminar_empleados
            // 
            btn_f3_eliminar_empleados.BackColor = Color.FromArgb(220, 53, 69);
            btn_f3_eliminar_empleados.FlatAppearance.BorderSize = 0;
            btn_f3_eliminar_empleados.FlatStyle = FlatStyle.Flat;
            btn_f3_eliminar_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f3_eliminar_empleados.ForeColor = Color.White;
            btn_f3_eliminar_empleados.Location = new Point(266, 15);
            btn_f3_eliminar_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_f3_eliminar_empleados.Name = "btn_f3_eliminar_empleados";
            btn_f3_eliminar_empleados.Size = new Size(105, 48);
            btn_f3_eliminar_empleados.TabIndex = 6;
            btn_f3_eliminar_empleados.Text = "F3 - Eliminar";
            btn_f3_eliminar_empleados.UseVisualStyleBackColor = false;
            // 
            // btn_f2_modificar_empleados
            // 
            btn_f2_modificar_empleados.BackColor = Color.FromArgb(23, 162, 184);
            btn_f2_modificar_empleados.FlatAppearance.BorderSize = 0;
            btn_f2_modificar_empleados.FlatStyle = FlatStyle.Flat;
            btn_f2_modificar_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f2_modificar_empleados.ForeColor = Color.White;
            btn_f2_modificar_empleados.Location = new Point(140, 15);
            btn_f2_modificar_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_f2_modificar_empleados.Name = "btn_f2_modificar_empleados";
            btn_f2_modificar_empleados.Size = new Size(105, 48);
            btn_f2_modificar_empleados.TabIndex = 5;
            btn_f2_modificar_empleados.Text = "F2 - Modificar";
            btn_f2_modificar_empleados.UseVisualStyleBackColor = false;
            // 
            // btn_f1_agregar_empleados
            // 
            btn_f1_agregar_empleados.BackColor = Color.FromArgb(0, 122, 204);
            btn_f1_agregar_empleados.FlatAppearance.BorderSize = 0;
            btn_f1_agregar_empleados.FlatStyle = FlatStyle.Flat;
            btn_f1_agregar_empleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f1_agregar_empleados.ForeColor = Color.White;
            btn_f1_agregar_empleados.Location = new Point(14, 15);
            btn_f1_agregar_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_f1_agregar_empleados.Name = "btn_f1_agregar_empleados";
            btn_f1_agregar_empleados.Size = new Size(105, 48);
            btn_f1_agregar_empleados.TabIndex = 4;
            btn_f1_agregar_empleados.Text = "F1 - Agregar";
            btn_f1_agregar_empleados.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(914, 42);
            panelHeader.TabIndex = 21;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(385, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 30);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Empleados";
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(914, 420);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(btn_regresar_proveedores);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(930, 446);
            Name = "FormEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Empleados - POS Refaccionaria";
            groupBox4.ResumeLayout(false);
            tc_proveedores.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_regresar_proveedores;
        private GroupBox groupBox4;
        private TabControl tc_proveedores;
        private TabPage tp_empleados;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private GroupBox groupBox3;
        private ListView lv_lista__empleados;
        private GroupBox groupBox2;
        private Button btn_reportes_empleados;
        private Button btn_nuevo_empleados;
        private ComboBox cb_filtros_empleados;
        private Label label2;
        private TextBox tb_busqueda_empleados;
        private Label label1;
        private GroupBox groupBox1;
        private Button btn_f6_productos_empleados;
        private Button btn_f5_pagos_empleados;
        private Button btn_f4_compras_empleados;
        private Button btn_f3_eliminar_empleados;
        private Button btn_f2_modificar_empleados;
        private Button btn_f1_agregar_empleados;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}