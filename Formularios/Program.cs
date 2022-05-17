using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    static class Program
    {
        public static Empleado logueado;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Mock.Iniciar();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
