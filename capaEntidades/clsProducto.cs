using System;
using System.Collections.Generic;
using System.Text;

namespace capaEntidades
{
    public class clsProducto
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private double precio;
        private string descuento;

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; set; }
    }
}
