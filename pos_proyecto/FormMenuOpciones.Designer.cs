namespace pos_proyecto
{
    partial class FormMenuOpciones
    {
        private System.ComponentModel.IContainer components = null;
        private Button btn_inventario;
        private Button btn_proveedores;
        private Button btn_ventas;
        private Button btn_salir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Text = "Menú de Opciones";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Botón Inventario
            btn_inventario = new Button();
            btn_inventario.Text = "Módulo Inventario";
            btn_inventario.Size = new System.Drawing.Size(200, 40);
            btn_inventario.Location = new System.Drawing.Point(100, 30);
            this.Controls.Add(btn_inventario);

            // Botón Proveedores
            btn_proveedores = new Button();
            btn_proveedores.Text = "Módulo Proveedores";
            btn_proveedores.Size = new System.Drawing.Size(200, 40);
            btn_proveedores.Location = new System.Drawing.Point(100, 90);
            this.Controls.Add(btn_proveedores);

            // Botón Ventas
            btn_ventas = new Button();
            btn_ventas.Text = "Regresar a Ventas";
            btn_ventas.Size = new System.Drawing.Size(200, 40);
            btn_ventas.Location = new System.Drawing.Point(100, 150);
            this.Controls.Add(btn_ventas);

            // Botón Salir
            btn_salir = new Button();
            btn_salir.Text = "Salir";
            btn_salir.Size = new System.Drawing.Size(200, 40);
            btn_salir.Location = new System.Drawing.Point(100, 210);
            this.Controls.Add(btn_salir);
        }
    }
}