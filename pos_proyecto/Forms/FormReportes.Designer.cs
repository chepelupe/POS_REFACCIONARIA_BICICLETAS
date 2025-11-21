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
            ppc_reportes = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            dtp_reportes_2 = new DateTimePicker();
            label2 = new Label();
            dtp_reportes_1 = new DateTimePicker();
            label1 = new Label();
            cb_tipo_reportes = new ComboBox();
            btn_configurar_reportes = new Button();
            btn_generar_reportes = new Button();
            lblTitulo = new Label();
            panelHeader = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ppc_reportes
            // 
            ppc_reportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ppc_reportes.BackColor = Color.White;
            ppc_reportes.BorderStyle = BorderStyle.FixedSingle;
            ppc_reportes.Location = new Point(196, 48);
            ppc_reportes.Margin = new Padding(3, 2, 3, 2);
            ppc_reportes.Name = "ppc_reportes";
            ppc_reportes.Size = new Size(717, 409);
            ppc_reportes.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cb_tipo_reportes);
            groupBox1.Controls.Add(btn_configurar_reportes);
            groupBox1.Controls.Add(btn_generar_reportes);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 48);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(176, 408);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones de Reportes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtp_reportes_2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtp_reportes_1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(10, 60);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(154, 60);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rango de Fechas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 39);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Hasta:";
            // 
            // dtp_reportes_2
            // 
            dtp_reportes_2.CustomFormat = "dd/MM/yyyy";
            dtp_reportes_2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_reportes_2.Format = DateTimePickerFormat.Short;
            dtp_reportes_2.Location = new Point(46, 36);
            dtp_reportes_2.Margin = new Padding(3, 2, 3, 2);
            dtp_reportes_2.Name = "dtp_reportes_2";
            dtp_reportes_2.Size = new Size(103, 23);
            dtp_reportes_2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 18);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Desde:";
            // 
            // dtp_reportes_1
            // 
            dtp_reportes_1.CustomFormat = "dd/MM/yyyy";
            dtp_reportes_1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_reportes_1.Format = DateTimePickerFormat.Short;
            dtp_reportes_1.Location = new Point(46, 15);
            dtp_reportes_1.Margin = new Padding(3, 2, 3, 2);
            dtp_reportes_1.Name = "dtp_reportes_1";
            dtp_reportes_1.Size = new Size(103, 23);
            dtp_reportes_1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Reporte:";
            // 
            // cb_tipo_reportes
            // 
            cb_tipo_reportes.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipo_reportes.FlatStyle = FlatStyle.Flat;
            cb_tipo_reportes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_tipo_reportes.FormattingEnabled = true;
            cb_tipo_reportes.Items.AddRange(new object[] { "Ventas", "Inventario", "Clientes", "Compras", "Cortes de Caja", "Productos Más Vendidos", "Ventas por Vendedor" });
            cb_tipo_reportes.Location = new Point(32, 39);
            cb_tipo_reportes.Margin = new Padding(3, 2, 3, 2);
            cb_tipo_reportes.Name = "cb_tipo_reportes";
            cb_tipo_reportes.Size = new Size(115, 23);
            cb_tipo_reportes.TabIndex = 2;
            // 
            // btn_configurar_reportes
            // 
            btn_configurar_reportes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_configurar_reportes.BackColor = Color.FromArgb(108, 117, 125);
            btn_configurar_reportes.FlatAppearance.BorderSize = 0;
            btn_configurar_reportes.FlatStyle = FlatStyle.Flat;
            btn_configurar_reportes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_configurar_reportes.ForeColor = Color.White;
            btn_configurar_reportes.Location = new Point(32, 372);
            btn_configurar_reportes.Margin = new Padding(3, 2, 3, 2);
            btn_configurar_reportes.Name = "btn_configurar_reportes";
            btn_configurar_reportes.Size = new Size(113, 27);
            btn_configurar_reportes.TabIndex = 1;
            btn_configurar_reportes.Text = "Configurar Categorías";
            btn_configurar_reportes.UseVisualStyleBackColor = false;
            // 
            // btn_generar_reportes
            // 
            btn_generar_reportes.BackColor = Color.FromArgb(0, 122, 204);
            btn_generar_reportes.FlatAppearance.BorderSize = 0;
            btn_generar_reportes.FlatStyle = FlatStyle.Flat;
            btn_generar_reportes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_generar_reportes.ForeColor = Color.White;
            btn_generar_reportes.Location = new Point(32, 132);
            btn_generar_reportes.Margin = new Padding(3, 2, 3, 2);
            btn_generar_reportes.Name = "btn_generar_reportes";
            btn_generar_reportes.Size = new Size(113, 30);
            btn_generar_reportes.TabIndex = 0;
            btn_generar_reportes.Text = "Generar Reporte";
            btn_generar_reportes.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(56, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(106, 30);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Reportes";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(931, 42);
            panelHeader.TabIndex = 9;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(931, 449);
            Controls.Add(lblTitulo);
            Controls.Add(ppc_reportes);
            Controls.Add(groupBox1);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(947, 446);
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

        private Panel ppc_reportes;
        private GroupBox groupBox1;
        private ComboBox cb_tipo_reportes;
        private Button btn_configurar_reportes;
        private Button btn_generar_reportes;
        private GroupBox groupBox2;
        private Label label3;
        private DateTimePicker dtp_reportes_2;
        private Label label2;
        private DateTimePicker dtp_reportes_1;
        private Label label1;
        private Label lblTitulo;
        private Panel panelHeader;
    }
}