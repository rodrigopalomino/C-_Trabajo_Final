using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txtUsuario, "Ingrese usuario");
            toolTip2.SetToolTip(txtClave, "Ingrese clave");

        }
        static int xVeces = 0;
        Frm_Principal frm = new Frm_Principal();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CN_Usuarios xUsuario = new CN_Usuarios();
            string u = txtUsuario.Text.ToString().Trim();
            string c = txtClave.Text.ToString().Trim();

            if (xUsuario.CN_Verifica_Acceso(u, c) == 1)
            {
                //--------------Carga de Datos del Usuario
                Program.Info_Organización_Session.xUsuario = u;
                Program.Info_Organización_Session.xClave = c;
                DataTable xDatos = xUsuario.CN_LeerDatos_Usuario(u);
                if (xDatos.Rows.Count == 1)
                {
                    Program.Info_Organización_Session.xId_Usuario = Convert.ToInt16(xDatos.Rows[0]["Id_Usu"]);
                    Program.Info_Organización_Session.xApellidos = xDatos.Rows[0]["Apellidos"].ToString();
                    Program.Info_Organización_Session.xNombres = xDatos.Rows[0]["Nombres"].ToString();
                    Program.Info_Organización_Session.xRol = xDatos.Rows[0]["Rol"].ToString();
                    Program.Info_Organización_Session.xId_Rol = Convert.ToInt32(xDatos.Rows[0]["Id_Rol"].ToString());
                    Program.Info_Organización_Session.xFoto = xDatos.Rows[0]["Ubicacion_Foto"].ToString();
                }
                //---------------
                MessageBox.Show("Bienvenido",
                    Program.Info_Organización_Session.xOrganizacion,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //---------------
                Hide();
                //---------------

                frm.ShowDialog();
                //---------------
            }
            else
            {
                xVeces++;
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtmensajenologea.Text = "Intento Nro : " + xVeces + "  Usuario u contraseña no validos";
                txtUsuario.Focus();
            }
            if (xVeces == 3)
            {
                MessageBox.Show("Ud. ha sobrepasado los intentos permitidos\n" +
                    "-Cierre del Sistma !!!!",
                    Program.Info_Organización_Session.xOrganizacion,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);



                Application.Exit();
            }
        }
    }
}
