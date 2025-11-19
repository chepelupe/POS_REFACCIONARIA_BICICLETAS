namespace pos_proyecto
{
    partial class FormInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_eliminar = new Button();
            btn_modificar = new Button();
            tb_abuscar = new TextBox();
            btn_buscar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            cb_categoria_busqueda = new ComboBox();
            button1 = new Button();
            dgv_listaInventario = new DataGridView();
            btn_agregar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listaInventario).BeginInit();
            SuspendLayout();
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(132, 24);
            btn_eliminar.Margin = new Padding(2, 2, 2, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(78, 20);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(234, 24);
            btn_modificar.Margin = new Padding(2, 2, 2, 2);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(84, 20);
            btn_modificar.TabIndex = 3;
            btn_modificar.Text = "MODIFICAR";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // tb_abuscar
            // 
            tb_abuscar.Location = new Point(113, 30);
            tb_abuscar.Margin = new Padding(2, 2, 2, 2);
            tb_abuscar.Name = "tb_abuscar";
            tb_abuscar.Size = new Size(106, 23);
            tb_abuscar.TabIndex = 4;
            tb_abuscar.KeyPress += tb_abuscar_KeyPress;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(10, 30);
            btn_buscar.Margin = new Padding(2, 2, 2, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(78, 20);
            btn_buscar.TabIndex = 5;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(btn_modificar);
            groupBox1.Location = new Point(45, 219);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(344, 65);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cb_categoria_busqueda);
            groupBox2.Controls.Add(tb_abuscar);
            groupBox2.Controls.Add(btn_buscar);
            groupBox2.Location = new Point(625, 19);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(228, 113);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 7;
            label1.Text = "Buscar por:";
            // 
            // cb_categoria_busqueda
            // 
            cb_categoria_busqueda.FormattingEnabled = true;
            cb_categoria_busqueda.Location = new Point(113, 55);
            cb_categoria_busqueda.Margin = new Padding(2, 2, 2, 2);
            cb_categoria_busqueda.Name = "cb_categoria_busqueda";
            cb_categoria_busqueda.Size = new Size(106, 23);
            cb_categoria_busqueda.TabIndex = 6;
            cb_categoria_busqueda.SelectedIndexChanged += cb_categoria_busqueda_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(775, 331);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 8;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgv_listaInventario
            // 
            dgv_listaInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaInventario.Location = new Point(18, 8);
            dgv_listaInventario.Margin = new Padding(2, 2, 2, 2);
            dgv_listaInventario.Name = "dgv_listaInventario";
            dgv_listaInventario.RowHeadersWidth = 62;
            dgv_listaInventario.Size = new Size(603, 207);
            dgv_listaInventario.TabIndex = 11;
            dgv_listaInventario.CellEndEdit += dgv_listaInventario_CellEndEdit;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(29, 24);
            btn_agregar.Margin = new Padding(2);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(78, 20);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 371);
            Controls.Add(dgv_listaInventario);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormInventario";
            Text = "Inventario";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listaInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_eliminar;
        private Button btn_modificar;
        private TextBox tb_abuscar;
        private Button btn_buscar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cb_categoria_busqueda;
        private Button button1;
        private DataGridView dgv_listaInventario;
        private Button btn_agregar;
    }
}