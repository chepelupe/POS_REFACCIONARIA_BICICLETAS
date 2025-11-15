namespace pos_proyecto
{
    partial class FormMenuAgregarProductos
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
            groupBox1 = new GroupBox();
            btnAgregarCat = new Button();
            btnAgregarPro = new Button();
            PanelProCat = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarCat);
            groupBox1.Controls.Add(btnAgregarPro);
            groupBox1.Location = new Point(31, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(169, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones agregar";
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.Location = new Point(28, 155);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(112, 66);
            btnAgregarCat.TabIndex = 1;
            btnAgregarCat.Text = "Agregar categoría";
            btnAgregarCat.UseVisualStyleBackColor = true;
            btnAgregarCat.Click += btnAgregarCat_Click;
            // 
            // btnAgregarPro
            // 
            btnAgregarPro.Location = new Point(28, 59);
            btnAgregarPro.Name = "btnAgregarPro";
            btnAgregarPro.Size = new Size(112, 66);
            btnAgregarPro.TabIndex = 0;
            btnAgregarPro.Text = "Agregar producto";
            btnAgregarPro.UseVisualStyleBackColor = true;
            btnAgregarPro.Click += btnAgregarPro_Click;
            // 
            // PanelProCat
            // 
            PanelProCat.Location = new Point(288, 51);
            PanelProCat.Name = "PanelProCat";
            PanelProCat.Size = new Size(451, 360);
            PanelProCat.TabIndex = 1;
            // 
            // FormMenuAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelProCat);
            Controls.Add(groupBox1);
            Name = "FormMenuAgregar";
            Text = "FormMenuAgregar";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAgregarCat;
        private Button btnAgregarPro;
        private Panel PanelProCat;
    }
}