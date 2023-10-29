using Capa_Negocio;
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
    public partial class Form1 : Form
    {
        private string op;
        public Form1(string opc)
        {
            InitializeComponent();
            op = opc;
            if(op=="Nuevo Cliente")
            {
                label1.Text = "Nombre";
                label2.Text = "Telefono";
                label3.Text = "DNI";
                listBox1.Hide();
                label5.Hide(); 
                label6.Hide();  
                dateTimePicker1.Hide();
                textBox6.Hide();
            }
            else if (op == "Nuevo Paciente")
            {
                label1.Text = "Nombre";
                label2.Text = "Edad";
                label3.Text = "Peso";
                label5.Text="Cumpleaños";
                label6.Text = "Observaciones";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra Form1

            // Verifica si existe una instancia del formulario principal
            Frm_Principal frmPrincipal = Application.OpenForms["Frm_Principal"] as Frm_Principal;
            if (frmPrincipal != null)
            {
                frmPrincipal.Show(); // Muestra el formulario principal
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(op);
            if (op=="Nuevo Cliente")
            {
                var nombre = textBox1.Text.Trim();
                var telefono = textBox2.Text.Trim();
                var dni = textBox3.Text.Trim();
                CN_Usuarios xUsuarios= new CN_Usuarios();
                xUsuarios.CN_InsertarUsuario(nombre, telefono, dni);
                this.Close();
                Frm_Principal frmPrincipal = Application.OpenForms["Frm_Principal"] as Frm_Principal;
                if (frmPrincipal != null)
                {
                    frmPrincipal.Show(); // Muestra el formulario principal
                }
            }
        }
    }
}
