using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NMetodos
    {
        public static string Incertar(string descripcion) {
            Metodos objeto = new Metodos();
            objeto.Descripcion = descripcion;

            return objeto.Incertar(objeto);
        }

        public static DataTable Mostrar() {
            Metodos objeto = new Metodos();
            return objeto.Mostrar();
        }

        public static DataTable BuscarId(int buscarId) {
            Metodos objeto = new Metodos();
            objeto.Buscarid = buscarId;
            return objeto.BuscarId(objeto);
        }
    }
}

