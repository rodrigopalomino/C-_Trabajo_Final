using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    internal class CD_Pacientes
    {
        private int _idPaciente;
        private int _owner;
        private string _nombre;
        private string _sexo;
        private string _especie;
        private string _raza;
        private DateTime _fechanac;

        #region Getters and Setters
        public int IdPaciente { get => _idPaciente; set => _idPaciente = value; }
        public int Owner { get => _owner; set => _owner = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Especie { get => _especie; set => _especie = value; }
        public string Raza { get => _raza; set => _raza = value; }
        public DateTime Fechanac { get => _fechanac; set => _fechanac = value; }

        #endregion


    }
}
