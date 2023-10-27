using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }

        public class Info_Organización_Session
        {
            public static string xOrganizacion = "Clinica TresPatas - Sede Huaycan";
            public static string xDirec = "Av. Nose Huaycan";
            public static string xTelef1 = "01-567-9000";
            public static string xTelef2 = "(RPC)976-567-9000";
            public static string xTelef3 = "(RPM)601-567-9000";
            public static string xLema = "nya";
            public static int xId_Usuario;
            public static string xUsuario = "";
            public static string xClave = "";
            public static string xRol = "";
            public static int xId_Rol = 0;
            public static string xNombres = "";
            public static string xApellidos = "";
            public static string xFoto = "";
        }
    }
}
