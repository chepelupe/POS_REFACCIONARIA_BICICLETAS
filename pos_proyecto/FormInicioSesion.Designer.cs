namespace pos_proyecto
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            gb_inicio = new GroupBox();
            cmbTipoUsuario = new ComboBox();
            lblTipoUsuario = new Label();
            lbl_titulo = new Label();
            panel1 = new Panel();
            pb_logo = new PictureBox();
            btn_iniciar_sesion = new Button();
            tb_contra = new TextBox();
            tb_usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_salir = new Button();
            lbl_version = new Label();
            gb_inicio.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo).BeginInit();
            SuspendLayout();
            // 
            // gb_inicio
            // 
            gb_inicio.Anchor = AnchorStyles.None;
            gb_inicio.BackColor = Color.White;
            gb_inicio.Controls.Add(cmbTipoUsuario);
            gb_inicio.Controls.Add(lblTipoUsuario);
            gb_inicio.Controls.Add(lbl_titulo);
            gb_inicio.Controls.Add(panel1);
            gb_inicio.Controls.Add(btn_iniciar_sesion);
            gb_inicio.Controls.Add(tb_contra);
            gb_inicio.Controls.Add(tb_usuario);
            gb_inicio.Controls.Add(label2);
            gb_inicio.Controls.Add(label1);
            gb_inicio.FlatStyle = FlatStyle.Flat;
            gb_inicio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_inicio.Location = new Point(30, 30);
            gb_inicio.Margin = new Padding(4);
            gb_inicio.Name = "gb_inicio";
            gb_inicio.Padding = new Padding(4);
            gb_inicio.Size = new Size(440, 480);
            gb_inicio.TabIndex = 0;
            gb_inicio.TabStop = false;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.Font = new Font("Segoe UI", 10F);
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Administrador", "Vendedor", "Almacenista" });
            cmbTipoUsuario.Location = new Point(120, 300);
            cmbTipoUsuario.Margin = new Padding(4);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(200, 36);
            cmbTipoUsuario.TabIndex = 9;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 10F);
            lblTipoUsuario.ForeColor = Color.FromArgb(45, 45, 48);
            lblTipoUsuario.Location = new Point(120, 270);
            lblTipoUsuario.Margin = new Padding(4, 0, 4, 0);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(128, 28);
            lblTipoUsuario.TabIndex = 8;
            lblTipoUsuario.Text = "Tipo Usuario:";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.FromArgb(45, 45, 48);
            lbl_titulo.Location = new Point(120, 25);
            lbl_titulo.Margin = new Padding(4, 0, 4, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(200, 38);
            lbl_titulo.TabIndex = 7;
            lbl_titulo.Text = "POS Refaccionaria";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pb_logo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 80);
            panel1.TabIndex = 6;
            // 
            // pb_logo
            // 
            pb_logo.Image = (Image)resources.GetObject("pb_logo.Image");
            pb_logo.Location = new Point(20, 15);
            pb_logo.Margin = new Padding(4);
            pb_logo.Name = "pb_logo";
            pb_logo.Size = new Size(50, 50);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.TabIndex = 0;
            pb_logo.TabStop = false;
            // 
            // btn_iniciar_sesion
            // 
            btn_iniciar_sesion.BackColor = Color.FromArgb(0, 122, 204);
            btn_iniciar_sesion.FlatAppearance.BorderSize = 0;
            btn_iniciar_sesion.FlatStyle = FlatStyle.Flat;
            btn_iniciar_sesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_iniciar_sesion.ForeColor = Color.White;
            btn_iniciar_sesion.Location = new Point(120, 380);
            btn_iniciar_sesion.Margin = new Padding(4);
            btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            btn_iniciar_sesion.Size = new Size(200, 50);
            btn_iniciar_sesion.TabIndex = 4;
            btn_iniciar_sesion.Text = "Iniciar Sesión";
            btn_iniciar_sesion.UseVisualStyleBackColor = false;
            // 
            // tb_contra
            // 
            tb_contra.BorderStyle = BorderStyle.FixedSingle;
            tb_contra.Font = new Font("Segoe UI", 10F);
            tb_contra.Location = new Point(120, 220);
            tb_contra.Margin = new Padding(4);
            tb_contra.Name = "tb_contra";
            tb_contra.PasswordChar = '•';
            tb_contra.Size = new Size(200, 34);
            tb_contra.TabIndex = 3;
            tb_contra.UseSystemPasswordChar = true;
            // 
            // tb_usuario
            // 
            tb_usuario.BorderStyle = BorderStyle.FixedSingle;
            tb_usuario.Font = new Font("Segoe UI", 10F);
            tb_usuario.Location = new Point(120, 140);
            tb_usuario.Margin = new Padding(4);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(200, 34);
            tb_usuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(45, 45, 48);
            label2.Location = new Point(120, 190);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(45, 45, 48);
            label1.Location = new Point(120, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salir.BackColor = Color.FromArgb(220, 53, 69);
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Segoe UI", 9F);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(350, 530);
            btn_salir.Margin = new Padding(4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(120, 40);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // lbl_version
            // 
            lbl_version.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_version.AutoSize = true;
            lbl_version.Font = new Font("Segoe UI", 8F);
            lbl_version.ForeColor = Color.Gray;
            lbl_version.Location = new Point(30, 545);
            lbl_version.Margin = new Padding(4, 0, 4, 0);
            lbl_version.Name = "lbl_version";
            lbl_version.Size = new Size(118, 21);
            lbl_version.TabIndex = 6;
            lbl_version.Text = "Versión 1.0.0";
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(500, 590);
            Controls.Add(lbl_version);
            Controls.Add(btn_salir);
            Controls.Add(gb_inicio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión - POS Refaccionaria";
            gb_inicio.ResumeLayout(false);
            gb_inicio.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_inicio;
        private Label label2;
        private Label label1;
        private Button btn_iniciar_sesion;
        private TextBox tb_contra;
        private TextBox tb_usuario;
        private Button btn_salir;
        private Panel panel1;
        private PictureBox pb_logo;
        private Label lbl_titulo;
        private Label lbl_version;
        private ComboBox cmbTipoUsuario;
        private Label lblTipoUsuario;
    }
}