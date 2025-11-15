namespace pos_proyecto
{
    partial class FormInicioSesioncs
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
            button1 = new Button();
            btn_iniciar_sesion = new Button();
            tb_contra = new TextBox();
            tb_usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_salir = new Button();
            gb_inicio.SuspendLayout();
            SuspendLayout();
            // 
            // gb_inicio
            // 
            gb_inicio.Controls.Add(button1);
            gb_inicio.Controls.Add(btn_iniciar_sesion);
            gb_inicio.Controls.Add(tb_contra);
            gb_inicio.Controls.Add(tb_usuario);
            gb_inicio.Controls.Add(label2);
            gb_inicio.Controls.Add(label1);
            gb_inicio.Location = new Point(94, 28);
            gb_inicio.Name = "gb_inicio";
            gb_inicio.Size = new Size(317, 298);
            gb_inicio.TabIndex = 0;
            gb_inicio.TabStop = false;
            gb_inicio.Text = "Inicio";
            // 
            // button1
            // 
            button1.Location = new Point(163, 191);
            button1.Name = "button1";
            button1.Size = new Size(112, 67);
            button1.TabIndex = 5;
            button1.Text = "Ayuda";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_iniciar_sesion
            // 
            btn_iniciar_sesion.Location = new Point(22, 191);
            btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            btn_iniciar_sesion.Size = new Size(112, 67);
            btn_iniciar_sesion.TabIndex = 4;
            btn_iniciar_sesion.Text = "Iniciar Sesión";
            btn_iniciar_sesion.UseVisualStyleBackColor = true;
            // 
            // tb_contra
            // 
            tb_contra.Location = new Point(145, 127);
            tb_contra.Name = "tb_contra";
            tb_contra.PasswordChar = '*';
            tb_contra.Size = new Size(150, 31);
            tb_contra.TabIndex = 3;
            tb_contra.UseSystemPasswordChar = true;
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(145, 49);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(150, 31);
            tb_usuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 127);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 49);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(201, 344);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 67);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // FormInicioSesioncs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 430);
            Controls.Add(btn_salir);
            Controls.Add(gb_inicio);
            Name = "FormInicioSesioncs";
            Text = "FormInicioSesioncs";
            gb_inicio.ResumeLayout(false);
            gb_inicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_inicio;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button btn_iniciar_sesion;
        private TextBox tb_contra;
        private TextBox tb_usuario;
        private Button btn_salir;
    }
}