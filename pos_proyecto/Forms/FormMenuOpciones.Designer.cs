namespace pos_proyecto
{
    partial class FormMenuOpciones
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
            btn_inventario_menu = new Button();
            btn_proveedores_menu = new Button();
            btn_ventas_menu = new Button();
            btn_salir_menu = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panel1 = new Panel();
            btn_empleados_menu = new Button();
            btn_clientes_menu = new Button();
            btn_reportes_menu = new Button();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_inventario_menu
            // 
            btn_inventario_menu.BackColor = Color.FromArgb(40, 167, 69);
            btn_inventario_menu.FlatAppearance.BorderSize = 0;
            btn_inventario_menu.FlatStyle = FlatStyle.Flat;
            btn_inventario_menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inventario_menu.ForeColor = Color.White;
            btn_inventario_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inventario_menu.Location = new Point(35, 18);
            btn_inventario_menu.Margin = new Padding(3, 2, 3, 2);
            btn_inventario_menu.Name = "btn_inventario_menu";
            btn_inventario_menu.Size = new Size(210, 42);
            btn_inventario_menu.TabIndex = 0;
            btn_inventario_menu.Text = "Módulo Inventario";
            btn_inventario_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_inventario_menu.UseVisualStyleBackColor = false;
            // 
            // btn_proveedores_menu
            // 
            btn_proveedores_menu.BackColor = Color.FromArgb(255, 193, 7);
            btn_proveedores_menu.FlatAppearance.BorderSize = 0;
            btn_proveedores_menu.FlatStyle = FlatStyle.Flat;
            btn_proveedores_menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_proveedores_menu.ForeColor = Color.White;
            btn_proveedores_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_proveedores_menu.Location = new Point(35, 72);
            btn_proveedores_menu.Margin = new Padding(3, 2, 3, 2);
            btn_proveedores_menu.Name = "btn_proveedores_menu";
            btn_proveedores_menu.Size = new Size(210, 42);
            btn_proveedores_menu.TabIndex = 1;
            btn_proveedores_menu.Text = "Módulo Proveedores";
            btn_proveedores_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_proveedores_menu.UseVisualStyleBackColor = false;
            // 
            // btn_ventas_menu
            // 
            btn_ventas_menu.BackColor = Color.FromArgb(0, 122, 204);
            btn_ventas_menu.FlatAppearance.BorderSize = 0;
            btn_ventas_menu.FlatStyle = FlatStyle.Flat;
            btn_ventas_menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ventas_menu.ForeColor = Color.White;
            btn_ventas_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ventas_menu.Location = new Point(35, 180);
            btn_ventas_menu.Margin = new Padding(3, 2, 3, 2);
            btn_ventas_menu.Name = "btn_ventas_menu";
            btn_ventas_menu.Size = new Size(210, 42);
            btn_ventas_menu.TabIndex = 2;
            btn_ventas_menu.Text = "Regresar a Ventas";
            btn_ventas_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ventas_menu.UseVisualStyleBackColor = false;
            // 
            // btn_salir_menu
            // 
            btn_salir_menu.BackColor = Color.FromArgb(220, 53, 69);
            btn_salir_menu.FlatAppearance.BorderSize = 0;
            btn_salir_menu.FlatStyle = FlatStyle.Flat;
            btn_salir_menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir_menu.ForeColor = Color.White;
            btn_salir_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir_menu.Location = new Point(35, 234);
            btn_salir_menu.Margin = new Padding(3, 2, 3, 2);
            btn_salir_menu.Name = "btn_salir_menu";
            btn_salir_menu.Size = new Size(210, 42);
            btn_salir_menu.TabIndex = 3;
            btn_salir_menu.Text = "Salir del Sistema";
            btn_salir_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir_menu.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(280, 48);
            panelHeader.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(84, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Módulos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_empleados_menu);
            panel1.Controls.Add(btn_clientes_menu);
            panel1.Controls.Add(btn_reportes_menu);
            panel1.Controls.Add(btn_inventario_menu);
            panel1.Controls.Add(btn_salir_menu);
            panel1.Controls.Add(btn_proveedores_menu);
            panel1.Controls.Add(btn_ventas_menu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 48);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 391);
            panel1.TabIndex = 5;
            // 
            // btn_empleados_menu
            // 
            btn_empleados_menu.BackColor = Color.FromArgb(108, 117, 125);
            btn_empleados_menu.FlatAppearance.BorderSize = 0;
            btn_empleados_menu.FlatStyle = FlatStyle.Flat;
            btn_empleados_menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_empleados_menu.ForeColor = Color.White;
            btn_empleados_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_empleados_menu.Location = new Point(35, 342);
            btn_empleados_menu.Margin = new Padding(3, 2, 3, 2);
            btn_empleados_menu.Name = "btn_empleados_menu";
            btn_empleados_menu.Size = new Size(210, 42);
            btn_empleados_menu.TabIndex = 6;
            btn_empleados_menu.Text = "Módulo Empleados";
            btn_empleados_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_empleados_menu.UseVisualStyleBackColor = false;
            // 
            // btn_clientes_menu
            // 
            btn_clientes_menu.BackColor = Color.FromArgb(23, 162, 184);
            btn_clientes_menu.FlatAppearance.BorderSize = 0;
            btn_clientes_menu.FlatStyle = FlatStyle.Flat;
            btn_clientes_menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clientes_menu.ForeColor = Color.White;
            btn_clientes_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clientes_menu.Location = new Point(35, 288);
            btn_clientes_menu.Margin = new Padding(3, 2, 3, 2);
            btn_clientes_menu.Name = "btn_clientes_menu";
            btn_clientes_menu.Size = new Size(210, 42);
            btn_clientes_menu.TabIndex = 5;
            btn_clientes_menu.Text = "Módulo Clientes";
            btn_clientes_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_clientes_menu.UseVisualStyleBackColor = false;
            // 
            // btn_reportes_menu
            // 
            btn_reportes_menu.BackColor = Color.FromArgb(111, 66, 193);
            btn_reportes_menu.FlatAppearance.BorderSize = 0;
            btn_reportes_menu.FlatStyle = FlatStyle.Flat;
            btn_reportes_menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reportes_menu.ForeColor = Color.White;
            btn_reportes_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reportes_menu.Location = new Point(35, 126);
            btn_reportes_menu.Margin = new Padding(3, 2, 3, 2);
            btn_reportes_menu.Name = "btn_reportes_menu";
            btn_reportes_menu.Size = new Size(210, 42);
            btn_reportes_menu.TabIndex = 4;
            btn_reportes_menu.Text = "Módulo Reportes";
            btn_reportes_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_reportes_menu.UseVisualStyleBackColor = false;
            // 
            // FormMenuOpciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(280, 439);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuOpciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú de Módulos - POS Refaccionaria";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_inventario_menu;
        private Button btn_proveedores_menu;
        private Button btn_ventas_menu;
        private Button btn_salir_menu;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panel1;
        private Button btn_reportes_menu;
        private Button btn_empleados_menu;
        private Button btn_clientes_menu;
    }
}