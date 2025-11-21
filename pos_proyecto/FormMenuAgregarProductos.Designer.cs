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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAgregarProductos));
            groupBox1 = new GroupBox();
            btnAgregarCat = new Button();
            btnAgregarPro = new Button();
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
            groupBox1.Controls.Add(btnAgregarCat);
            groupBox1.Controls.Add(btnAgregarPro);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 80);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(250, 500);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones de Agregar";
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.BackColor = Color.FromArgb(111, 66, 193);
            btnAgregarCat.FlatAppearance.BorderSize = 0;
            btnAgregarCat.FlatStyle = FlatStyle.Flat;
            btnAgregarCat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCat.ForeColor = Color.White;
            btnAgregarCat.Image = (Image)resources.GetObject("btnAgregarCat.Image");
            btnAgregarCat.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarCat.Location = new Point(25, 180);
            btnAgregarCat.Margin = new Padding(4);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(200, 70);
            btnAgregarCat.TabIndex = 1;
            btnAgregarCat.Text = "Agregar Categoría";
            btnAgregarCat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarCat.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPro
            // 
            btnAgregarPro.BackColor = Color.FromArgb(0, 122, 204);
            btnAgregarPro.FlatAppearance.BorderSize = 0;
            btnAgregarPro.FlatStyle = FlatStyle.Flat;
            btnAgregarPro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPro.ForeColor = Color.White;
            btnAgregarPro.Image = (Image)resources.GetObject("btnAgregarPro.Image");
            btnAgregarPro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarPro.Location = new Point(25, 80);
            btnAgregarPro.Margin = new Padding(4);
            btnAgregarPro.Name = "btnAgregarPro";
            btnAgregarPro.Size = new Size(200, 70);
            btnAgregarPro.TabIndex = 0;
            btnAgregarPro.Text = "Agregar Producto";
            btnAgregarPro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarPro.UseVisualStyleBackColor = false;
            // 
            // PanelProCat
            // 
            PanelProCat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelProCat.BackColor = Color.White;
            PanelProCat.BorderStyle = BorderStyle.FixedSingle;
            PanelProCat.Location = new Point(300, 80);
            PanelProCat.Margin = new Padding(4);
            PanelProCat.Name = "PanelProCat";
            PanelProCat.Size = new Size(850, 500);
            PanelProCat.TabIndex = 1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 70);
            panelHeader.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(450, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(284, 45);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Agregar Productos";
            // 
            // FormMenuAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1184, 600);
            Controls.Add(lblTitulo);
            Controls.Add(panelHeader);
            Controls.Add(PanelProCat);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1206, 656);
            Name = "FormMenuAgregarProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Productos - POS Refaccionaria";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAgregarCat;
        private Button btnAgregarPro;
        private Panel PanelProCat;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}