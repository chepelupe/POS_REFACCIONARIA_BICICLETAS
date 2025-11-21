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
            pnl_proveedores = new Panel();
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
            // pnl_proveedores
            // 
            pnl_proveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_proveedores.BackColor = Color.White;
            pnl_proveedores.BorderStyle = BorderStyle.FixedSingle;
            pnl_proveedores.Location = new Point(245, 48);
            pnl_proveedores.Margin = new Padding(3, 2, 3, 2);
            pnl_proveedores.Name = "pnl_proveedores";
            pnl_proveedores.Size = new Size(491, 331);
            pnl_proveedores.TabIndex = 3;
            // 
            // btn_agregar_categoria_proveedores
            // 
            btn_agregar_categoria_proveedores.BackColor = Color.FromArgb(111, 66, 193);
            btn_agregar_categoria_proveedores.FlatAppearance.BorderSize = 0;
            btn_agregar_categoria_proveedores.FlatStyle = FlatStyle.Flat;
            btn_agregar_categoria_proveedores.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_categoria_proveedores.ForeColor = Color.White;
            btn_agregar_categoria_proveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_categoria_proveedores.Location = new Point(35, 108);
            btn_agregar_categoria_proveedores.Margin = new Padding(3, 2, 3, 2);
            btn_agregar_categoria_proveedores.Name = "btn_agregar_categoria_proveedores";
            btn_agregar_categoria_proveedores.Size = new Size(175, 42);
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
            btn_agregar_proveedor_proveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_proveedor_proveedores.Location = new Point(35, 48);
            btn_agregar_proveedor_proveedores.Margin = new Padding(3, 2, 3, 2);
            btn_agregar_proveedor_proveedores.Name = "btn_agregar_proveedor_proveedores";
            btn_agregar_proveedor_proveedores.Size = new Size(175, 42);
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
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(756, 42);
            panelHeader.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(280, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 30);
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
            panelMenu.Location = new Point(0, 42);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(246, 337);
            panelMenu.TabIndex = 7;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccion.ForeColor = Color.FromArgb(45, 45, 48);
            lblSeleccion.Location = new Point(35, 18);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(186, 21);
            lblSeleccion.TabIndex = 6;
            lblSeleccion.Text = "Seleccione una opción:";
            // 
            // FormMenuAgregarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(756, 388);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Controls.Add(pnl_proveedores);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(772, 427);
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
        private Panel pnl_proveedores;
        private Button btn_agregar_categoria_proveedores;
        private Button btn_agregar_proveedor_proveedores;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelMenu;
        private Label lblSeleccion;
    }
}