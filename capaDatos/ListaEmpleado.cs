using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using capaEntidades;


namespace capaDatos
{
    public class ListaEmpleado
    {
        static List<Object> lista = new List<Object>();

        public ListaEmpleado Lista { get; set; }
        
        public static void add(Object p)
        {
            lista.Add(p);
        }

        public static clsEmpleado  buscar(string id)
        {
            clsEmpleado res = null;
            foreach(clsEmpleado p in lista)
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
            foreach(clsEmpleado e in lista)
            {
                if (e.Documento.Equals(l[0]))
                {
                    e.Telefono = l[1];
                    e.Cargo = l[2];
                    e.Salario = l[3];
                    break;
                }
            }
        }

        public static void eliminar(string id)
        {
            try
            {
                foreach (clsEmpleado e in lista)
                {
                    if (e.Documento.Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        lista.Remove(e);
                    }
                }
            }
            catch (System.InvalidOperationException )
            {
                Console.WriteLine("Empleado no encontrado");
            }
        }
    }
}
