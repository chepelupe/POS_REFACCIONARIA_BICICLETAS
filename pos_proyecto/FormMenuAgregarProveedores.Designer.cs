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
            panel1 = new Panel();
            btn_agregar_categoria_proveedores = new Button();
            btn_agregar_proveedor_proveedores = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(306, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 408);
            panel1.TabIndex = 3;
            // 
            // btn_agregar_categoria_proveedores
            // 
            btn_agregar_categoria_proveedores.Location = new Point(78, 210);
            btn_agregar_categoria_proveedores.Name = "btn_agregar_categoria_proveedores";
            btn_agregar_categoria_proveedores.Size = new Size(171, 77);
            btn_agregar_categoria_proveedores.TabIndex = 4;
            btn_agregar_categoria_proveedores.Text = "Agregar Categoría";
            btn_agregar_categoria_proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_proveedor_proveedores
            // 
            btn_agregar_proveedor_proveedores.Location = new Point(78, 108);
            btn_agregar_proveedor_proveedores.Name = "btn_agregar_proveedor_proveedores";
            btn_agregar_proveedor_proveedores.Size = new Size(171, 77);
            btn_agregar_proveedor_proveedores.TabIndex = 5;
            btn_agregar_proveedor_proveedores.Text = "Agregar Proveedor";
            btn_agregar_proveedor_proveedores.UseVisualStyleBackColor = true;
            // 
            // FormMenuAgregarProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 450);
            Controls.Add(btn_agregar_proveedor_proveedores);
            Controls.Add(btn_agregar_categoria_proveedores);
            Controls.Add(panel1);
            Name = "FormMenuAgregarProveedores";
            Text = "FormAgregarProveedores";
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btn_agregar_categoria_proveedores;
        private Button btn_agregar_proveedor_proveedores;
    }
}