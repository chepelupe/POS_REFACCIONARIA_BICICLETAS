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
            tb_precioVenta = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_precioVenta);
            groupBox1.Controls.Add(label6);
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
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(278, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del producto a agregar";
            // 
            // cb_categoria
            // 
            cb_categoria.FormattingEnabled = true;
            cb_categoria.Location = new Point(136, 56);
            cb_categoria.Margin = new Padding(2, 2, 2, 2);
            cb_categoria.Name = "cb_categoria";
            cb_categoria.Size = new Size(106, 23);
            cb_categoria.TabIndex = 11;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(82, 202);
            btn_agregar.Margin = new Padding(2, 2, 2, 2);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(106, 23);
            btn_agregar.TabIndex = 10;
            btn_agregar.Text = "Agregar producto";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // txb_precio
            // 
            txb_precio.Location = new Point(136, 148);
            txb_precio.Margin = new Padding(2, 2, 2, 2);
            txb_precio.Name = "txb_precio";
            txb_precio.Size = new Size(106, 23);
            txb_precio.TabIndex = 9;
            // 
            // txb_cantidad
            // 
            txb_cantidad.Location = new Point(136, 118);
            txb_cantidad.Margin = new Padding(2, 2, 2, 2);
            txb_cantidad.Name = "txb_cantidad";
            txb_cantidad.Size = new Size(106, 23);
            txb_cantidad.TabIndex = 8;
            // 
            // txb_descripcion
            // 
            txb_descripcion.Location = new Point(136, 88);
            txb_descripcion.Margin = new Padding(2, 2, 2, 2);
            txb_descripcion.Name = "txb_descripcion";
            txb_descripcion.Size = new Size(106, 23);
            txb_descripcion.TabIndex = 7;
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(136, 28);
            txb_nombre.Margin = new Padding(2, 2, 2, 2);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.Size = new Size(106, 23);
            txb_nombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 148);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 118);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Categoría:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // tb_precioVenta
            // 
            tb_precioVenta.Location = new Point(136, 176);
            tb_precioVenta.Margin = new Padding(2);
            tb_precioVenta.Name = "tb_precioVenta";
            tb_precioVenta.Size = new Size(106, 23);
            tb_precioVenta.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 176);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 12;
            label6.Text = "Precio Venta:";
            // 
            // controlDeUsuarioAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "controlDeUsuarioAgregarProducto";
            Size = new Size(283, 237);
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
        private TextBox tb_precioVenta;
        private Label label6;
    }
}
