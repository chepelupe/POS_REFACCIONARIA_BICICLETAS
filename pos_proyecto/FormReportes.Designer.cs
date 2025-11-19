namespace pos_proyecto
{
    partial class FormReportes
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
            PanelProCat = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnAgregarCat = new Button();
            btnAgregarPro = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProCat
            // 
            PanelProCat.Location = new Point(228, 11);
            PanelProCat.Margin = new Padding(2);
            PanelProCat.Name = "PanelProCat";
            PanelProCat.Size = new Size(890, 544);
            PanelProCat.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnAgregarCat);
            groupBox1.Controls.Add(btnAgregarPro);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(213, 381);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones agregar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(5, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 72);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selección de fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 48);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Hasta";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(44, 46);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(157, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 19);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Desde";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(44, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 31);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "Categoría del reporte";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.Location = new Point(69, 341);
            btnAgregarCat.Margin = new Padding(2);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(78, 40);
            btnAgregarCat.TabIndex = 1;
            btnAgregarCat.Text = "Agregar categoría";
            btnAgregarCat.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPro
            // 
            btnAgregarPro.Location = new Point(69, 155);
            btnAgregarPro.Margin = new Padding(2);
            btnAgregarPro.Name = "btnAgregarPro";
            btnAgregarPro.Size = new Size(78, 40);
            btnAgregarPro.TabIndex = 0;
            btnAgregarPro.Text = "Generar Reporte";
            btnAgregarPro.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 566);
            Controls.Add(PanelProCat);
            Controls.Add(groupBox1);
            Name = "FormReportes";
            Text = "FormReportes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProCat;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Button btnAgregarCat;
        private Button btnAgregarPro;
        private GroupBox groupBox2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}