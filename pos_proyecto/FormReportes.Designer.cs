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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
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
            lblTitulo = new Label();
            panelHeader = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProCat
            // 
            PanelProCat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelProCat.BackColor = Color.White;
            PanelProCat.BorderStyle = BorderStyle.FixedSingle;
            PanelProCat.Location = new Point(280, 80);
            PanelProCat.Margin = new Padding(4);
            PanelProCat.Name = "PanelProCat";
            PanelProCat.Size = new Size(1024, 680);
            PanelProCat.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnAgregarCat);
            groupBox1.Controls.Add(btnAgregarPro);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(20, 80);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(252, 680);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones de Reportes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 100);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(220, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rango de Fechas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 65);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 7;
            label3.Text = "Hasta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(65, 60);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(145, 31);
            dateTimePicker2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 5;
            label2.Text = "Desde:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(65, 25);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(145, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Reporte:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ventas", "Inventario", "Clientes", "Compras", "Cortes de Caja", "Productos Más Vendidos", "Ventas por Vendedor" });
            comboBox1.Location = new Point(45, 65);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 33);
            comboBox1.TabIndex = 2;
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarCat.BackColor = Color.FromArgb(108, 117, 125);
            btnAgregarCat.FlatAppearance.BorderSize = 0;
            btnAgregarCat.FlatStyle = FlatStyle.Flat;
            btnAgregarCat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCat.ForeColor = Color.White;
            btnAgregarCat.Location = new Point(45, 620);
            btnAgregarCat.Margin = new Padding(4);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(162, 45);
            btnAgregarCat.TabIndex = 1;
            btnAgregarCat.Text = "Configurar Categorías";
            btnAgregarCat.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPro
            // 
            btnAgregarPro.BackColor = Color.FromArgb(0, 122, 204);
            btnAgregarPro.FlatAppearance.BorderSize = 0;
            btnAgregarPro.FlatStyle = FlatStyle.Flat;
            btnAgregarPro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPro.ForeColor = Color.White;
            btnAgregarPro.Location = new Point(45, 220);
            btnAgregarPro.Margin = new Padding(4);
            btnAgregarPro.Name = "btnAgregarPro";
            btnAgregarPro.Size = new Size(162, 50);
            btnAgregarPro.TabIndex = 0;
            btnAgregarPro.Text = "Generar Reporte";
            btnAgregarPro.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(80, 20);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 45);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Reportes";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1324, 70);
            panelHeader.TabIndex = 9;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1324, 780);
            Controls.Add(lblTitulo);
            Controls.Add(PanelProCat);
            Controls.Add(groupBox1);
            Controls.Add(panelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1346, 836);
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reportes - POS Refaccionaria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblTitulo;
        private Panel panelHeader;
    }
}