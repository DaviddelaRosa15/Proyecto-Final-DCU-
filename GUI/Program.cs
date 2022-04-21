using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas;

namespace GUI
{
    internal static class Program
    {
        public static bool validacionEntidades = false;

        //public static bool validacionAcceso = false;
        //public static string tipoUsuario = UserCache.tipo;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Dominio dominio = new Dominio();
            //validacionEntidades = dominio.validarExistenciaEntidades();
            //if (validacionEntidades)
            //{
            //    Application.Run(new FormLogin());
            //}
            //else
            //{
            //    Application.Run(new FormSplashForm());
            //    Application.Run(new FormDirector());
            //}
            Application.Run(new FormDocumentacion());
        }
    }
}
