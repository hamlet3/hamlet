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
        public static string Incertar(string titulo,string descripcion,int idCategoria,int iMDB,int ano,int calificacion) {
            Metodos objeto = new Metodos();
            objeto.Titulo = titulo;
            objeto.Descripcion = descripcion;
            objeto.IdCategoria = idCategoria;
            objeto.IMDB = iMDB;
            objeto.Ano = ano;
            objeto.Calificacion = calificacion;
            return objeto.Incertar(objeto);
        }

        public static string Editar(int idPelicula,string titulo, string descripcion, int idCategoria, int iMDB, int ano, int calificacion)
        {
            Metodos objeto = new Metodos();
            objeto.IdPelicula = idPelicula;
            objeto.Titulo = titulo;
            objeto.Descripcion = descripcion;
            objeto.IdCategoria = idCategoria;
            objeto.IMDB = iMDB;
            objeto.Ano = ano;
            objeto.Calificacion = calificacion;
            return objeto.Editar(objeto);
        }

        public static string Eliminar(int idPelicula)
        {
            Metodos objeto = new Metodos();
            objeto.IdPelicula = idPelicula;
   
            return objeto.Eliminar(objeto);
        }

        public static DataTable Mostrar() {

            return new Metodos().Mostrar();
        }

        public static DataTable BuscarTitulo(string buscarTitulo) {
            Metodos objeto = new Metodos();
            objeto.BuscarTitulo = buscarTitulo;
            return objeto.Buscar_Titulo(objeto);
        }
    }
}

