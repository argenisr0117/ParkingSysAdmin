using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoAdministracion
{
    static class Program
    {
        public static int Evento;
        public static int id = 0;
        public static string UserId;
        public static string UserName;
        public static string TipoUsuario;
        public static bool Activate;
        public static int Idempresa;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
