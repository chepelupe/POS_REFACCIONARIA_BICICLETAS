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
            lb_categorias_catproveedores = new ListBox();
            btn_eliminar_catproveedores = new Button();
            btn_editar_catproveedores = new Button();
            btn_agregar_catproveedores = new Button();
            txb_descripcion_catproveedores = new TextBox();
            label2 = new Label();
            txb_nombre_catproveedores = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_categorias_catproveedores);
            groupBox1.Controls.Add(btn_eliminar_catproveedores);
            groupBox1.Controls.Add(btn_editar_catproveedores);
            groupBox1.Controls.Add(btn_agregar_catproveedores);
            groupBox1.Controls.Add(txb_descripcion_catproveedores);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txb_nombre_catproveedores);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 2);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(315, 300);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de Categorías de Proveedores";
            // 
            // lb_categorias_catproveedores
            // 
            lb_categorias_catproveedores.FormattingEnabled = true;
            lb_categorias_catproveedores.ItemHeight = 15;
            lb_categorias_catproveedores.Location = new Point(14, 150);
            lb_categorias_catproveedores.Margin = new Padding(2, 2, 2, 2);
            lb_categorias_catproveedores.Name = "lb_categorias_catproveedores";
            lb_categorias_catproveedores.Size = new Size(288, 139);
            lb_categorias_catproveedores.TabIndex = 13;
            // 
            // btn_eliminar_catproveedores
            // 
            btn_eliminar_catproveedores.BackColor = Color.LightCoral;
            btn_eliminar_catproveedores.Location = new Point(210, 108);
            btn_eliminar_catproveedores.Margin = new Padding(2, 2, 2, 2);
            btn_eliminar_catproveedores.Name = "btn_eliminar_catproveedores";
            btn_eliminar_catproveedores.Size = new Size(84, 27);
            btn_eliminar_catproveedores.TabIndex = 12;
            btn_eliminar_catproveedores.Text = "Eliminar";
            btn_eliminar_catproveedores.UseVisualStyleBackColor = false;
            // 
            // btn_editar_catproveedores
            // 
            btn_editar_catproveedores.BackColor = Color.LightYellow;
            btn_editar_catproveedores.Location = new Point(112, 108);
            btn_editar_catproveedores.Margin = new Padding(2, 2, 2, 2);
            btn_editar_catproveedores.Name = "btn_editar_catproveedores";
            btn_editar_catproveedores.Size = new Size(84, 27);
            btn_editar_catproveedores.TabIndex = 11;
            btn_editar_catproveedores.Text = "Editar";
            btn_editar_catproveedores.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_catproveedores
            // 
            btn_agregar_catproveedores.BackColor = Color.LightGreen;
            btn_agregar_catproveedores.Location = new Point(14, 108);
            btn_agregar_catproveedores.Margin = new Padding(2, 2, 2, 2);
            btn_agregar_catproveedores.Name = "btn_agregar_catproveedores";
            btn_agregar_catproveedores.Size = new Size(84, 27);
            btn_agregar_catproveedores.TabIndex = 10;
            btn_agregar_catproveedores.Text = "Agregar";
            btn_agregar_catproveedores.UseVisualStyleBackColor = false;
            // 
            // txb_descripcion_catproveedores
            // 
            txb_descripcion_catproveedores.Location = new Point(105, 60);
            txb_descripcion_catproveedores.Margin = new Padding(2, 2, 2, 2);
            txb_descripcion_catproveedores.Multiline = true;
            txb_descripcion_catproveedores.Name = "txb_descripcion_catproveedores";
            txb_descripcion_catproveedores.Size = new Size(190, 38);
            txb_descripcion_catproveedores.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 8;
            label2.Text = "Descripción:";
            // 
            // txb_nombre_catproveedores
            // 
            txb_nombre_catproveedores.Location = new Point(105, 30);
            txb_nombre_catproveedores.Margin = new Padding(2, 2, 2, 2);
            txb_nombre_catproveedores.Name = "txb_nombre_catproveedores";
            txb_nombre_catproveedores.Size = new Size(190, 23);
            txb_nombre_catproveedores.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // controlDeUsuarioProveedoresCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "controlDeUsuarioProveedoresCategorias";
            Size = new Size(322, 306);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lb_categorias_catproveedores;
        private Button btn_eliminar_catproveedores;
        private Button btn_editar_catproveedores;
        private Button btn_agregar_catproveedores;
        private TextBox txb_descripcion_catproveedores;
        private Label label2;
        private TextBox txb_nombre_catproveedores;
        private Label label1;
    }
}