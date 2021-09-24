using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class clsCliente:clsPersona
    {
        private string ciudad;
        private string barrio;
        private string calle;
        private string carrera;
        private string casa;

        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Barrio { get => barrio; set => barrio = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Casa { get => casa; set => casa = value; }
    }
}
