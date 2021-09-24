using System;
using System.Collections.Generic;
using System.Text;

namespace capaEntidades
{
    public class clsEmpleado:clsPersona
    {
        private string cargo;
        private string salario;

        public clsEmpleado() : base() { }

        public string Cargo { get => cargo; set => cargo = value; }
        public string Salario { get => salario; set => salario = value; }
    }
}
