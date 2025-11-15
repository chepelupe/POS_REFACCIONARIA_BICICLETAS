namespace pos_proyecto
{
    partial class controlDeUsuarioProveedoresCategorias
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_agregar = new Button();
            txb_nombre = new TextBox();
            label1 = new Label();
            lb_categorias = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_categorias);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(txb_nombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 426);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar categoria Proveedor";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(109, 144);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(164, 64);
            btn_agregar.TabIndex = 10;
            btn_agregar.Text = "Agregar categoría";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(194, 46);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.Size = new Size(150, 31);
            txb_nombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 46);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // lb_categorias
            // 
            lb_categorias.FormattingEnabled = true;
            lb_categorias.ItemHeight = 25;
            lb_categorias.Location = new Point(11, 226);
            lb_categorias.Name = "lb_categorias";
            lb_categorias.Size = new Size(358, 179);
            lb_categorias.TabIndex = 11;
            // 
            // controlDeUsuarioProveedoresCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "controlDeUsuarioProveedoresCategorias";
            Size = new Size(406, 440);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_agregar;
        private TextBox txb_nombre;
        private Label label1;
        private ListBox lb_categorias;
    }
}
