 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        CD_Usuarios xObjUsu = new CD_Usuarios();

        public int CN_Verifica_Acceso(string Usuario, string Contraseña)
        {
            return xObjUsu.CD_Verificar_Acceso(Usuario, Contraseña);
        }

        public DataTable CN_LeerDatos_Usuario(string Usuario)
        {
            return xObjUsu.CD_LeerDatos_Usuario(Usuario);
        }

        public int CN_InsertarUsuario(string nombre, string telefono, string dni)
        {
            return xObjUsu.CD_InsertarUsuario(nombre, telefono, dni); 
        }
    }
}
