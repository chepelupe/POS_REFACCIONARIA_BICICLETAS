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
            gb_inicio = new GroupBox();
            cb_tipoUsuario_iniciosesion = new ComboBox();
            lblTipoUsuario = new Label();
            lbl_titulo = new Label();
            panel1 = new Panel();
            pb_logo = new PictureBox();
            btn_iniciar_sesion_iniciosesion = new Button();
            tb_contra_iniciosesion = new TextBox();
            tb_usuario_iniciosesion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_salir_iniciosesion = new Button();
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
            gb_inicio.Controls.Add(cb_tipoUsuario_iniciosesion);
            gb_inicio.Controls.Add(lblTipoUsuario);
            gb_inicio.Controls.Add(lbl_titulo);
            gb_inicio.Controls.Add(panel1);
            gb_inicio.Controls.Add(btn_iniciar_sesion_iniciosesion);
            gb_inicio.Controls.Add(tb_contra_iniciosesion);
            gb_inicio.Controls.Add(tb_usuario_iniciosesion);
            gb_inicio.Controls.Add(label2);
            gb_inicio.Controls.Add(label1);
            gb_inicio.FlatStyle = FlatStyle.Flat;
            gb_inicio.Font = new Font("Segoe UI", 9F);
            gb_inicio.Location = new Point(21, 18);
            gb_inicio.Margin = new Padding(3, 2, 3, 2);
            gb_inicio.Name = "gb_inicio";
            gb_inicio.Padding = new Padding(3, 2, 3, 2);
            gb_inicio.Size = new Size(308, 288);
            gb_inicio.TabIndex = 0;
            gb_inicio.TabStop = false;
            // 
            // cb_tipoUsuario_iniciosesion
            // 
            cb_tipoUsuario_iniciosesion.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipoUsuario_iniciosesion.Font = new Font("Segoe UI", 10F);
            cb_tipoUsuario_iniciosesion.FormattingEnabled = true;
            cb_tipoUsuario_iniciosesion.Items.AddRange(new object[] { "Administrador", "Vendedor", "Almacenista" });
            cb_tipoUsuario_iniciosesion.Location = new Point(84, 180);
            cb_tipoUsuario_iniciosesion.Margin = new Padding(3, 2, 3, 2);
            cb_tipoUsuario_iniciosesion.Name = "cb_tipoUsuario_iniciosesion";
            cb_tipoUsuario_iniciosesion.Size = new Size(141, 25);
            cb_tipoUsuario_iniciosesion.TabIndex = 9;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 10F);
            lblTipoUsuario.ForeColor = Color.FromArgb(45, 45, 48);
            lblTipoUsuario.Location = new Point(84, 162);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(89, 19);
            lblTipoUsuario.TabIndex = 8;
            lblTipoUsuario.Text = "Tipo Usuario:";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.FromArgb(45, 45, 48);
            lbl_titulo.Location = new Point(84, 15);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(173, 25);
            lbl_titulo.TabIndex = 7;
            lbl_titulo.Text = "POS Refaccionaria";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pb_logo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 48);
            panel1.TabIndex = 6;
            // 
            // pb_logo
            // 
            pb_logo.Location = new Point(14, 9);
            pb_logo.Margin = new Padding(3, 2, 3, 2);
            pb_logo.Name = "pb_logo";
            pb_logo.Size = new Size(35, 30);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.TabIndex = 0;
            pb_logo.TabStop = false;
            // 
            // btn_iniciar_sesion_iniciosesion
            // 
            btn_iniciar_sesion_iniciosesion.BackColor = Color.FromArgb(0, 122, 204);
            btn_iniciar_sesion_iniciosesion.FlatAppearance.BorderSize = 0;
            btn_iniciar_sesion_iniciosesion.FlatStyle = FlatStyle.Flat;
            btn_iniciar_sesion_iniciosesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_iniciar_sesion_iniciosesion.ForeColor = Color.White;
            btn_iniciar_sesion_iniciosesion.Location = new Point(84, 228);
            btn_iniciar_sesion_iniciosesion.Margin = new Padding(3, 2, 3, 2);
            btn_iniciar_sesion_iniciosesion.Name = "btn_iniciar_sesion_iniciosesion";
            btn_iniciar_sesion_iniciosesion.Size = new Size(140, 30);
            btn_iniciar_sesion_iniciosesion.TabIndex = 4;
            btn_iniciar_sesion_iniciosesion.Text = "Iniciar Sesión";
            btn_iniciar_sesion_iniciosesion.UseVisualStyleBackColor = false;
            // 
            // tb_contra_iniciosesion
            // 
            tb_contra_iniciosesion.BorderStyle = BorderStyle.FixedSingle;
            tb_contra_iniciosesion.Font = new Font("Segoe UI", 10F);
            tb_contra_iniciosesion.Location = new Point(84, 132);
            tb_contra_iniciosesion.Margin = new Padding(3, 2, 3, 2);
            tb_contra_iniciosesion.Name = "tb_contra_iniciosesion";
            tb_contra_iniciosesion.PasswordChar = '•';
            tb_contra_iniciosesion.Size = new Size(141, 25);
            tb_contra_iniciosesion.TabIndex = 3;
            tb_contra_iniciosesion.UseSystemPasswordChar = true;
            // 
            // tb_usuario_iniciosesion
            // 
            tb_usuario_iniciosesion.BorderStyle = BorderStyle.FixedSingle;
            tb_usuario_iniciosesion.Font = new Font("Segoe UI", 10F);
            tb_usuario_iniciosesion.Location = new Point(84, 84);
            tb_usuario_iniciosesion.Margin = new Padding(3, 2, 3, 2);
            tb_usuario_iniciosesion.Name = "tb_usuario_iniciosesion";
            tb_usuario_iniciosesion.Size = new Size(141, 25);
            tb_usuario_iniciosesion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(45, 45, 48);
            label2.Location = new Point(84, 114);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(45, 45, 48);
            label1.Location = new Point(84, 66);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // btn_salir_iniciosesion
            // 
            btn_salir_iniciosesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salir_iniciosesion.BackColor = Color.FromArgb(220, 53, 69);
            btn_salir_iniciosesion.FlatAppearance.BorderSize = 0;
            btn_salir_iniciosesion.FlatStyle = FlatStyle.Flat;
            btn_salir_iniciosesion.Font = new Font("Segoe UI", 9F);
            btn_salir_iniciosesion.ForeColor = Color.White;
            btn_salir_iniciosesion.Location = new Point(245, 318);
            btn_salir_iniciosesion.Margin = new Padding(3, 2, 3, 2);
            btn_salir_iniciosesion.Name = "btn_salir_iniciosesion";
            btn_salir_iniciosesion.Size = new Size(84, 24);
            btn_salir_iniciosesion.TabIndex = 5;
            btn_salir_iniciosesion.Text = "Salir";
            btn_salir_iniciosesion.UseVisualStyleBackColor = false;
            // 
            // lbl_version
            // 
            lbl_version.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_version.AutoSize = true;
            lbl_version.Font = new Font("Segoe UI", 8F);
            lbl_version.ForeColor = Color.Gray;
            lbl_version.Location = new Point(21, 327);
            lbl_version.Name = "lbl_version";
            lbl_version.Size = new Size(72, 13);
            lbl_version.TabIndex = 6;
            lbl_version.Text = "Versión 1.0.0";
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(350, 354);
            Controls.Add(lbl_version);
            Controls.Add(btn_salir_iniciosesion);
            Controls.Add(gb_inicio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btn_iniciar_sesion_iniciosesion;
        private TextBox tb_contra_iniciosesion;
        private TextBox tb_usuario_iniciosesion;
        private Button btn_salir_iniciosesion;
        private Panel panel1;
        private PictureBox pb_logo;
        private Label lbl_titulo;
        private Label lbl_version;
        private ComboBox cb_tipoUsuario_iniciosesion;
        private Label lblTipoUsuario;
    }
}