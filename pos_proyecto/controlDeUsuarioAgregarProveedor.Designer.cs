namespace pos_proyecto
{
    partial class ControlDeUsuarioAgregarProveedor
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
            txb_telefono = new TextBox();
            label7 = new Label();
            txb_rfc = new TextBox();
            label6 = new Label();
            cb_categoria = new ComboBox();
            btn_agregar = new Button();
            txb_correo = new TextBox();
            txb_nombre = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txb_telefono);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txb_rfc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cb_categoria);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(txb_correo);
            groupBox1.Controls.Add(txb_nombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 426);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del proveedor a agregar";
            // 
            // txb_telefono
            // 
            txb_telefono.Location = new Point(194, 148);
            txb_telefono.Name = "txb_telefono";
            txb_telefono.Size = new Size(150, 31);
            txb_telefono.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 148);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 14;
            label7.Text = "Teléfono:";
            // 
            // txb_rfc
            // 
            txb_rfc.Location = new Point(194, 96);
            txb_rfc.Name = "txb_rfc";
            txb_rfc.Size = new Size(150, 31);
            txb_rfc.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 96);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 12;
            label6.Text = "RFC:";
            // 
            // cb_categoria
            // 
            cb_categoria.FormattingEnabled = true;
            cb_categoria.Location = new Point(194, 248);
            cb_categoria.Name = "cb_categoria";
            cb_categoria.Size = new Size(150, 33);
            cb_categoria.TabIndex = 11;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(117, 356);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(164, 64);
            btn_agregar.TabIndex = 10;
            btn_agregar.Text = "Agregar proveedor";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txb_correo
            // 
            txb_correo.Location = new Point(194, 199);
            txb_correo.Name = "txb_correo";
            txb_correo.Size = new Size(150, 31);
            txb_correo.TabIndex = 8;
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(194, 46);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.Size = new Size(150, 31);
            txb_nombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 199);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 3;
            label4.Text = "Correo Electrónico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 251);
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
            // ControlDeUsuarioAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ControlDeUsuarioAgregarProveedor";
            Size = new Size(405, 431);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txb_telefono;
        private Label label7;
        private TextBox txb_rfc;
        private Label label6;
        private ComboBox cb_categoria;
        private Button btn_agregar;
        private TextBox txb_correo;
        private TextBox txb_nombre;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}
