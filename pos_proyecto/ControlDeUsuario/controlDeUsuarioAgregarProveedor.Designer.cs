namespace pos_proyecto
{
    partial class ControlDeUsuarioAgregarProveedor
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
            cb_estatus_agrproveedores = new ComboBox();
            lblEstatus = new Label();
            txb_telefono_agrproveedores = new TextBox();
            label7 = new Label();
            txb_rfc_agrproveedores = new TextBox();
            label6 = new Label();
            cb_categoria_agrproveedores = new ComboBox();
            btn_agregar_agrproveedores = new Button();
            txb_correo_agrproveedores = new TextBox();
            txb_nombre_agrproveedores = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_estatus_agrproveedores);
            groupBox1.Controls.Add(lblEstatus);
            groupBox1.Controls.Add(txb_telefono_agrproveedores);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txb_rfc_agrproveedores);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cb_categoria_agrproveedores);
            groupBox1.Controls.Add(btn_agregar_agrproveedores);
            groupBox1.Controls.Add(txb_correo_agrproveedores);
            groupBox1.Controls.Add(txb_nombre_agrproveedores);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(315, 270);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Nuevo Proveedor";
            // 
            // cb_estatus_agrproveedores
            // 
            cb_estatus_agrproveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estatus_agrproveedores.FormattingEnabled = true;
            cb_estatus_agrproveedores.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cb_estatus_agrproveedores.Location = new Point(136, 180);
            cb_estatus_agrproveedores.Margin = new Padding(2, 2, 2, 2);
            cb_estatus_agrproveedores.Name = "cb_estatus_agrproveedores";
            cb_estatus_agrproveedores.Size = new Size(141, 23);
            cb_estatus_agrproveedores.TabIndex = 17;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(8, 182);
            lblEstatus.Margin = new Padding(2, 0, 2, 0);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(47, 15);
            lblEstatus.TabIndex = 16;
            lblEstatus.Text = "Estatus:";
            // 
            // txb_telefono_agrproveedores
            // 
            txb_telefono_agrproveedores.Location = new Point(136, 89);
            txb_telefono_agrproveedores.Margin = new Padding(2, 2, 2, 2);
            txb_telefono_agrproveedores.MaxLength = 10;
            txb_telefono_agrproveedores.Name = "txb_telefono_agrproveedores";
            txb_telefono_agrproveedores.Size = new Size(141, 23);
            txb_telefono_agrproveedores.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 91);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 14;
            label7.Text = "Teléfono:";
            // 
            // txb_rfc_agrproveedores
            // 
            txb_rfc_agrproveedores.Location = new Point(136, 58);
            txb_rfc_agrproveedores.Margin = new Padding(2, 2, 2, 2);
            txb_rfc_agrproveedores.MaxLength = 12;
            txb_rfc_agrproveedores.Name = "txb_rfc_agrproveedores";
            txb_rfc_agrproveedores.Size = new Size(141, 23);
            txb_rfc_agrproveedores.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 59);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 12;
            label6.Text = "RFC:";
            // 
            // cb_categoria_agrproveedores
            // 
            cb_categoria_agrproveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoria_agrproveedores.FormattingEnabled = true;
            cb_categoria_agrproveedores.Location = new Point(136, 149);
            cb_categoria_agrproveedores.Margin = new Padding(2, 2, 2, 2);
            cb_categoria_agrproveedores.Name = "cb_categoria_agrproveedores";
            cb_categoria_agrproveedores.Size = new Size(141, 23);
            cb_categoria_agrproveedores.TabIndex = 11;
            // 
            // btn_agregar_agrproveedores
            // 
            btn_agregar_agrproveedores.BackColor = Color.LightGreen;
            btn_agregar_agrproveedores.Location = new Point(91, 216);
            btn_agregar_agrproveedores.Margin = new Padding(2, 2, 2, 2);
            btn_agregar_agrproveedores.Name = "btn_agregar_agrproveedores";
            btn_agregar_agrproveedores.Size = new Size(126, 36);
            btn_agregar_agrproveedores.TabIndex = 10;
            btn_agregar_agrproveedores.Text = "Agregar Proveedor";
            btn_agregar_agrproveedores.UseVisualStyleBackColor = false;
            btn_agregar_agrproveedores.Click += btn_agregar_Click;
            // 
            // txb_correo_agrproveedores
            // 
            txb_correo_agrproveedores.Location = new Point(136, 119);
            txb_correo_agrproveedores.Margin = new Padding(2, 2, 2, 2);
            txb_correo_agrproveedores.Name = "txb_correo_agrproveedores";
            txb_correo_agrproveedores.Size = new Size(141, 23);
            txb_correo_agrproveedores.TabIndex = 8;
            // 
            // txb_nombre_agrproveedores
            // 
            txb_nombre_agrproveedores.Location = new Point(136, 28);
            txb_nombre_agrproveedores.Margin = new Padding(2, 2, 2, 2);
            txb_nombre_agrproveedores.Name = "txb_nombre_agrproveedores";
            txb_nombre_agrproveedores.Size = new Size(141, 23);
            txb_nombre_agrproveedores.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 121);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo Electrónico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 151);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Categoría:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // ControlDeUsuarioAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ControlDeUsuarioAgregarProveedor";
            Size = new Size(322, 276);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txb_telefono_agrproveedores;
        private Label label7;
        private TextBox txb_rfc_agrproveedores;
        private Label label6;
        private ComboBox cb_categoria_agrproveedores;
        private Button btn_agregar_agrproveedores;
        private TextBox txb_correo_agrproveedores;
        private TextBox txb_nombre_agrproveedores;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cb_estatus_agrproveedores;
        private Label lblEstatus;
    }
}