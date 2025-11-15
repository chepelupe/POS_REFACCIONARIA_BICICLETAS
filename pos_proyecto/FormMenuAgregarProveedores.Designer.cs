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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            cb_categoria = new ComboBox();
            btn_agregar = new Button();
            txb_cantidad = new TextBox();
            txb_nombre = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cb_categoria);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(txb_cantidad);
            groupBox1.Controls.Add(txb_nombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(718, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del proveedor a agregar";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 15;
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
            // textBox1
            // 
            textBox1.Location = new Point(194, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 13;
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
            // txb_cantidad
            // 
            txb_cantidad.Location = new Point(194, 199);
            txb_cantidad.Name = "txb_cantidad";
            txb_cantidad.Size = new Size(150, 31);
            txb_cantidad.TabIndex = 8;
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
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 367);
            panel1.TabIndex = 3;
            // 
            // FormMenuAgregarProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FormMenuAgregarProveedores";
            Text = "FormAgregarProveedores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cb_categoria;
        private Button btn_agregar;
        private TextBox txb_cantidad;
        private TextBox txb_nombre;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Panel panel1;
    }
}