using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class CD_Usuarios
    {
        private int _Id_Usu;
        private string _Nombres;
        private string _Apellidos;
        private string _Usuario;
        private string _Contraseña;
        private string _Ubicacion_Foto;
        private int _Id_Rol;
        private bool _Estado;

        public int Id_Usu { get => _Id_Usu; set => _Id_Usu = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string Ubicacion_Foto { get => _Ubicacion_Foto; set => _Ubicacion_Foto = value; }
        public int Id_Rol { get => _Id_Rol; set => _Id_Rol = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }

        private CD_Conexion Conexion = new CD_Conexion();

        public int CD_Verificar_Acceso(string Usuario, string Contraseña)
        {
            SqlCommand Cmd = null;
            try
            {
                Cmd = new SqlCommand("Sp_Login", Conexion.AbrirConexion());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Usuario", Usuario);
                Cmd.Parameters.AddWithValue("@Contrasena", Contraseña);
                int encontro = Convert.ToInt16(Cmd.ExecuteScalar());
                return encontro;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error " + ex.Message, "Ayuda",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            return 0;
        }

        public DataTable CD_LeerDatos_Usuario(string Usuario)
        {
            SqlDataAdapter da = null;
            try
            {
                da = new SqlDataAdapter("Sp_Usuario_Login", Conexion.AbrirConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Usuario", Usuario);
                DataTable xUsu = new DataTable();
                da.Fill(xUsu);
                return xUsu;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error " + ex.Message, "Ayuda",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            return null;
        }

        public int CD_InsertarUsuario(string nombre, string telefono, string dni)
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("Sp_InsertarCliente", Conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Dni", dni);


                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; 
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

    }
}
