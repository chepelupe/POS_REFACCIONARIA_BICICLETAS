namespace pos_proyecto
{
    partial class controlDeUsuarioProductosCategorias
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
            gbCat = new GroupBox();
            lblEstatus = new Label();
            cb_estatus_catproductos = new ComboBox();
            btn_modificarCat_catproductos = new Button();
            btn_eliminarCat_catproductos = new Button();
            btn_agregarCat_catproductos = new Button();
            cb_eliminarCat_catproductos = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txt_nombreCat__catproductos = new TextBox();
            gbCat.SuspendLayout();
            SuspendLayout();
            // 
            // gbCat
            // 
            gbCat.Controls.Add(lblEstatus);
            gbCat.Controls.Add(cb_estatus_catproductos);
            gbCat.Controls.Add(btn_modificarCat_catproductos);
            gbCat.Controls.Add(btn_eliminarCat_catproductos);
            gbCat.Controls.Add(btn_agregarCat_catproductos);
            gbCat.Controls.Add(cb_eliminarCat_catproductos);
            gbCat.Controls.Add(label2);
            gbCat.Controls.Add(label1);
            gbCat.Controls.Add(txt_nombreCat__catproductos);
            gbCat.Location = new Point(2, 2);
            gbCat.Margin = new Padding(2, 2, 2, 2);
            gbCat.Name = "gbCat";
            gbCat.Padding = new Padding(2, 2, 2, 2);
            gbCat.Size = new Size(350, 210);
            gbCat.TabIndex = 0;
            gbCat.TabStop = false;
            gbCat.Text = "Gestión de Categorías de Productos";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(15, 90);
            lblEstatus.Margin = new Padding(2, 0, 2, 0);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(47, 15);
            lblEstatus.TabIndex = 8;
            lblEstatus.Text = "Estatus:";
            // 
            // cb_estatus_catproductos
            // 
            cb_estatus_catproductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estatus_catproductos.FormattingEnabled = true;
            cb_estatus_catproductos.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cb_estatus_catproductos.Location = new Point(129, 88);
            cb_estatus_catproductos.Margin = new Padding(2, 2, 2, 2);
            cb_estatus_catproductos.Name = "cb_estatus_catproductos";
            cb_estatus_catproductos.Size = new Size(162, 23);
            cb_estatus_catproductos.TabIndex = 7;
            // 
            // btn_modificarCat_catproductos
            // 
            btn_modificarCat_catproductos.BackColor = Color.LightYellow;
            btn_modificarCat_catproductos.Location = new Point(229, 150);
            btn_modificarCat_catproductos.Margin = new Padding(2, 2, 2, 2);
            btn_modificarCat_catproductos.Name = "btn_modificarCat_catproductos";
            btn_modificarCat_catproductos.Size = new Size(84, 36);
            btn_modificarCat_catproductos.TabIndex = 6;
            btn_modificarCat_catproductos.Text = "Modificar";
            btn_modificarCat_catproductos.UseVisualStyleBackColor = false;
            btn_modificarCat_catproductos.Click += btnModificarCat_Click;
            // 
            // btn_eliminarCat_catproductos
            // 
            btn_eliminarCat_catproductos.BackColor = Color.LightCoral;
            btn_eliminarCat_catproductos.Location = new Point(129, 150);
            btn_eliminarCat_catproductos.Margin = new Padding(2, 2, 2, 2);
            btn_eliminarCat_catproductos.Name = "btn_eliminarCat_catproductos";
            btn_eliminarCat_catproductos.Size = new Size(84, 36);
            btn_eliminarCat_catproductos.TabIndex = 5;
            btn_eliminarCat_catproductos.Text = "Eliminar";
            btn_eliminarCat_catproductos.UseVisualStyleBackColor = false;
            btn_eliminarCat_catproductos.Click += btnEliminarCat_Click;
            // 
            // btn_agregarCat_catproductos
            // 
            btn_agregarCat_catproductos.BackColor = Color.LightGreen;
            btn_agregarCat_catproductos.Location = new Point(29, 150);
            btn_agregarCat_catproductos.Margin = new Padding(2, 2, 2, 2);
            btn_agregarCat_catproductos.Name = "btn_agregarCat_catproductos";
            btn_agregarCat_catproductos.Size = new Size(84, 36);
            btn_agregarCat_catproductos.TabIndex = 4;
            btn_agregarCat_catproductos.Text = "Agregar";
            btn_agregarCat_catproductos.UseVisualStyleBackColor = false;
            btn_agregarCat_catproductos.Click += button1_Click;
            // 
            // cb_eliminarCat_catproductos
            // 
            cb_eliminarCat_catproductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_eliminarCat_catproductos.FormattingEnabled = true;
            cb_eliminarCat_catproductos.Location = new Point(129, 59);
            cb_eliminarCat_catproductos.Margin = new Padding(2, 2, 2, 2);
            cb_eliminarCat_catproductos.Name = "cb_eliminarCat_catproductos";
            cb_eliminarCat_catproductos.Size = new Size(162, 23);
            cb_eliminarCat_catproductos.TabIndex = 3;
            cb_eliminarCat_catproductos.SelectedIndexChanged += cbEliminarCat_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Seleccionar categoría:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre categoría:";
            // 
            // txt_nombreCat__catproductos
            // 
            txt_nombreCat__catproductos.Location = new Point(129, 29);
            txt_nombreCat__catproductos.Margin = new Padding(2, 2, 2, 2);
            txt_nombreCat__catproductos.Name = "txt_nombreCat__catproductos";
            txt_nombreCat__catproductos.Size = new Size(162, 23);
            txt_nombreCat__catproductos.TabIndex = 0;
            // 
            // controlDeUsuarioProductosCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbCat);
            Margin = new Padding(2, 2, 2, 2);
            Name = "controlDeUsuarioProductosCategorias";
            Size = new Size(357, 216);
            gbCat.ResumeLayout(false);
            gbCat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCat;
        private Button btn_agregarCat_catproductos;
        private ComboBox cb_eliminarCat_catproductos;
        private Label label2;
        private Label label1;
        private TextBox txt_nombreCat__catproductos;
        private Button btn_modificarCat_catproductos;
        private Button btn_eliminarCat_catproductos;
        private ComboBox cb_estatus_catproductos;
        private Label lblEstatus;
    }
}