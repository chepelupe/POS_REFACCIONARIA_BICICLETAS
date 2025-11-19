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
            btn_regresar_proveedores = new Button();
            groupBox4 = new GroupBox();
            tc_proveedores = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            groupBox3 = new GroupBox();
            lv_lista_proveedores = new ListView();
            groupBox2 = new GroupBox();
            btn_reportes_proveedores = new Button();
            btn_nuevo_proveedores = new Button();
            cb_filtros_proveedores = new ComboBox();
            label2 = new Label();
            tb_busqueda_proveedores = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_f6_productos_proveedores = new Button();
            btn_f5_pagos_proveedores = new Button();
            btn_f4_compras_proveedores = new Button();
            btn_f3_eliminar_proveedores = new Button();
            btn_f2_modificar_proveedores = new Button();
            btn_f1_agregar_proveedores = new Button();
            groupBox4.SuspendLayout();
            tc_proveedores.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_regresar_proveedores
            // 
            btn_regresar_proveedores.Location = new Point(781, 326);
            btn_regresar_proveedores.Margin = new Padding(2);
            btn_regresar_proveedores.Name = "btn_regresar_proveedores";
            btn_regresar_proveedores.Size = new Size(92, 59);
            btn_regresar_proveedores.TabIndex = 15;
            btn_regresar_proveedores.Text = "Regresar";
            btn_regresar_proveedores.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tc_proveedores);
            groupBox4.Location = new Point(249, 72);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(509, 220);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detalles Clientes";
            // 
            // tc_proveedores
            // 
            tc_proveedores.Controls.Add(tabPage1);
            tc_proveedores.Controls.Add(tabPage2);
            tc_proveedores.Controls.Add(tabPage3);
            tc_proveedores.Controls.Add(tabPage4);
            tc_proveedores.Controls.Add(tabPage5);
            tc_proveedores.Controls.Add(tabPage6);
            tc_proveedores.Location = new Point(4, 18);
            tc_proveedores.Margin = new Padding(2);
            tc_proveedores.Name = "tc_proveedores";
            tc_proveedores.SelectedIndex = 0;
            tc_proveedores.Size = new Size(500, 198);
            tc_proveedores.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(492, 170);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "INFORMACIÓN";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(492, 170);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "COMPRAS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(492, 170);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CRÉDITO";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(492, 170);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "PAGOS";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(492, 170);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "DOCUMENTACIÓN";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Margin = new Padding(2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(492, 170);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "EVALUACIÓN";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lv_lista_proveedores);
            groupBox3.Location = new Point(11, 73);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(210, 219);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista Clientes";
            // 
            // lv_lista_proveedores
            // 
            lv_lista_proveedores.Location = new Point(4, 18);
            lv_lista_proveedores.Margin = new Padding(2);
            lv_lista_proveedores.Name = "lv_lista_proveedores";
            lv_lista_proveedores.Size = new Size(203, 199);
            lv_lista_proveedores.TabIndex = 4;
            lv_lista_proveedores.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_reportes_proveedores);
            groupBox2.Controls.Add(btn_nuevo_proveedores);
            groupBox2.Controls.Add(cb_filtros_proveedores);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tb_busqueda_proveedores);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(11, 11);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(674, 58);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // btn_reportes_proveedores
            // 
            btn_reportes_proveedores.Location = new Point(547, 14);
            btn_reportes_proveedores.Margin = new Padding(2);
            btn_reportes_proveedores.Name = "btn_reportes_proveedores";
            btn_reportes_proveedores.Size = new Size(65, 39);
            btn_reportes_proveedores.TabIndex = 6;
            btn_reportes_proveedores.Text = "Reportes";
            btn_reportes_proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_proveedores
            // 
            btn_nuevo_proveedores.Location = new Point(458, 14);
            btn_nuevo_proveedores.Margin = new Padding(2);
            btn_nuevo_proveedores.Name = "btn_nuevo_proveedores";
            btn_nuevo_proveedores.Size = new Size(65, 39);
            btn_nuevo_proveedores.TabIndex = 5;
            btn_nuevo_proveedores.Text = "Nuevo";
            btn_nuevo_proveedores.UseVisualStyleBackColor = true;
            // 
            // cb_filtros_proveedores
            // 
            cb_filtros_proveedores.FormattingEnabled = true;
            cb_filtros_proveedores.Location = new Point(305, 24);
            cb_filtros_proveedores.Margin = new Padding(2);
            cb_filtros_proveedores.Name = "cb_filtros_proveedores";
            cb_filtros_proveedores.Size = new Size(129, 23);
            cb_filtros_proveedores.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Filtrar:";
            // 
            // tb_busqueda_proveedores
            // 
            tb_busqueda_proveedores.Location = new Point(110, 26);
            tb_busqueda_proveedores.Margin = new Padding(2);
            tb_busqueda_proveedores.Name = "tb_busqueda_proveedores";
            tb_busqueda_proveedores.Size = new Size(106, 23);
            tb_busqueda_proveedores.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_f6_productos_proveedores);
            groupBox1.Controls.Add(btn_f5_pagos_proveedores);
            groupBox1.Controls.Add(btn_f4_compras_proveedores);
            groupBox1.Controls.Add(btn_f3_eliminar_proveedores);
            groupBox1.Controls.Add(btn_f2_modificar_proveedores);
            groupBox1.Controls.Add(btn_f1_agregar_proveedores);
            groupBox1.Location = new Point(11, 308);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(766, 90);
            groupBox1.TabIndex = 11;
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
            btn_f4_compras_proveedores.Text = "F4-Compras";
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
            btn_f1_agregar_proveedores.Text = "F1-Agregar";
            btn_f1_agregar_proveedores.UseVisualStyleBackColor = true;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 408);
            Controls.Add(btn_regresar_proveedores);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormClientes";
            Text = "FormClientes";
            groupBox4.ResumeLayout(false);
            tc_proveedores.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_regresar_proveedores;
        private GroupBox groupBox4;
        private TabControl tc_proveedores;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private GroupBox groupBox3;
        private ListView lv_lista_proveedores;
        private GroupBox groupBox2;
        private Button btn_reportes_proveedores;
        private Button btn_nuevo_proveedores;
        private ComboBox cb_filtros_proveedores;
        private Label label2;
        private TextBox tb_busqueda_proveedores;
        private Label label1;
        private GroupBox groupBox1;
        private Button btn_f6_productos_proveedores;
        private Button btn_f5_pagos_proveedores;
        private Button btn_f4_compras_proveedores;
        private Button btn_f3_eliminar_proveedores;
        private Button btn_f2_modificar_proveedores;
        private Button btn_f1_agregar_proveedores;
    }
}