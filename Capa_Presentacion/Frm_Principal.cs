using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            DateTime fecha=DateTime.Now;
            // Aquí puedes inicializar los elementos de tu formulario con la información del usuario
            usuario_nombre.Text = "Bienvenido "+Program.Info_Organización_Session.xNombres;
            label2.Text=fecha.ToLongDateString().ToUpper();

            if (Program.Info_Organización_Session.xId_Rol == 1)
            {
                button1.Text = "Usuarios";
                button3.Text = "Informacion Total";
                button2.Hide();
            }
            else if (Program.Info_Organización_Session.xId_Rol == 2)
            {
                button1.Text = "Reporte";
                button2.Text = "Citas Hoy";
                button3.Text = "Mis Pacientes";
            }
            else
            {
                button1.Text = "Nuevo Cliente";
                button2.Text = "Nuevo Paciente";
                button3.Text = "Agendar Cita";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opc = button1.Text;
            Hide();
            if (opc == "Usuarios") { }
            else if (opc == "Reporte") { }
            else { Form1 frm = new Form1(opc); frm.ShowDialog(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var opc = button2.Text;
            Console.WriteLine(opc);
            Hide();
            if (opc == "Citas Hoy") { }
            else { Form1 frm = new Form1(opc); frm.ShowDialog(); }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDClinicaPetDataSet.Citas' Puede moverla o quitarla según sea necesario.
            //this.citasTableAdapter.Fill(this.bDClinicaPetDataSet.Citas);

        }
    }
}
