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
            cmbEstatus = new ComboBox();
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
            gbCat.Controls.Add(lblEstatus);
            gbCat.Controls.Add(cmbEstatus);
            gbCat.Controls.Add(btnModificarCat);
            gbCat.Controls.Add(btnEliminarCat);
            gbCat.Controls.Add(btnAgregarCat);
            gbCat.Controls.Add(cbEliminarCat);
            gbCat.Controls.Add(label2);
            gbCat.Controls.Add(label1);
            gbCat.Controls.Add(txtAgregarCat);
            gbCat.Location = new Point(3, 3);
            gbCat.Name = "gbCat";
            gbCat.Size = new Size(500, 350);
            gbCat.TabIndex = 0;
            gbCat.TabStop = false;
            gbCat.Text = "Gestión de Categorías de Productos";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(21, 150);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(68, 25);
            lblEstatus.TabIndex = 8;
            lblEstatus.Text = "Estatus:";
            // 
            // cmbEstatus
            // 
            cmbEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstatus.Location = new Point(184, 147);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(229, 33);
            cmbEstatus.TabIndex = 7;
            // 
            // btnModificarCat
            // 
            btnModificarCat.BackColor = Color.LightYellow;
            btnModificarCat.Location = new Point(327, 250);
            btnModificarCat.Name = "btnModificarCat";
            btnModificarCat.Size = new Size(120, 60);
            btnModificarCat.TabIndex = 6;
            btnModificarCat.Text = "Modificar";
            btnModificarCat.UseVisualStyleBackColor = false;
            btnModificarCat.Click += btnModificarCat_Click;
            // 
            // btnEliminarCat
            // 
            btnEliminarCat.BackColor = Color.LightCoral;
            btnEliminarCat.Location = new Point(184, 250);
            btnEliminarCat.Name = "btnEliminarCat";
            btnEliminarCat.Size = new Size(120, 60);
            btnEliminarCat.TabIndex = 5;
            btnEliminarCat.Text = "Eliminar";
            btnEliminarCat.UseVisualStyleBackColor = false;
            btnEliminarCat.Click += btnEliminarCat_Click;
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.BackColor = Color.LightGreen;
            btnAgregarCat.Location = new Point(41, 250);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(120, 60);
            btnAgregarCat.TabIndex = 4;
            btnAgregarCat.Text = "Agregar";
            btnAgregarCat.UseVisualStyleBackColor = false;
            btnAgregarCat.Click += button1_Click;
            // 
            // cbEliminarCat
            // 
            cbEliminarCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEliminarCat.FormattingEnabled = true;
            cbEliminarCat.Location = new Point(184, 99);
            cbEliminarCat.Name = "cbEliminarCat";
            cbEliminarCat.Size = new Size(229, 33);
            cbEliminarCat.TabIndex = 3;
            cbEliminarCat.SelectedIndexChanged += cbEliminarCat_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 2;
            label2.Text = "Seleccionar categoría:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 52);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre categoría:";
            // 
            // txtAgregarCat
            // 
            txtAgregarCat.Location = new Point(184, 49);
            txtAgregarCat.Name = "txtAgregarCat";
            txtAgregarCat.Size = new Size(229, 31);
            txtAgregarCat.TabIndex = 0;
            // 
            // controlDeUsuarioProductosCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbCat);
            Name = "controlDeUsuarioProductosCategorias";
            Size = new Size(510, 360);
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
        private ComboBox cmbEstatus;
        private Label lblEstatus;
    }
}