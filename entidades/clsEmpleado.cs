using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class clsEmpleado:clsPersona
    {
        private string cargo;
        private string salario;

        public string Cargo { get => cargo; set => cargo = value; }
        public string Salario { get => salario; set => salario = value; }
    }
}
