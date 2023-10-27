﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Conexion
    {
        public string nombre_servidor;
        private SqlConnection Conexion;
        public CD_Conexion()
        {
            nombre_servidor = Dns.GetHostName();
            Conexion = new SqlConnection("Data Source=" + nombre_servidor + "; Initial Catalog=BDClinica; Integrated Security=True");
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}