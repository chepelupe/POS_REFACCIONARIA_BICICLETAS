namespace pos_proyecto
{
    partial class FormMenuAgregarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAgregarProveedores));
            panel1 = new Panel();
            btn_agregar_categoria_proveedores = new Button();
            btn_agregar_proveedor_proveedores = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelMenu = new Panel();
            lblSeleccion = new Label();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(350, 80);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 550);
            panel1.TabIndex = 3;
            // 
            // btn_agregar_categoria_proveedores
            // 
            btn_agregar_categoria_proveedores.BackColor = Color.FromArgb(111, 66, 193);
            btn_agregar_categoria_proveedores.FlatAppearance.BorderSize = 0;
            btn_agregar_categoria_proveedores.FlatStyle = FlatStyle.Flat;
            btn_agregar_categoria_proveedores.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_categoria_proveedores.ForeColor = Color.White;
            btn_agregar_categoria_proveedores.Image = (Image)resources.GetObject("btn_agregar_categoria_proveedores.Image");
            btn_agregar_categoria_proveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_categoria_proveedores.Location = new Point(50, 180);
            btn_agregar_categoria_proveedores.Margin = new Padding(4);
            btn_agregar_categoria_proveedores.Name = "btn_agregar_categoria_proveedores";
            btn_agregar_categoria_proveedores.Size = new Size(250, 70);
            btn_agregar_categoria_proveedores.TabIndex = 4;
            btn_agregar_categoria_proveedores.Text = "Agregar Categoría";
            btn_agregar_categoria_proveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_agregar_categoria_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_proveedor_proveedores
            // 
            btn_agregar_proveedor_proveedores.BackColor = Color.FromArgb(0, 122, 204);
            btn_agregar_proveedor_proveedores.FlatAppearance.BorderSize = 0;
            btn_agregar_proveedor_proveedores.FlatStyle = FlatStyle.Flat;
            btn_agregar_proveedor_proveedores.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_proveedor_proveedores.ForeColor = Color.White;
            btn_agregar_proveedor_proveedores.Image = (Image)resources.GetObject("btn_agregar_proveedor_proveedores.Image");
            btn_agregar_proveedor_proveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_proveedor_proveedores.Location = new Point(50, 80);
            btn_agregar_proveedor_proveedores.Margin = new Padding(4);
            btn_agregar_proveedor_proveedores.Name = "btn_agregar_proveedor_proveedores";
            btn_agregar_proveedor_proveedores.Size = new Size(250, 70);
            btn_agregar_proveedor_proveedores.TabIndex = 5;
            btn_agregar_proveedor_proveedores.Text = "Agregar Proveedor";
            btn_agregar_proveedor_proveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_agregar_proveedor_proveedores.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1074, 70);
            panelHeader.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(400, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(274, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Proveedor";
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMenu.BackColor = Color.FromArgb(248, 249, 250);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(lblSeleccion);
            panelMenu.Controls.Add(btn_agregar_proveedor_proveedores);
            panelMenu.Controls.Add(btn_agregar_categoria_proveedores);
            panelMenu.Location = new Point(0, 70);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(350, 560);
            panelMenu.TabIndex = 7;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccion.ForeColor = Color.FromArgb(45, 45, 48);
            lblSeleccion.Location = new Point(50, 30);
            lblSeleccion.Margin = new Padding(4, 0, 4, 0);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(250, 32);
            lblSeleccion.TabIndex = 6;
            lblSeleccion.Text = "Seleccione una opción:";
            // 
            // FormMenuAgregarProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1074, 630);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1096, 686);
            Name = "FormMenuAgregarProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Proveedores - POS Refaccionaria";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btn_agregar_categoria_proveedores;
        private Button btn_agregar_proveedor_proveedores;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelMenu;
        private Label lblSeleccion;
    }
}