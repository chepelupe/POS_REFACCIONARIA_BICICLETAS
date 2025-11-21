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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            groupBox2 = new GroupBox();
            btn_reportes_proveedores = new Button();
            btn_nuevo_proveedores = new Button();
            cb_filtros_proveedores = new ComboBox();
            label2 = new Label();
            tb_busqueda_proveedores = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            lv_lista_proveedores = new ListView();
            groupBox4 = new GroupBox();
            tc_proveedores = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            btn_regresar_proveedores = new Button();
            groupBox1 = new GroupBox();
            btn_f6_productos_proveedores = new Button();
            btn_f5_pagos_proveedores = new Button();
            btn_f4_compras_proveedores = new Button();
            btn_f3_eliminar_proveedores = new Button();
            btn_f2_modificar_proveedores = new Button();
            btn_f1_agregar_proveedores = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tc_proveedores.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btn_reportes_proveedores);
            groupBox2.Controls.Add(btn_nuevo_proveedores);
            groupBox2.Controls.Add(cb_filtros_proveedores);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tb_busqueda_proveedores);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(30, 80);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1240, 100);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Búsqueda y Filtros";
            // 
            // btn_reportes_proveedores
            // 
            btn_reportes_proveedores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_reportes_proveedores.BackColor = Color.FromArgb(108, 117, 125);
            btn_reportes_proveedores.FlatAppearance.BorderSize = 0;
            btn_reportes_proveedores.FlatStyle = FlatStyle.Flat;
            btn_reportes_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reportes_proveedores.ForeColor = Color.White;
            btn_reportes_proveedores.Location = new Point(1100, 30);
            btn_reportes_proveedores.Margin = new Padding(4);
            btn_reportes_proveedores.Name = "btn_reportes_proveedores";
            btn_reportes_proveedores.Size = new Size(120, 45);
            btn_reportes_proveedores.TabIndex = 6;
            btn_reportes_proveedores.Text = "Reportes";
            btn_reportes_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo_proveedores
            // 
            btn_nuevo_proveedores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo_proveedores.BackColor = Color.FromArgb(0, 122, 204);
            btn_nuevo_proveedores.FlatAppearance.BorderSize = 0;
            btn_nuevo_proveedores.FlatStyle = FlatStyle.Flat;
            btn_nuevo_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nuevo_proveedores.ForeColor = Color.White;
            btn_nuevo_proveedores.Location = new Point(950, 30);
            btn_nuevo_proveedores.Margin = new Padding(4);
            btn_nuevo_proveedores.Name = "btn_nuevo_proveedores";
            btn_nuevo_proveedores.Size = new Size(120, 45);
            btn_nuevo_proveedores.TabIndex = 5;
            btn_nuevo_proveedores.Text = "Nueva Compra";
            btn_nuevo_proveedores.UseVisualStyleBackColor = false;
            // 
            // cb_filtros_proveedores
            // 
            cb_filtros_proveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_filtros_proveedores.FlatStyle = FlatStyle.Flat;
            cb_filtros_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_filtros_proveedores.FormattingEnabled = true;
            cb_filtros_proveedores.Items.AddRange(new object[] { "Todos", "Pendientes", "Completadas", "Canceladas", "Por Proveedor", "Por Fecha" });
            cb_filtros_proveedores.Location = new Point(600, 40);
            cb_filtros_proveedores.Margin = new Padding(4);
            cb_filtros_proveedores.Name = "cb_filtros_proveedores";
            cb_filtros_proveedores.Size = new Size(200, 33);
            cb_filtros_proveedores.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(530, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 2;
            label2.Text = "Filtrar:";
            // 
            // tb_busqueda_proveedores
            // 
            tb_busqueda_proveedores.BorderStyle = BorderStyle.FixedSingle;
            tb_busqueda_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_busqueda_proveedores.Location = new Point(200, 40);
            tb_busqueda_proveedores.Margin = new Padding(4);
            tb_busqueda_proveedores.Name = "tb_busqueda_proveedores";
            tb_busqueda_proveedores.PlaceholderText = "Buscar compra, proveedor o producto...";
            tb_busqueda_proveedores.Size = new Size(300, 31);
            tb_busqueda_proveedores.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lv_lista_proveedores);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(30, 200);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(350, 400);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de Compras";
            // 
            // lv_lista_proveedores
            // 
            lv_lista_proveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lv_lista_proveedores.BorderStyle = BorderStyle.FixedSingle;
            lv_lista_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_lista_proveedores.FullRowSelect = true;
            lv_lista_proveedores.GridLines = true;
            lv_lista_proveedores.Location = new Point(15, 35);
            lv_lista_proveedores.Margin = new Padding(4);
            lv_lista_proveedores.Name = "lv_lista_proveedores";
            lv_lista_proveedores.Size = new Size(320, 350);
            lv_lista_proveedores.TabIndex = 4;
            lv_lista_proveedores.UseCompatibleStateImageBehavior = false;
            lv_lista_proveedores.View = View.Details;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(tc_proveedores);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(400, 200);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(870, 400);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detalles de la Compra";
            // 
            // tc_proveedores
            // 
            tc_proveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tc_proveedores.Controls.Add(tabPage1);
            tc_proveedores.Controls.Add(tabPage2);
            tc_proveedores.Controls.Add(tabPage3);
            tc_proveedores.Controls.Add(tabPage4);
            tc_proveedores.Controls.Add(tabPage5);
            tc_proveedores.Controls.Add(tabPage6);
            tc_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tc_proveedores.Location = new Point(15, 35);
            tc_proveedores.Margin = new Padding(4);
            tc_proveedores.Name = "tc_proveedores";
            tc_proveedores.SelectedIndex = 0;
            tc_proveedores.Size = new Size(840, 350);
            tc_proveedores.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(832, 312);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Historial de Compras";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(832, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detalles de Compra";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(832, 312);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Líneas de Compra";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Margin = new Padding(4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(832, 312);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pagos y Crédito";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 34);
            tabPage5.Margin = new Padding(4);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(832, 312);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Documentación";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 34);
            tabPage6.Margin = new Padding(4);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(832, 312);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Proveedores";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_regresar_proveedores
            // 
            btn_regresar_proveedores.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_regresar_proveedores.BackColor = Color.FromArgb(108, 117, 125);
            btn_regresar_proveedores.FlatAppearance.BorderSize = 0;
            btn_regresar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_regresar_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_regresar_proveedores.ForeColor = Color.White;
            btn_regresar_proveedores.Location = new Point(1150, 620);
            btn_regresar_proveedores.Margin = new Padding(4);
            btn_regresar_proveedores.Name = "btn_regresar_proveedores";
            btn_regresar_proveedores.Size = new Size(120, 60);
            btn_regresar_proveedores.TabIndex = 17;
            btn_regresar_proveedores.Text = "Regresar";
            btn_regresar_proveedores.UseVisualStyleBackColor = false;
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
            groupBox1.Location = new Point(30, 620);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1100, 100);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones de Compras";
            // 
            // btn_f6_productos_proveedores
            // 
            btn_f6_productos_proveedores.BackColor = Color.FromArgb(111, 66, 193);
            btn_f6_productos_proveedores.FlatAppearance.BorderSize = 0;
            btn_f6_productos_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f6_productos_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f6_productos_proveedores.ForeColor = Color.White;
            btn_f6_productos_proveedores.Location = new Point(920, 25);
            btn_f6_productos_proveedores.Margin = new Padding(4);
            btn_f6_productos_proveedores.Name = "btn_f6_productos_proveedores";
            btn_f6_productos_proveedores.Size = new Size(150, 60);
            btn_f6_productos_proveedores.TabIndex = 9;
            btn_f6_productos_proveedores.Text = "F6 - Proveedores";
            btn_f6_productos_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f5_pagos_proveedores
            // 
            btn_f5_pagos_proveedores.BackColor = Color.FromArgb(32, 201, 151);
            btn_f5_pagos_proveedores.FlatAppearance.BorderSize = 0;
            btn_f5_pagos_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f5_pagos_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f5_pagos_proveedores.ForeColor = Color.White;
            btn_f5_pagos_proveedores.Location = new Point(740, 25);
            btn_f5_pagos_proveedores.Margin = new Padding(4);
            btn_f5_pagos_proveedores.Name = "btn_f5_pagos_proveedores";
            btn_f5_pagos_proveedores.Size = new Size(150, 60);
            btn_f5_pagos_proveedores.TabIndex = 8;
            btn_f5_pagos_proveedores.Text = "F5 - Pagos";
            btn_f5_pagos_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f4_compras_proveedores
            // 
            btn_f4_compras_proveedores.BackColor = Color.FromArgb(255, 193, 7);
            btn_f4_compras_proveedores.FlatAppearance.BorderSize = 0;
            btn_f4_compras_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f4_compras_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f4_compras_proveedores.ForeColor = Color.White;
            btn_f4_compras_proveedores.Location = new Point(560, 25);
            btn_f4_compras_proveedores.Margin = new Padding(4);
            btn_f4_compras_proveedores.Name = "btn_f4_compras_proveedores";
            btn_f4_compras_proveedores.Size = new Size(150, 60);
            btn_f4_compras_proveedores.TabIndex = 7;
            btn_f4_compras_proveedores.Text = "F4 - Historial";
            btn_f4_compras_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f3_eliminar_proveedores
            // 
            btn_f3_eliminar_proveedores.BackColor = Color.FromArgb(220, 53, 69);
            btn_f3_eliminar_proveedores.FlatAppearance.BorderSize = 0;
            btn_f3_eliminar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f3_eliminar_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f3_eliminar_proveedores.ForeColor = Color.White;
            btn_f3_eliminar_proveedores.Location = new Point(380, 25);
            btn_f3_eliminar_proveedores.Margin = new Padding(4);
            btn_f3_eliminar_proveedores.Name = "btn_f3_eliminar_proveedores";
            btn_f3_eliminar_proveedores.Size = new Size(150, 60);
            btn_f3_eliminar_proveedores.TabIndex = 6;
            btn_f3_eliminar_proveedores.Text = "F3 - Eliminar";
            btn_f3_eliminar_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_f2_modificar_proveedores
            // 
            btn_f2_modificar_proveedores.BackColor = Color.FromArgb(23, 162, 184);
            btn_f2_modificar_proveedores.FlatAppearance.BorderSize = 0;
            btn_f2_modificar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_f2_modificar_proveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_f2_modificar_proveedores.ForeColor = Color.White;
            btn_f2_modificar_proveedores.Location = new Point(200, 25);
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
            btn_f1_agregar_proveedores.Location = new Point(20, 25);
            btn_f1_agregar_proveedores.Margin = new Padding(4);
            btn_f1_agregar_proveedores.Name = "btn_f1_agregar_proveedores";
            btn_f1_agregar_proveedores.Size = new Size(150, 60);
            btn_f1_agregar_proveedores.TabIndex = 4;
            btn_f1_agregar_proveedores.Text = "F1 - Nueva Compra";
            btn_f1_agregar_proveedores.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1300, 70);
            panelHeader.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(550, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 45);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Compras";
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1300, 750);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(btn_regresar_proveedores);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1322, 806);
            Name = "FormCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Compras - POS Refaccionaria";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tc_proveedores.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_reportes_proveedores;
        private Button btn_nuevo_proveedores;
        private ComboBox cb_filtros_proveedores;
        private Label label2;
        private TextBox tb_busqueda_proveedores;
        private Label label1;
        private GroupBox groupBox3;
        private ListView lv_lista_proveedores;
        private GroupBox groupBox4;
        private TabControl tc_proveedores;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button btn_regresar_proveedores;
        private GroupBox groupBox1;
        private Button btn_f6_productos_proveedores;
        private Button btn_f5_pagos_proveedores;
        private Button btn_f4_compras_proveedores;
        private Button btn_f3_eliminar_proveedores;
        private Button btn_f2_modificar_proveedores;
        private Button btn_f1_agregar_proveedores;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}