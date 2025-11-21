namespace pos_proyecto
{
    partial class FormCaja
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
            lblFecha = new Label();
            lblTurno = new Label();
            lblEmpleado = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnConfiguracion = new Button();
            btnHistorialCortes = new Button();
            btnFondosFijos = new Button();
            btnReportesFinancieros = new Button();
            btnMovimientosCaja = new Button();
            btnArqueoCaja = new Button();
            btnCorteCaja = new Button();
            btnAperturaCaja = new Button();
            groupBox3 = new GroupBox();
            lblDiferencias = new Label();
            lblEfectivoCaja = new Label();
            lblVentasHoy = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(lblTurno);
            groupBox1.Controls.Add(lblEmpleado);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 57);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Sesión";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(340, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(32, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "_____";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(185, 25);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(32, 15);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "_____";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(75, 25);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(32, 15);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "_____";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 25);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 4;
            label6.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 25);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "Turno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnConfiguracion);
            groupBox2.Controls.Add(btnHistorialCortes);
            groupBox2.Controls.Add(btnFondosFijos);
            groupBox2.Controls.Add(btnReportesFinancieros);
            groupBox2.Controls.Add(btnMovimientosCaja);
            groupBox2.Controls.Add(btnArqueoCaja);
            groupBox2.Controls.Add(btnCorteCaja);
            groupBox2.Controls.Add(btnAperturaCaja);
            groupBox2.Location = new Point(12, 85);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(500, 190);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operaciones de Caja";
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Location = new Point(375, 110);
            btnConfiguracion.Margin = new Padding(2);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(110, 65);
            btnConfiguracion.TabIndex = 14;
            btnConfiguracion.Text = "F8-Configuración";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnHistorialCortes
            // 
            btnHistorialCortes.Location = new Point(375, 30);
            btnHistorialCortes.Margin = new Padding(2);
            btnHistorialCortes.Name = "btnHistorialCortes";
            btnHistorialCortes.Size = new Size(110, 65);
            btnHistorialCortes.TabIndex = 13;
            btnHistorialCortes.Text = "F4-Historial Cortes";
            btnHistorialCortes.UseVisualStyleBackColor = true;
            // 
            // btnFondosFijos
            // 
            btnFondosFijos.Location = new Point(250, 110);
            btnFondosFijos.Margin = new Padding(2);
            btnFondosFijos.Name = "btnFondosFijos";
            btnFondosFijos.Size = new Size(110, 65);
            btnFondosFijos.TabIndex = 12;
            btnFondosFijos.Text = "F7-Fondos Fijos";
            btnFondosFijos.UseVisualStyleBackColor = true;
            // 
            // btnReportesFinancieros
            // 
            btnReportesFinancieros.Location = new Point(125, 110);
            btnReportesFinancieros.Margin = new Padding(2);
            btnReportesFinancieros.Name = "btnReportesFinancieros";
            btnReportesFinancieros.Size = new Size(110, 65);
            btnReportesFinancieros.TabIndex = 11;
            btnReportesFinancieros.Text = "F6-Reportes Financieros";
            btnReportesFinancieros.UseVisualStyleBackColor = true;
            // 
            // btnMovimientosCaja
            // 
            btnMovimientosCaja.Location = new Point(10, 110);
            btnMovimientosCaja.Margin = new Padding(2);
            btnMovimientosCaja.Name = "btnMovimientosCaja";
            btnMovimientosCaja.Size = new Size(110, 65);
            btnMovimientosCaja.TabIndex = 10;
            btnMovimientosCaja.Text = "F5-Movimientos Caja";
            btnMovimientosCaja.UseVisualStyleBackColor = true;
            // 
            // btnArqueoCaja
            // 
            btnArqueoCaja.Location = new Point(250, 30);
            btnArqueoCaja.Margin = new Padding(2);
            btnArqueoCaja.Name = "btnArqueoCaja";
            btnArqueoCaja.Size = new Size(110, 65);
            btnArqueoCaja.TabIndex = 6;
            btnArqueoCaja.Text = "F3-Arqueo Caja";
            btnArqueoCaja.UseVisualStyleBackColor = true;
            // 
            // btnCorteCaja
            // 
            btnCorteCaja.Location = new Point(125, 30);
            btnCorteCaja.Margin = new Padding(2);
            btnCorteCaja.Name = "btnCorteCaja";
            btnCorteCaja.Size = new Size(110, 65);
            btnCorteCaja.TabIndex = 5;
            btnCorteCaja.Text = "F2-Corte Caja";
            btnCorteCaja.UseVisualStyleBackColor = true;
            // 
            // btnAperturaCaja
            // 
            btnAperturaCaja.Location = new Point(10, 30);
            btnAperturaCaja.Margin = new Padding(2);
            btnAperturaCaja.Name = "btnAperturaCaja";
            btnAperturaCaja.Size = new Size(110, 65);
            btnAperturaCaja.TabIndex = 4;
            btnAperturaCaja.Text = "F1-Apertura Caja";
            btnAperturaCaja.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblDiferencias);
            groupBox3.Controls.Add(lblEfectivoCaja);
            groupBox3.Controls.Add(lblVentasHoy);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(12, 290);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(500, 150);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Estado Actual de Caja";
            // 
            // lblDiferencias
            // 
            lblDiferencias.AutoSize = true;
            lblDiferencias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiferencias.ForeColor = Color.Red;
            lblDiferencias.Location = new Point(340, 100);
            lblDiferencias.Name = "lblDiferencias";
            lblDiferencias.Size = new Size(45, 21);
            lblDiferencias.TabIndex = 8;
            lblDiferencias.Text = "$0.00";
            // 
            // lblEfectivoCaja
            // 
            lblEfectivoCaja.AutoSize = true;
            lblEfectivoCaja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEfectivoCaja.ForeColor = Color.Green;
            lblEfectivoCaja.Location = new Point(185, 100);
            lblEfectivoCaja.Name = "lblEfectivoCaja";
            lblEfectivoCaja.Size = new Size(45, 21);
            lblEfectivoCaja.TabIndex = 7;
            lblEfectivoCaja.Text = "$0.00";
            // 
            // lblVentasHoy
            // 
            lblVentasHoy.AutoSize = true;
            lblVentasHoy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentasHoy.Location = new Point(40, 100);
            lblVentasHoy.Name = "lblVentasHoy";
            lblVentasHoy.Size = new Size(45, 21);
            lblVentasHoy.TabIndex = 6;
            lblVentasHoy.Text = "$0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(340, 75);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 5;
            label12.Text = "$";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(185, 75);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 4;
            label11.Text = "$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 75);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 3;
            label10.Text = "$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(330, 40);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 2;
            label9.Text = "Diferencias";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 40);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 1;
            label8.Text = "Efectivo Caja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 40);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 0;
            label7.Text = "Ventas Hoy";
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 461);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormCaja";
            Text = "Módulo de Caja - POS Refaccionaria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblFecha;
        private Label lblTurno;
        private Label lblEmpleado;
        private Label label6;
        private Label label4;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnConfiguracion;
        private Button btnHistorialCortes;
        private Button btnFondosFijos;
        private Button btnReportesFinancieros;
        private Button btnMovimientosCaja;
        private Button btnArqueoCaja;
        private Button btnCorteCaja;
        private Button btnAperturaCaja;
        private GroupBox groupBox3;
        private Label lblDiferencias;
        private Label lblEfectivoCaja;
        private Label lblVentasHoy;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}