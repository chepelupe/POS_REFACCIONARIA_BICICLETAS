namespace pos_proyecto
{
    partial class controlDeUsuarioAgregarProducto
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
            cb_categoria = new ComboBox();
            btn_agregar = new Button();
            txb_precio = new TextBox();
            txb_cantidad = new TextBox();
            txb_descripcion = new TextBox();
            txb_nombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_categoria);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(txb_precio);
            groupBox1.Controls.Add(txb_cantidad);
            groupBox1.Controls.Add(txb_descripcion);
            groupBox1.Controls.Add(txb_nombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 346);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del producto a agregar";
            // 
            // cb_categoria
            // 
            cb_categoria.FormattingEnabled = true;
            cb_categoria.Location = new Point(194, 93);
            cb_categoria.Name = "cb_categoria";
            cb_categoria.Size = new Size(150, 33);
            cb_categoria.TabIndex = 11;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(114, 306);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(164, 34);
            btn_agregar.TabIndex = 10;
            btn_agregar.Text = "Agregar producto";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // txb_precio
            // 
            txb_precio.Location = new Point(194, 246);
            txb_precio.Name = "txb_precio";
            txb_precio.Size = new Size(150, 31);
            txb_precio.TabIndex = 9;
            // 
            // txb_cantidad
            // 
            txb_cantidad.Location = new Point(194, 196);
            txb_cantidad.Name = "txb_cantidad";
            txb_cantidad.Size = new Size(150, 31);
            txb_cantidad.TabIndex = 8;
            // 
            // txb_descripcion
            // 
            txb_descripcion.Location = new Point(194, 146);
            txb_descripcion.Name = "txb_descripcion";
            txb_descripcion.Size = new Size(150, 31);
            txb_descripcion.TabIndex = 7;
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(194, 46);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.Size = new Size(150, 31);
            txb_nombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 246);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 196);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 146);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 96);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Categoría:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 46);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // controlDeUsuarioAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "controlDeUsuarioAgregarProducto";
            Size = new Size(404, 351);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cb_categoria;
        private Button btn_agregar;
        private TextBox txb_precio;
        private TextBox txb_cantidad;
        private TextBox txb_descripcion;
        private TextBox txb_nombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
