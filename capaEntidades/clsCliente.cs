using System;
using System.Collections.Generic;
using System.Text;

namespace capaEntidades
{
    public class clsCliente:clsPersona
    {
        private string ciudad;
        private string barrio;
        private string calle;
        private string carrera;
        private string casa;

        public clsCliente() : base() { }

        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Barrio { get => barrio; set => barrio = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Casa { get => casa; set => casa = value; }
    }
}
