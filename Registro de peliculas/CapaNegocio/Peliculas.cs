using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Peliculas : ClaseMaestra 
    {

        ConexionDb conexion = new ConexionDb();

        public int PeliculaId { get; set; }
        public string Descripcion { get; set; }
        public int IMDB { get; set; }
        public int Calificacion { get; set; }
        public int CategoriaId { get; set; }
        public int Ano { get; set; }
        public string Titulo { get; set; }

         List<Actores> Actores { get; set; }

        public Peliculas() {
            Actores = new List<Actores>();
        }

        public void AgregarActor(int ActorId , string Nombre) {
            this.Actores.Add(new Actores(ActorId, Nombre));
        }

        public Peliculas(int PeliculaId,string titulo, string descripcion, int categoriaId, int IMDB, int ano,int calificacion, string buscarTitulo)
        {
            this.CategoriaId = categoriaId;
            this.Descripcion = descripcion;
            this.IMDB = IMDB;
            this.Calificacion = calificacion;
            this.PeliculaId = PeliculaId;
            this.Titulo = titulo;
            this.Ano = ano;

        }
        //INCERTAR DATOS
        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder comando = new StringBuilder();

            
            retorno = conexion.Ejecutar(String.Format("Insert into Peliculas(Titulo,Descripcion,Año,IMDB,CategoriaId,Calificacion) Values('{0}','{1}',{2},{3},{4},{5})", this.Titulo, this.Descripcion, this.Ano, this.IMDB, this.CategoriaId, this.CategoriaId));
            if (retorno) {
                this.PeliculaId = (int)conexion.ObtenerValor("Select Max (PeliculaId) from Peliculas");

                foreach (var actor in this.Actores) {
                    comando.AppendLine(String.Format("insert into PeliculasActores(PeliculaId,ActorId) Value({0},{1})",this.PeliculaId,actor.ActorId));
                }
                retorno = conexion.Ejecutar(comando.ToString());
            }
            return retorno;
        }
        
        //EDITAR DATOS
        public override bool Editar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();

            conexion.Ejecutar(String.Format("update Peliculas set Titulo='{0}',Descripcion = '{1}',Calificacion={2},IMDB = {3},CategoriaId={4},Año={5} where PeliculaId={6} ", this.Titulo, this.Descripcion, this.Calificacion, this.IMDB, this.CategoriaId, this.Ano));

            if (retorno) {
                conexion.Ejecutar("Delete from PeliculasActores where PeliculaId ="+this.PeliculaId);

                foreach (var actor in this.Actores) {
                    Comando.AppendLine(String.Format("insert into PeliculasActores(PeliculaId,ActoresId) Values({0},{1})",this.PeliculaId, actor.ActorId));
                }
                retorno = conexion.Ejecutar(Comando.ToString());
            }
            return retorno;
        }
        //ELIMINAR DATOS
        public override bool Eliminar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar("Delete from Peliculas where PeliculaId =" + this.PeliculaId + ";" +
                                         "Delete from PeliculasActores where PeliculasId = " + this.PeliculaId);
            return retorno;
        }

        //BUSCAR DATOS
        public override bool Buscar(int BuscarId)
        {
            DataTable datosActores = new DataTable();
            DataTable datos = new DataTable();
            datos = conexion.ObtenerDatos("Select * from Peliculas where PeliculaId = " + BuscarId);

            if (datos.Rows.Count > 0) {
                this.PeliculaId = (int)datos.Rows[0]["PeliculaId"];
                this.Titulo = datos.Rows[0]["Titulo"].ToString();
                this.Descripcion = datos.Rows[0]["Descripcion"].ToString();
                this.Ano = (int)datos.Rows[0]["Año"];
                this.IMDB = (int)datos.Rows[0]["IMDB"];
                this.CategoriaId = (int)datos.Rows[0]["CategoriaId"];
         
                this.Calificacion = (int)datos.Rows[0]["Calificacion"];

                datosActores = conexion.ObtenerDatos("Select p.ActorId,a.Nombre" +
                                                      "From PeliculasActores p" +
                                                      "Inner Join Actores a On p.ActorId=a.ActorId" +
                                                      "where p.PeliculaId =" + this.PeliculaId);
                foreach (DataRow row in datosActores.Rows) {
                    this.AgregarActor((int)row["ActorId"], row["Nombre"].ToString());
                }
            }


            return datos.Rows.Count > 0;
        }
        //LISTAR DATOS
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";//orden.Equal("") ? "orden by"+ orden:"";

            if (!Orden.Equals(""))
                ordenFinal = "orden by" + Orden;

            return conexion.ObtenerDatos("Select"+Campos+"from Peliculas where "+Condicion + ordenFinal);
        }



    }
}
