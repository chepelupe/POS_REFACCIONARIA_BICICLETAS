using System;
using System.Windows.Forms;

namespace pos_proyecto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar con el formulario de login
            Application.Run(new FormInicioSesion());
        }
    }
}