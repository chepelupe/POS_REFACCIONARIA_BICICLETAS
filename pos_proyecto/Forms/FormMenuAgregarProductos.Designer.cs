namespace pos_proyecto
{
    partial class FormMenuAgregarProductos
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
            groupBox1 = new GroupBox();
            btn_agregar_categoria_productos = new Button();
            btn_agregar_producto_productos = new Button();
            PanelProCat = new Panel();
            panelHeader = new Panel();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btn_agregar_categoria_productos);
            groupBox1.Controls.Add(btn_agregar_producto_productos);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 48);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(175, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones de Agregar";
            // 
            // btn_agregar_categoria_productos
            // 
            btn_agregar_categoria_productos.BackColor = Color.FromArgb(111, 66, 193);
            btn_agregar_categoria_productos.FlatAppearance.BorderSize = 0;
            btn_agregar_categoria_productos.FlatStyle = FlatStyle.Flat;
            btn_agregar_categoria_productos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_categoria_productos.ForeColor = Color.White;
            btn_agregar_categoria_productos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_categoria_productos.Location = new Point(18, 108);
            btn_agregar_categoria_productos.Margin = new Padding(3, 2, 3, 2);
            btn_agregar_categoria_productos.Name = "btn_agregar_categoria_productos";
            btn_agregar_categoria_productos.Size = new Size(140, 46);
            btn_agregar_categoria_productos.TabIndex = 1;
            btn_agregar_categoria_productos.Text = "Agregar Categoría";
            btn_agregar_categoria_productos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_agregar_categoria_productos.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_producto_productos
            // 
            btn_agregar_producto_productos.BackColor = Color.FromArgb(0, 122, 204);
            btn_agregar_producto_productos.FlatAppearance.BorderSize = 0;
            btn_agregar_producto_productos.FlatStyle = FlatStyle.Flat;
            btn_agregar_producto_productos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_producto_productos.ForeColor = Color.White;
            btn_agregar_producto_productos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_producto_productos.Location = new Point(18, 48);
            btn_agregar_producto_productos.Margin = new Padding(3, 2, 3, 2);
            btn_agregar_producto_productos.Name = "btn_agregar_producto_productos";
            btn_agregar_producto_productos.Size = new Size(140, 42);
            btn_agregar_producto_productos.TabIndex = 0;
            btn_agregar_producto_productos.Text = "Agregar Producto";
            btn_agregar_producto_productos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_agregar_producto_productos.UseVisualStyleBackColor = false;
            // 
            // PanelProCat
            // 
            PanelProCat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelProCat.BackColor = Color.White;
            PanelProCat.BorderStyle = BorderStyle.FixedSingle;
            PanelProCat.Location = new Point(210, 48);
            PanelProCat.Margin = new Padding(3, 2, 3, 2);
            PanelProCat.Name = "PanelProCat";
            PanelProCat.Size = new Size(596, 301);
            PanelProCat.TabIndex = 1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(833, 42);
            panelHeader.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(315, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 30);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Agregar Productos";
            // 
            // FormMenuAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(833, 370);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(PanelProCat);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(849, 409);
            Name = "FormMenuAgregarProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Productos - POS Refaccionaria";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_agregar_categoria_productos;
        private Button btn_agregar_producto_productos;
        private Panel PanelProCat;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}