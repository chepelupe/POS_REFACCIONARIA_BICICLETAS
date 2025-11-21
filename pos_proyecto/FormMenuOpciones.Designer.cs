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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuOpciones));
            btn_inventario = new Button();
            btn_proveedores = new Button();
            btn_ventas = new Button();
            btn_salir = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panel1 = new Panel();
            btn_reportes = new Button();
            btn_clientes = new Button();
            btn_empleados = new Button();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_inventario
            // 
            btn_inventario.BackColor = Color.FromArgb(40, 167, 69);
            btn_inventario.FlatAppearance.BorderSize = 0;
            btn_inventario.FlatStyle = FlatStyle.Flat;
            btn_inventario.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inventario.ForeColor = Color.White;
            btn_inventario.Image = (Image)resources.GetObject("btn_inventario.Image");
            btn_inventario.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inventario.Location = new Point(50, 30);
            btn_inventario.Margin = new Padding(4);
            btn_inventario.Name = "btn_inventario";
            btn_inventario.Size = new Size(300, 70);
            btn_inventario.TabIndex = 0;
            btn_inventario.Text = "Módulo Inventario";
            btn_inventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_inventario.UseVisualStyleBackColor = false;
            // 
            // btn_proveedores
            // 
            btn_proveedores.BackColor = Color.FromArgb(255, 193, 7);
            btn_proveedores.FlatAppearance.BorderSize = 0;
            btn_proveedores.FlatStyle = FlatStyle.Flat;
            btn_proveedores.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_proveedores.ForeColor = Color.White;
            btn_proveedores.Image = (Image)resources.GetObject("btn_proveedores.Image");
            btn_proveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btn_proveedores.Location = new Point(50, 120);
            btn_proveedores.Margin = new Padding(4);
            btn_proveedores.Name = "btn_proveedores";
            btn_proveedores.Size = new Size(300, 70);
            btn_proveedores.TabIndex = 1;
            btn_proveedores.Text = "Módulo Proveedores";
            btn_proveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_ventas
            // 
            btn_ventas.BackColor = Color.FromArgb(0, 122, 204);
            btn_ventas.FlatAppearance.BorderSize = 0;
            btn_ventas.FlatStyle = FlatStyle.Flat;
            btn_ventas.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ventas.ForeColor = Color.White;
            btn_ventas.Image = (Image)resources.GetObject("btn_ventas.Image");
            btn_ventas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ventas.Location = new Point(50, 300);
            btn_ventas.Margin = new Padding(4);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(300, 70);
            btn_ventas.TabIndex = 2;
            btn_ventas.Text = "Regresar a Ventas";
            btn_ventas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(220, 53, 69);
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir.ForeColor = Color.White;
            btn_salir.Image = (Image)resources.GetObject("btn_salir.Image");
            btn_salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir.Location = new Point(50, 390);
            btn_salir.Margin = new Padding(4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(300, 70);
            btn_salir.TabIndex = 3;
            btn_salir.Text = "Salir del Sistema";
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(400, 80);
            panelHeader.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(120, 20);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(160, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Módulos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_empleados);
            panel1.Controls.Add(btn_clientes);
            panel1.Controls.Add(btn_reportes);
            panel1.Controls.Add(btn_inventario);
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(btn_proveedores);
            panel1.Controls.Add(btn_ventas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 80);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 520);
            panel1.TabIndex = 5;
            // 
            // btn_reportes
            // 
            btn_reportes.BackColor = Color.FromArgb(111, 66, 193);
            btn_reportes.FlatAppearance.BorderSize = 0;
            btn_reportes.FlatStyle = FlatStyle.Flat;
            btn_reportes.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reportes.ForeColor = Color.White;
            btn_reportes.Image = (Image)resources.GetObject("btn_reportes.Image");
            btn_reportes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reportes.Location = new Point(50, 210);
            btn_reportes.Margin = new Padding(4);
            btn_reportes.Name = "btn_reportes";
            btn_reportes.Size = new Size(300, 70);
            btn_reportes.TabIndex = 4;
            btn_reportes.Text = "Módulo Reportes";
            btn_reportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_reportes.UseVisualStyleBackColor = false;
            // 
            // btn_clientes
            // 
            btn_clientes.BackColor = Color.FromArgb(23, 162, 184);
            btn_clientes.FlatAppearance.BorderSize = 0;
            btn_clientes.FlatStyle = FlatStyle.Flat;
            btn_clientes.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clientes.ForeColor = Color.White;
            btn_clientes.Image = (Image)resources.GetObject("btn_clientes.Image");
            btn_clientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clientes.Location = new Point(50, 480);
            btn_clientes.Margin = new Padding(4);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(300, 70);
            btn_clientes.TabIndex = 5;
            btn_clientes.Text = "Módulo Clientes";
            btn_clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_empleados
            // 
            btn_empleados.BackColor = Color.FromArgb(108, 117, 125);
            btn_empleados.FlatAppearance.BorderSize = 0;
            btn_empleados.FlatStyle = FlatStyle.Flat;
            btn_empleados.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_empleados.ForeColor = Color.White;
            btn_empleados.Image = (Image)resources.GetObject("btn_empleados.Image");
            btn_empleados.ImageAlign = ContentAlignment.MiddleLeft;
            btn_empleados.Location = new Point(50, 570);
            btn_empleados.Margin = new Padding(4);
            btn_empleados.Name = "btn_empleados";
            btn_empleados.Size = new Size(300, 70);
            btn_empleados.TabIndex = 6;
            btn_empleados.Text = "Módulo Empleados";
            btn_empleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_empleados.UseVisualStyleBackColor = false;
            // 
            // FormMenuOpciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(400, 600);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
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

        private Button btn_inventario;
        private Button btn_proveedores;
        private Button btn_ventas;
        private Button btn_salir;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panel1;
        private Button btn_reportes;
        private Button btn_empleados;
        private Button btn_clientes;
    }
}