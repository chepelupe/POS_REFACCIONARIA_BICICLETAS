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
            lb_categorias = new ListBox();
            btn_eliminar = new Button();
            btn_editar = new Button();
            btn_agregar = new Button();
            txb_descripcion = new TextBox();
            label2 = new Label();
            txb_nombre = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_categorias);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(btn_editar);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(txb_descripcion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txb_nombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 500);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de Categorías de Proveedores";
            // 
            // lb_categorias
            // 
            lb_categorias.FormattingEnabled = true;
            lb_categorias.ItemHeight = 25;
            lb_categorias.Location = new Point(20, 250);
            lb_categorias.Name = "lb_categorias";
            lb_categorias.Size = new Size(410, 229);
            lb_categorias.TabIndex = 13;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.LightCoral;
            btn_eliminar.Location = new Point(300, 180);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(120, 45);
            btn_eliminar.TabIndex = 12;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.LightYellow;
            btn_editar.Location = new Point(160, 180);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(120, 45);
            btn_editar.TabIndex = 11;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.LightGreen;
            btn_agregar.Location = new Point(20, 180);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(120, 45);
            btn_agregar.TabIndex = 10;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // txb_descripcion
            // 
            txb_descripcion.Location = new Point(150, 100);
            txb_descripcion.Multiline = true;
            txb_descripcion.Name = "txb_descripcion";
            txb_descripcion.Size = new Size(270, 60);
            txb_descripcion.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 8;
            label2.Text = "Descripción:";
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(150, 50);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.Size = new Size(270, 31);
            txb_nombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 50);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // controlDeUsuarioProveedoresCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "controlDeUsuarioProveedoresCategorias";
            Size = new Size(460, 510);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lb_categorias;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_agregar;
        private TextBox txb_descripcion;
        private Label label2;
        private TextBox txb_nombre;
        private Label label1;
    }
}