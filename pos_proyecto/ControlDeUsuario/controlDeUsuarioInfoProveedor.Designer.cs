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
            cb_estatus_infoproveedor = new ComboBox();
            lblEstatus = new Label();
            cb_categoriaProveedor_infoproveedor = new ComboBox();
            lblCategoria = new Label();
            txt_rfc_infoproveedor = new TextBox();
            lblRFC = new Label();
            txt_nombre_infoproveedor = new TextBox();
            lblNombre = new Label();
            gbContacto = new GroupBox();
            txt_email_infoproveedor = new TextBox();
            lblEmail = new Label();
            txt_telefono_infoproveedor = new TextBox();
            lblTelefono = new Label();
            gbDireccion = new GroupBox();
            txt_codigoPostal_infoproveedor = new TextBox();
            lblCodigoPostal = new Label();
            txt_estado_infoproveedor = new TextBox();
            lblEstado = new Label();
            txt_ciudad_infoproveedor = new TextBox();
            lblCiudad = new Label();
            txt_colonia_infoproveedor = new TextBox();
            lblColonia = new Label();
            txt_calle_infoproveedor = new TextBox();
            lblCalle = new Label();
            btn_guardar_infoproveedor = new Button();
            btn_limpiar_infoproveedor = new Button();
            gbInfoProveedor.SuspendLayout();
            gbContacto.SuspendLayout();
            gbDireccion.SuspendLayout();
            SuspendLayout();
            // 
            // gbInfoProveedor
            // 
            gbInfoProveedor.Controls.Add(cb_estatus_infoproveedor);
            gbInfoProveedor.Controls.Add(lblEstatus);
            gbInfoProveedor.Controls.Add(cb_categoriaProveedor_infoproveedor);
            gbInfoProveedor.Controls.Add(lblCategoria);
            gbInfoProveedor.Controls.Add(txt_rfc_infoproveedor);
            gbInfoProveedor.Controls.Add(lblRFC);
            gbInfoProveedor.Controls.Add(txt_nombre_infoproveedor);
            gbInfoProveedor.Controls.Add(lblNombre);
            gbInfoProveedor.Location = new Point(10, 9);
            gbInfoProveedor.Margin = new Padding(2);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Padding = new Padding(2);
            gbInfoProveedor.Size = new Size(336, 120);
            gbInfoProveedor.TabIndex = 0;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información del Proveedor";
            // 
            // cb_estatus_infoproveedor
            // 
            cb_estatus_infoproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estatus_infoproveedor.FormattingEnabled = true;
            cb_estatus_infoproveedor.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cb_estatus_infoproveedor.Location = new Point(105, 90);
            cb_estatus_infoproveedor.Margin = new Padding(2);
            cb_estatus_infoproveedor.Name = "cb_estatus_infoproveedor";
            cb_estatus_infoproveedor.Size = new Size(211, 23);
            cb_estatus_infoproveedor.TabIndex = 7;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(14, 92);
            lblEstatus.Margin = new Padding(2, 0, 2, 0);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(47, 15);
            lblEstatus.TabIndex = 6;
            lblEstatus.Text = "Estatus:";
            // 
            // cb_categoriaProveedor_infoproveedor
            // 
            cb_categoriaProveedor_infoproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoriaProveedor_infoproveedor.FormattingEnabled = true;
            cb_categoriaProveedor_infoproveedor.Location = new Point(105, 66);
            cb_categoriaProveedor_infoproveedor.Margin = new Padding(2);
            cb_categoriaProveedor_infoproveedor.Name = "cb_categoriaProveedor_infoproveedor";
            cb_categoriaProveedor_infoproveedor.Size = new Size(211, 23);
            cb_categoriaProveedor_infoproveedor.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(14, 68);
            lblCategoria.Margin = new Padding(2, 0, 2, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoría:";
            // 
            // txt_rfc_infoproveedor
            // 
            txt_rfc_infoproveedor.Location = new Point(105, 42);
            txt_rfc_infoproveedor.Margin = new Padding(2);
            txt_rfc_infoproveedor.MaxLength = 12;
            txt_rfc_infoproveedor.Name = "txt_rfc_infoproveedor";
            txt_rfc_infoproveedor.Size = new Size(141, 23);
            txt_rfc_infoproveedor.TabIndex = 3;
            // 
            // lblRFC
            // 
            lblRFC.AutoSize = true;
            lblRFC.Location = new Point(14, 44);
            lblRFC.Margin = new Padding(2, 0, 2, 0);
            lblRFC.Name = "lblRFC";
            lblRFC.Size = new Size(31, 15);
            lblRFC.TabIndex = 2;
            lblRFC.Text = "RFC:";
            // 
            // txt_nombre_infoproveedor
            // 
            txt_nombre_infoproveedor.Location = new Point(105, 18);
            txt_nombre_infoproveedor.Margin = new Padding(2);
            txt_nombre_infoproveedor.Name = "txt_nombre_infoproveedor";
            txt_nombre_infoproveedor.Size = new Size(211, 23);
            txt_nombre_infoproveedor.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 20);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gbContacto
            // 
            gbContacto.Controls.Add(txt_email_infoproveedor);
            gbContacto.Controls.Add(lblEmail);
            gbContacto.Controls.Add(txt_telefono_infoproveedor);
            gbContacto.Controls.Add(lblTelefono);
            gbContacto.Location = new Point(10, 138);
            gbContacto.Margin = new Padding(2);
            gbContacto.Name = "gbContacto";
            gbContacto.Padding = new Padding(2);
            gbContacto.Size = new Size(336, 72);
            gbContacto.TabIndex = 1;
            gbContacto.TabStop = false;
            gbContacto.Text = "Información de Contacto";
            // 
            // txt_email_infoproveedor
            // 
            txt_email_infoproveedor.Location = new Point(105, 42);
            txt_email_infoproveedor.Margin = new Padding(2);
            txt_email_infoproveedor.Name = "txt_email_infoproveedor";
            txt_email_infoproveedor.Size = new Size(211, 23);
            txt_email_infoproveedor.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 44);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txt_telefono_infoproveedor
            // 
            txt_telefono_infoproveedor.Location = new Point(105, 18);
            txt_telefono_infoproveedor.Margin = new Padding(2);
            txt_telefono_infoproveedor.MaxLength = 10;
            txt_telefono_infoproveedor.Name = "txt_telefono_infoproveedor";
            txt_telefono_infoproveedor.Size = new Size(141, 23);
            txt_telefono_infoproveedor.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(14, 20);
            lblTelefono.Margin = new Padding(2, 0, 2, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono:";
            // 
            // gbDireccion
            // 
            gbDireccion.Controls.Add(txt_codigoPostal_infoproveedor);
            gbDireccion.Controls.Add(lblCodigoPostal);
            gbDireccion.Controls.Add(txt_estado_infoproveedor);
            gbDireccion.Controls.Add(lblEstado);
            gbDireccion.Controls.Add(txt_ciudad_infoproveedor);
            gbDireccion.Controls.Add(lblCiudad);
            gbDireccion.Controls.Add(txt_colonia_infoproveedor);
            gbDireccion.Controls.Add(lblColonia);
            gbDireccion.Controls.Add(txt_calle_infoproveedor);
            gbDireccion.Controls.Add(lblCalle);
            gbDireccion.Location = new Point(10, 222);
            gbDireccion.Margin = new Padding(2);
            gbDireccion.Name = "gbDireccion";
            gbDireccion.Padding = new Padding(2);
            gbDireccion.Size = new Size(336, 150);
            gbDireccion.TabIndex = 2;
            gbDireccion.TabStop = false;
            gbDireccion.Text = "Dirección";
            // 
            // txt_codigoPostal_infoproveedor
            // 
            txt_codigoPostal_infoproveedor.Location = new Point(105, 120);
            txt_codigoPostal_infoproveedor.Margin = new Padding(2);
            txt_codigoPostal_infoproveedor.MaxLength = 5;
            txt_codigoPostal_infoproveedor.Name = "txt_codigoPostal_infoproveedor";
            txt_codigoPostal_infoproveedor.Size = new Size(106, 23);
            txt_codigoPostal_infoproveedor.TabIndex = 9;
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(14, 122);
            lblCodigoPostal.Margin = new Padding(2, 0, 2, 0);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(84, 15);
            lblCodigoPostal.TabIndex = 8;
            lblCodigoPostal.Text = "Código Postal:";
            // 
            // txt_estado_infoproveedor
            // 
            txt_estado_infoproveedor.Location = new Point(105, 96);
            txt_estado_infoproveedor.Margin = new Padding(2);
            txt_estado_infoproveedor.Name = "txt_estado_infoproveedor";
            txt_estado_infoproveedor.Size = new Size(211, 23);
            txt_estado_infoproveedor.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(14, 98);
            lblEstado.Margin = new Padding(2, 0, 2, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // txt_ciudad_infoproveedor
            // 
            txt_ciudad_infoproveedor.Location = new Point(105, 72);
            txt_ciudad_infoproveedor.Margin = new Padding(2);
            txt_ciudad_infoproveedor.Name = "txt_ciudad_infoproveedor";
            txt_ciudad_infoproveedor.Size = new Size(211, 23);
            txt_ciudad_infoproveedor.TabIndex = 5;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(14, 74);
            lblCiudad.Margin = new Padding(2, 0, 2, 0);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(48, 15);
            lblCiudad.TabIndex = 4;
            lblCiudad.Text = "Ciudad:";
            // 
            // txt_colonia_infoproveedor
            // 
            txt_colonia_infoproveedor.Location = new Point(105, 48);
            txt_colonia_infoproveedor.Margin = new Padding(2);
            txt_colonia_infoproveedor.Name = "txt_colonia_infoproveedor";
            txt_colonia_infoproveedor.Size = new Size(211, 23);
            txt_colonia_infoproveedor.TabIndex = 3;
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Location = new Point(14, 50);
            lblColonia.Margin = new Padding(2, 0, 2, 0);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(51, 15);
            lblColonia.TabIndex = 2;
            lblColonia.Text = "Colonia:";
            // 
            // txt_calle_infoproveedor
            // 
            txt_calle_infoproveedor.Location = new Point(105, 24);
            txt_calle_infoproveedor.Margin = new Padding(2);
            txt_calle_infoproveedor.Name = "txt_calle_infoproveedor";
            txt_calle_infoproveedor.Size = new Size(211, 23);
            txt_calle_infoproveedor.TabIndex = 1;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(14, 26);
            lblCalle.Margin = new Padding(2, 0, 2, 0);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 0;
            lblCalle.Text = "Calle:";
            // 
            // btn_guardar_infoproveedor
            // 
            btn_guardar_infoproveedor.BackColor = Color.LightGreen;
            btn_guardar_infoproveedor.Location = new Point(224, 384);
            btn_guardar_infoproveedor.Margin = new Padding(2);
            btn_guardar_infoproveedor.Name = "btn_guardar_infoproveedor";
            btn_guardar_infoproveedor.Size = new Size(84, 27);
            btn_guardar_infoproveedor.TabIndex = 3;
            btn_guardar_infoproveedor.Text = "Guardar";
            btn_guardar_infoproveedor.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar_infoproveedor
            // 
            btn_limpiar_infoproveedor.BackColor = Color.LightGray;
            btn_limpiar_infoproveedor.Location = new Point(126, 384);
            btn_limpiar_infoproveedor.Margin = new Padding(2);
            btn_limpiar_infoproveedor.Name = "btn_limpiar_infoproveedor";
            btn_limpiar_infoproveedor.Size = new Size(84, 27);
            btn_limpiar_infoproveedor.TabIndex = 4;
            btn_limpiar_infoproveedor.Text = "Limpiar";
            btn_limpiar_infoproveedor.UseVisualStyleBackColor = false;
            // 
            // controlDeUsuarioInfoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_limpiar_infoproveedor);
            Controls.Add(btn_guardar_infoproveedor);
            Controls.Add(gbDireccion);
            Controls.Add(gbContacto);
            Controls.Add(gbInfoProveedor);
            Margin = new Padding(2);
            Name = "controlDeUsuarioInfoProveedor";
            Size = new Size(362, 420);
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
        private TextBox txt_nombre_infoproveedor;
        private Label lblNombre;
        private TextBox txt_rfc_infoproveedor;
        private Label lblRFC;
        private ComboBox cb_categoriaProveedor_infoproveedor;
        private Label lblCategoria;
        private ComboBox cb_estatus_infoproveedor;
        private Label lblEstatus;
        private GroupBox gbContacto;
        private TextBox txt_email_infoproveedor;
        private Label lblEmail;
        private TextBox txt_telefono_infoproveedor;
        private Label lblTelefono;
        private GroupBox gbDireccion;
        private TextBox txt_codigoPostal_infoproveedor;
        private Label lblCodigoPostal;
        private TextBox txt_estado_infoproveedor;
        private Label lblEstado;
        private TextBox txt_ciudad_infoproveedor;
        private Label lblCiudad;
        private TextBox txt_colonia_infoproveedor;
        private Label lblColonia;
        private TextBox txt_calle_infoproveedor;
        private Label lblCalle;
        private Button btn_guardar_infoproveedor;
        private Button btn_limpiar_infoproveedor;
    }
}