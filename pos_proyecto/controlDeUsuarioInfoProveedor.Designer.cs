namespace pos_proyecto
{
    partial class controlDeUsuarioInfoProveedor
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
            gbInfoProveedor = new GroupBox();
            cmbEstatus = new ComboBox();
            lblEstatus = new Label();
            cmbCategoriaProveedor = new ComboBox();
            lblCategoria = new Label();
            txtRFC = new TextBox();
            lblRFC = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            gbContacto = new GroupBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            gbDireccion = new GroupBox();
            txtCodigoPostal = new TextBox();
            lblCodigoPostal = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtCiudad = new TextBox();
            lblCiudad = new Label();
            txtColonia = new TextBox();
            lblColonia = new Label();
            txtCalle = new TextBox();
            lblCalle = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            gbInfoProveedor.SuspendLayout();
            gbContacto.SuspendLayout();
            gbDireccion.SuspendLayout();
            SuspendLayout();
            // 
            // gbInfoProveedor
            // 
            gbInfoProveedor.Controls.Add(cmbEstatus);
            gbInfoProveedor.Controls.Add(lblEstatus);
            gbInfoProveedor.Controls.Add(cmbCategoriaProveedor);
            gbInfoProveedor.Controls.Add(lblCategoria);
            gbInfoProveedor.Controls.Add(txtRFC);
            gbInfoProveedor.Controls.Add(lblRFC);
            gbInfoProveedor.Controls.Add(txtNombre);
            gbInfoProveedor.Controls.Add(lblNombre);
            gbInfoProveedor.Location = new Point(15, 15);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Size = new Size(480, 200);
            gbInfoProveedor.TabIndex = 0;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información del Proveedor";
            // 
            // cmbEstatus
            // 
            cmbEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstatus.Location = new Point(150, 150);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(300, 33);
            cmbEstatus.TabIndex = 7;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(20, 153);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(68, 25);
            lblEstatus.TabIndex = 6;
            lblEstatus.Text = "Estatus:";
            // 
            // cmbCategoriaProveedor
            // 
            cmbCategoriaProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaProveedor.FormattingEnabled = true;
            cmbCategoriaProveedor.Location = new Point(150, 110);
            cmbCategoriaProveedor.Name = "cmbCategoriaProveedor";
            cmbCategoriaProveedor.Size = new Size(300, 33);
            cmbCategoriaProveedor.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(20, 113);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 25);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoría:";
            // 
            // txtRFC
            // 
            txtRFC.Location = new Point(150, 70);
            txtRFC.MaxLength = 12;
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(200, 31);
            txtRFC.TabIndex = 3;
            // 
            // lblRFC
            // 
            lblRFC.AutoSize = true;
            lblRFC.Location = new Point(20, 73);
            lblRFC.Name = "lblRFC";
            lblRFC.Size = new Size(48, 25);
            lblRFC.TabIndex = 2;
            lblRFC.Text = "RFC:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 31);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gbContacto
            // 
            gbContacto.Controls.Add(txtEmail);
            gbContacto.Controls.Add(lblEmail);
            gbContacto.Controls.Add(txtTelefono);
            gbContacto.Controls.Add(lblTelefono);
            gbContacto.Location = new Point(15, 230);
            gbContacto.Name = "gbContacto";
            gbContacto.Size = new Size(480, 120);
            gbContacto.TabIndex = 1;
            gbContacto.TabStop = false;
            gbContacto.Text = "Información de Contacto";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 31);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 30);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 31);
            txtTelefono.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(20, 33);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono:";
            // 
            // gbDireccion
            // 
            gbDireccion.Controls.Add(txtCodigoPostal);
            gbDireccion.Controls.Add(lblCodigoPostal);
            gbDireccion.Controls.Add(txtEstado);
            gbDireccion.Controls.Add(lblEstado);
            gbDireccion.Controls.Add(txtCiudad);
            gbDireccion.Controls.Add(lblCiudad);
            gbDireccion.Controls.Add(txtColonia);
            gbDireccion.Controls.Add(lblColonia);
            gbDireccion.Controls.Add(txtCalle);
            gbDireccion.Controls.Add(lblCalle);
            gbDireccion.Location = new Point(15, 370);
            gbDireccion.Name = "gbDireccion";
            gbDireccion.Size = new Size(480, 250);
            gbDireccion.TabIndex = 2;
            gbDireccion.TabStop = false;
            gbDireccion.Text = "Dirección";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(150, 200);
            txtCodigoPostal.MaxLength = 5;
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(150, 31);
            txtCodigoPostal.TabIndex = 9;
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(20, 203);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(124, 25);
            lblCodigoPostal.TabIndex = 8;
            lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(150, 160);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(300, 31);
            txtEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(20, 163);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(68, 25);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(150, 120);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(300, 31);
            txtCiudad.TabIndex = 5;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(20, 123);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(72, 25);
            lblCiudad.TabIndex = 4;
            lblCiudad.Text = "Ciudad:";
            // 
            // txtColonia
            // 
            txtColonia.Location = new Point(150, 80);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(300, 31);
            txtColonia.TabIndex = 3;
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Location = new Point(20, 83);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(78, 25);
            lblColonia.TabIndex = 2;
            lblColonia.Text = "Colonia:";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(150, 40);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(300, 31);
            txtCalle.TabIndex = 1;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(20, 43);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(55, 25);
            lblCalle.TabIndex = 0;
            lblCalle.Text = "Calle:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGreen;
            btnGuardar.Location = new Point(320, 640);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 45);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightGray;
            btnLimpiar.Location = new Point(180, 640);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 45);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // controlDeUsuarioInfoProveedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(gbDireccion);
            Controls.Add(gbContacto);
            Controls.Add(gbInfoProveedor);
            Name = "controlDeUsuarioInfoProveedor";
            Size = new Size(517, 700);
            gbInfoProveedor.ResumeLayout(false);
            gbInfoProveedor.PerformLayout();
            gbContacto.ResumeLayout(false);
            gbContacto.PerformLayout();
            gbDireccion.ResumeLayout(false);
            gbDireccion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInfoProveedor;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtRFC;
        private Label lblRFC;
        private ComboBox cmbCategoriaProveedor;
        private Label lblCategoria;
        private ComboBox cmbEstatus;
        private Label lblEstatus;
        private GroupBox gbContacto;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private GroupBox gbDireccion;
        private TextBox txtCodigoPostal;
        private Label lblCodigoPostal;
        private TextBox txtEstado;
        private Label lblEstado;
        private TextBox txtCiudad;
        private Label lblCiudad;
        private TextBox txtColonia;
        private Label lblColonia;
        private TextBox txtCalle;
        private Label lblCalle;
        private Button btnGuardar;
        private Button btnLimpiar;
    }
}