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
                Console.WriteLine(Program.Info_Organización_Session.xApellidos);
                Frm_Principal frm = new Frm_Principal();
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



        private void txt_Click(object sender, EventArgs e)
        {
            TextBox ClickTextBox = (TextBox)sender;

            if (ClickTextBox.Text == "Ingrese su nombre de usuario" || ClickTextBox.Text == "******************") {
                ClickTextBox.Text = "";
            }

            ClickTextBox.ForeColor = Color.Black;

        
        }

        private void txt_leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Name == "txtUsuario") {
                if (textBox.Text == "")
                {
                    textBox.ForeColor = Color.DarkGray;
                    textBox.Text = "Ingrese su nombre de usuario";
                }
            }
            if(textBox.Name == "txtClave")
            {
                if (textBox.Text == "")
                {
                    textBox.ForeColor = Color.DarkGray;
                    textBox.Text = "******************";
                }
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(1, 200, 154);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(1, 110, 154);

        }
    }
}
