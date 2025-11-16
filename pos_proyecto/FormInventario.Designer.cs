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
            btn_agregar = new Button();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listaInventario).BeginInit();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(41, 40);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 34);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(188, 40);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 34);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(335, 40);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(120, 34);
            btn_modificar.TabIndex = 3;
            btn_modificar.Text = "MODIFICAR";
            btn_modificar.UseVisualStyleBackColor = true;
            // 
            // tb_abuscar
            // 
            tb_abuscar.Location = new Point(161, 50);
            tb_abuscar.Name = "tb_abuscar";
            tb_abuscar.Size = new Size(150, 31);
            tb_abuscar.TabIndex = 4;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(15, 50);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(112, 34);
            btn_buscar.TabIndex = 5;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(btn_modificar);
            groupBox1.Location = new Point(64, 365);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 108);
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
            groupBox2.Location = new Point(893, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 189);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 95);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 7;
            label1.Text = "Buscar por:";
            // 
            // cb_categoria_busqueda
            // 
            cb_categoria_busqueda.FormattingEnabled = true;
            cb_categoria_busqueda.Location = new Point(161, 92);
            cb_categoria_busqueda.Name = "cb_categoria_busqueda";
            cb_categoria_busqueda.Size = new Size(150, 33);
            cb_categoria_busqueda.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(1107, 551);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgv_listaInventario
            // 
            dgv_listaInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaInventario.Location = new Point(25, 14);
            dgv_listaInventario.Name = "dgv_listaInventario";
            dgv_listaInventario.RowHeadersWidth = 62;
            dgv_listaInventario.Size = new Size(862, 345);
            dgv_listaInventario.TabIndex = 11;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 618);
            Controls.Add(dgv_listaInventario);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormInventario";
            Text = "Inventario";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listaInventario).EndInit();
            ResumeLayout(false);

            // Asignar eventos en el diseñador
            btn_agregar.Click += new System.EventHandler(btn_agregar_Click);
            btn_eliminar.Click += new System.EventHandler(btn_eliminar_Click);
            btn_modificar.Click += new System.EventHandler(btn_modificar_Click);
            btn_buscar.Click += new System.EventHandler(btn_buscar_Click);
            button1.Click += new System.EventHandler(button1_Click);
            tb_abuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_abuscar_KeyPress);
            cb_categoria_busqueda.SelectedIndexChanged += new System.EventHandler(cb_categoria_busqueda_SelectedIndexChanged);
            dgv_listaInventario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(dgv_listaInventario_CellEndEdit);
        }

        #endregion
        private Button btn_agregar;
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
    }
}