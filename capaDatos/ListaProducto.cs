using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;

namespace capaDatos
{
    public class ListaProducto
    {
        static List<object> lista = new List<object>();
        public ListaProducto Lista { get; set; }

        public static void add(Object p)
        {
            lista.Add(p);
        }

        public static clsProducto buscar(int id)
        {
            clsProducto res = null;
            foreach (clsProducto p in lista)
            {
                if (p.Codigo == id)
                {
                    res = p;
                    break;
                }

            }
            return res;
        }
        public static void actualizar(List<String> l)
        {
            foreach (clsProducto p in lista)
            {
                if (p.Codigo == Convert.ToInt32(l[0]))
                {
                    p.Precio = Convert.ToDouble(l[1]);
                    p.Descuento = Convert.ToDouble(l[2]);
                    break;
                }
            }
        }

        public static void eliminar(int id)
        {
            try
            {
                foreach (clsProducto e in lista)
                {
                    if (e.Codigo == id)
                    {
                        lista.Remove(e);
                    }
                }
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Producto no encontrado");
            }
        }
    }
}
