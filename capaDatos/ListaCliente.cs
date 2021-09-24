using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;

namespace capaDatos
{
    public class ListaCliente
    {
        static List<Object> lista = new List<Object>();

        public ListaEmpleado Lista { get; set; }

        public static void add(Object p)
        {
            lista.Add(p);
        }

        public static clsCliente buscar(string id)
        {
            clsCliente res = null;
            foreach (clsCliente p in lista)
            {
                if (p.Documento.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    res = p;
                    break;
                }
            }
            return res;
        }
        public static void actualizar(List<String> l)
        {
            foreach (clsCliente c in lista)
            {
                if (c.Documento.Equals(l[0]))
                {
                    c.Telefono = l[1];
                    c.Barrio = l[2];
                    c.Carrera = l[3];
                    c.Calle = l[4];
                    c.Casa = l[5];
                    break;
                }
            }
        }
        public static void eliminar(string id)
        {
            try
            {
                foreach (clsCliente e in lista)
                {
                    if (e.Documento.Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        lista.Remove(e);
                    }
                }
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("cliente no encontrado");
            }
        }

    }
}
