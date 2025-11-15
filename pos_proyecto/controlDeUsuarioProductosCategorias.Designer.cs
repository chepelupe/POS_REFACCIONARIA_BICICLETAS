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
            btnModificarCat = new Button();
            btnEliminarCat = new Button();
            btnAgregarCat = new Button();
            cbEliminarCat = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtAgregarCat = new TextBox();
            gbCat.SuspendLayout();
            SuspendLayout();
            // 
            // gbCat
            // 
            gbCat.Controls.Add(btnModificarCat);
            gbCat.Controls.Add(btnEliminarCat);
            gbCat.Controls.Add(btnAgregarCat);
            gbCat.Controls.Add(cbEliminarCat);
            gbCat.Controls.Add(label2);
            gbCat.Controls.Add(label1);
            gbCat.Controls.Add(txtAgregarCat);
            gbCat.Location = new Point(3, 3);
            gbCat.Name = "gbCat";
            gbCat.Size = new Size(469, 284);
            gbCat.TabIndex = 0;
            gbCat.TabStop = false;
            gbCat.Text = "Opciones Categoría";
            // 
            // btnModificarCat
            // 
            btnModificarCat.Location = new Point(327, 203);
            btnModificarCat.Name = "btnModificarCat";
            btnModificarCat.Size = new Size(112, 58);
            btnModificarCat.TabIndex = 6;
            btnModificarCat.Text = "Modificar Categoría";
            btnModificarCat.UseVisualStyleBackColor = true;
            btnModificarCat.Click += btnModificarCat_Click;
            // 
            // btnEliminarCat
            // 
            btnEliminarCat.Location = new Point(184, 203);
            btnEliminarCat.Name = "btnEliminarCat";
            btnEliminarCat.Size = new Size(112, 58);
            btnEliminarCat.TabIndex = 5;
            btnEliminarCat.Text = "Eliminar Categoría";
            btnEliminarCat.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.Location = new Point(41, 203);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(112, 58);
            btnAgregarCat.TabIndex = 4;
            btnAgregarCat.Text = "Agregar Categoría";
            btnAgregarCat.UseVisualStyleBackColor = true;
            btnAgregarCat.Click += button1_Click;
            // 
            // cbEliminarCat
            // 
            cbEliminarCat.FormattingEnabled = true;
            cbEliminarCat.Location = new Point(184, 99);
            cbEliminarCat.Name = "cbEliminarCat";
            cbEliminarCat.Size = new Size(229, 33);
            cbEliminarCat.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 99);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 2;
            label2.Text = "Eliminar categoría";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 52);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 1;
            label1.Text = "Agregar categoría";
            // 
            // txtAgregarCat
            // 
            txtAgregarCat.Location = new Point(184, 52);
            txtAgregarCat.Name = "txtAgregarCat";
            txtAgregarCat.Size = new Size(229, 31);
            txtAgregarCat.TabIndex = 0;
            // 
            // controlDeUsuarioCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbCat);
            Name = "controlDeUsuarioCategorias";
            Size = new Size(475, 291);
            gbCat.ResumeLayout(false);
            gbCat.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox gbCat;
        private Button btnAgregarCat;
        private ComboBox cbEliminarCat;
        private Label label2;
        private Label label1;
        private TextBox txtAgregarCat;
        private Button btnModificarCat;
        private Button btnEliminarCat;
    }
}
