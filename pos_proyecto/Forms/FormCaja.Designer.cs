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
            lbl_fecha_caja = new Label();
            lbl_turno_caja = new Label();
            lbl_empleado_caja = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_configuracion_caja = new Button();
            btn_historialCortes_caja = new Button();
            btn_fondosFijos_caja = new Button();
            btn_reportesFinancieros_caja = new Button();
            btn_movimientosCaja_caja = new Button();
            btn_arqueoCaja_caja = new Button();
            btn_corteCaja_caja = new Button();
            btn_aperturaCaja_caja = new Button();
            groupBox3 = new GroupBox();
            lbl_diferencias_caja = new Label();
            lbl_efectivoCaja_caja = new Label();
            lbl_ventasHoy_caja = new Label();
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
            groupBox1.Controls.Add(lbl_fecha_caja);
            groupBox1.Controls.Add(lbl_turno_caja);
            groupBox1.Controls.Add(lbl_empleado_caja);
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
            // lbl_fecha_caja
            // 
            lbl_fecha_caja.AutoSize = true;
            lbl_fecha_caja.Location = new Point(340, 25);
            lbl_fecha_caja.Name = "lbl_fecha_caja";
            lbl_fecha_caja.Size = new Size(32, 15);
            lbl_fecha_caja.TabIndex = 5;
            lbl_fecha_caja.Text = "_____";
            // 
            // lbl_turno_caja
            // 
            lbl_turno_caja.AutoSize = true;
            lbl_turno_caja.Location = new Point(185, 25);
            lbl_turno_caja.Name = "lbl_turno_caja";
            lbl_turno_caja.Size = new Size(32, 15);
            lbl_turno_caja.TabIndex = 3;
            lbl_turno_caja.Text = "_____";
            // 
            // lbl_empleado_caja
            // 
            lbl_empleado_caja.AutoSize = true;
            lbl_empleado_caja.Location = new Point(75, 25);
            lbl_empleado_caja.Name = "lbl_empleado_caja";
            lbl_empleado_caja.Size = new Size(32, 15);
            lbl_empleado_caja.TabIndex = 1;
            lbl_empleado_caja.Text = "_____";
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
            groupBox2.Controls.Add(btn_configuracion_caja);
            groupBox2.Controls.Add(btn_historialCortes_caja);
            groupBox2.Controls.Add(btn_fondosFijos_caja);
            groupBox2.Controls.Add(btn_reportesFinancieros_caja);
            groupBox2.Controls.Add(btn_movimientosCaja_caja);
            groupBox2.Controls.Add(btn_arqueoCaja_caja);
            groupBox2.Controls.Add(btn_corteCaja_caja);
            groupBox2.Controls.Add(btn_aperturaCaja_caja);
            groupBox2.Location = new Point(12, 85);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(500, 190);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operaciones de Caja";
            // 
            // btn_configuracion_caja
            // 
            btn_configuracion_caja.Location = new Point(375, 110);
            btn_configuracion_caja.Margin = new Padding(2);
            btn_configuracion_caja.Name = "btn_configuracion_caja";
            btn_configuracion_caja.Size = new Size(110, 65);
            btn_configuracion_caja.TabIndex = 14;
            btn_configuracion_caja.Text = "F8-Configuración";
            btn_configuracion_caja.UseVisualStyleBackColor = true;
            // 
            // btn_historialCortes_caja
            // 
            btn_historialCortes_caja.Location = new Point(375, 30);
            btn_historialCortes_caja.Margin = new Padding(2);
            btn_historialCortes_caja.Name = "btn_historialCortes_caja";
            btn_historialCortes_caja.Size = new Size(110, 65);
            btn_historialCortes_caja.TabIndex = 13;
            btn_historialCortes_caja.Text = "F4-Historial Cortes";
            btn_historialCortes_caja.UseVisualStyleBackColor = true;
            // 
            // btn_fondosFijos_caja
            // 
            btn_fondosFijos_caja.Location = new Point(250, 110);
            btn_fondosFijos_caja.Margin = new Padding(2);
            btn_fondosFijos_caja.Name = "btn_fondosFijos_caja";
            btn_fondosFijos_caja.Size = new Size(110, 65);
            btn_fondosFijos_caja.TabIndex = 12;
            btn_fondosFijos_caja.Text = "F7-Fondos Fijos";
            btn_fondosFijos_caja.UseVisualStyleBackColor = true;
            // 
            // btn_reportesFinancieros_caja
            // 
            btn_reportesFinancieros_caja.Location = new Point(125, 110);
            btn_reportesFinancieros_caja.Margin = new Padding(2);
            btn_reportesFinancieros_caja.Name = "btn_reportesFinancieros_caja";
            btn_reportesFinancieros_caja.Size = new Size(110, 65);
            btn_reportesFinancieros_caja.TabIndex = 11;
            btn_reportesFinancieros_caja.Text = "F6-Reportes Financieros";
            btn_reportesFinancieros_caja.UseVisualStyleBackColor = true;
            // 
            // btn_movimientosCaja_caja
            // 
            btn_movimientosCaja_caja.Location = new Point(10, 110);
            btn_movimientosCaja_caja.Margin = new Padding(2);
            btn_movimientosCaja_caja.Name = "btn_movimientosCaja_caja";
            btn_movimientosCaja_caja.Size = new Size(110, 65);
            btn_movimientosCaja_caja.TabIndex = 10;
            btn_movimientosCaja_caja.Text = "F5-Movimientos Caja";
            btn_movimientosCaja_caja.UseVisualStyleBackColor = true;
            // 
            // btn_arqueoCaja_caja
            // 
            btn_arqueoCaja_caja.Location = new Point(250, 30);
            btn_arqueoCaja_caja.Margin = new Padding(2);
            btn_arqueoCaja_caja.Name = "btn_arqueoCaja_caja";
            btn_arqueoCaja_caja.Size = new Size(110, 65);
            btn_arqueoCaja_caja.TabIndex = 6;
            btn_arqueoCaja_caja.Text = "F3-Arqueo Caja";
            btn_arqueoCaja_caja.UseVisualStyleBackColor = true;
            // 
            // btn_corteCaja_caja
            // 
            btn_corteCaja_caja.Location = new Point(125, 30);
            btn_corteCaja_caja.Margin = new Padding(2);
            btn_corteCaja_caja.Name = "btn_corteCaja_caja";
            btn_corteCaja_caja.Size = new Size(110, 65);
            btn_corteCaja_caja.TabIndex = 5;
            btn_corteCaja_caja.Text = "F2-Corte Caja";
            btn_corteCaja_caja.UseVisualStyleBackColor = true;
            // 
            // btn_aperturaCaja_caja
            // 
            btn_aperturaCaja_caja.Location = new Point(10, 30);
            btn_aperturaCaja_caja.Margin = new Padding(2);
            btn_aperturaCaja_caja.Name = "btn_aperturaCaja_caja";
            btn_aperturaCaja_caja.Size = new Size(110, 65);
            btn_aperturaCaja_caja.TabIndex = 4;
            btn_aperturaCaja_caja.Text = "F1-Apertura Caja";
            btn_aperturaCaja_caja.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_diferencias_caja);
            groupBox3.Controls.Add(lbl_efectivoCaja_caja);
            groupBox3.Controls.Add(lbl_ventasHoy_caja);
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
            // lbl_diferencias_caja
            // 
            lbl_diferencias_caja.AutoSize = true;
            lbl_diferencias_caja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_diferencias_caja.ForeColor = Color.Red;
            lbl_diferencias_caja.Location = new Point(340, 100);
            lbl_diferencias_caja.Name = "lbl_diferencias_caja";
            lbl_diferencias_caja.Size = new Size(50, 21);
            lbl_diferencias_caja.TabIndex = 8;
            lbl_diferencias_caja.Text = "$0.00";
            // 
            // lbl_efectivoCaja_caja
            // 
            lbl_efectivoCaja_caja.AutoSize = true;
            lbl_efectivoCaja_caja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_efectivoCaja_caja.ForeColor = Color.Green;
            lbl_efectivoCaja_caja.Location = new Point(185, 100);
            lbl_efectivoCaja_caja.Name = "lbl_efectivoCaja_caja";
            lbl_efectivoCaja_caja.Size = new Size(50, 21);
            lbl_efectivoCaja_caja.TabIndex = 7;
            lbl_efectivoCaja_caja.Text = "$0.00";
            // 
            // lbl_ventasHoy_caja
            // 
            lbl_ventasHoy_caja.AutoSize = true;
            lbl_ventasHoy_caja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ventasHoy_caja.Location = new Point(40, 100);
            lbl_ventasHoy_caja.Name = "lbl_ventasHoy_caja";
            lbl_ventasHoy_caja.Size = new Size(50, 21);
            lbl_ventasHoy_caja.TabIndex = 6;
            lbl_ventasHoy_caja.Text = "$0.00";
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
        private Label lbl_fecha_caja;
        private Label lbl_turno_caja;
        private Label lbl_empleado_caja;
        private Label label6;
        private Label label4;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_configuracion_caja;
        private Button btn_historialCortes_caja;
        private Button btn_fondosFijos_caja;
        private Button btn_reportesFinancieros_caja;
        private Button btn_movimientosCaja_caja;
        private Button btn_arqueoCaja_caja;
        private Button btn_corteCaja_caja;
        private Button btn_aperturaCaja_caja;
        private GroupBox groupBox3;
        private Label lbl_diferencias_caja;
        private Label lbl_efectivoCaja_caja;
        private Label lbl_ventasHoy_caja;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}