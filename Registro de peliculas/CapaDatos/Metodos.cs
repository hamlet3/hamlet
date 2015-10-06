using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Metodos
    {
        private int _IdPelicula;
        private string _Titulo;
        private int _Ano;
        private string _Descripcion;
        private int _IMDB;
        private int _IdCategoria;
        private int _Calificacion;
        private string _BuscarTitulo;

        public int IdPelicula
        {
            get { return _IdPelicula; }
            set { _IdPelicula = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string BuscarTitulo
        {
            get { return _BuscarTitulo; }
            set { _BuscarTitulo = value; }
        }

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public int Ano
        {
            get { return _Ano; }
            set { _Ano = value; }
        }

        public int IMDB
        {
            get { return _IMDB; }
            set { _IMDB = value; }
        }

        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }

        public int Calificacion
        {
            get { return _Calificacion; }
            set { _Calificacion = value; }
        }




        public Metodos() { }

        public Metodos(int idPelicula,string titulo, string descripcion, int idCategorias, int IMDB, int ano,int calificacion, string buscarTitulo)
        {
            this.IdCategoria = idCategorias;
            this.Descripcion = descripcion;
            this.BuscarTitulo = buscarTitulo;
            this.IMDB = IMDB;
            this.Calificacion = calificacion;
            this.IdPelicula = idPelicula;
            this.Titulo = titulo;
            this.Ano = ano;

        }

        public string Incertar(Metodos categoria)
        {
            string respuesta = "";
            SqlConnection sqlConnect = new SqlConnection();
            try
            {
                sqlConnect.ConnectionString = Conexion.conexion;
                sqlConnect.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConnect;
                sqlComando.CommandText = "spincertar_categoria";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdTitulo = new SqlParameter();
                parIdTitulo.ParameterName = "@id_titulo";
                parIdTitulo.SqlDbType = SqlDbType.Int;
                parIdTitulo.Direction = ParameterDirection.Output;
                sqlComando.Parameters.Add(parIdTitulo);

                SqlParameter parTitulo = new SqlParameter();
                parTitulo.ParameterName = "@titulo";
                parTitulo.SqlDbType = SqlDbType.VarChar;
                parTitulo.Size = 50;
                parTitulo.Value = categoria.Titulo;
                sqlComando.Parameters.Add(parTitulo);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 100;
                parDescripcion.Value = categoria.Descripcion;
                sqlComando.Parameters.Add(parDescripcion);

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@id_categoria";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = categoria.IdCategoria;
                sqlComando.Parameters.Add(parIdCategoria);

                SqlParameter parIMDB = new SqlParameter();
                parIMDB.ParameterName = "@IMDB";
                parIMDB.SqlDbType = SqlDbType.Int;
                parIMDB.Value = categoria.IMDB;
                sqlComando.Parameters.Add(parIMDB);

                SqlParameter parCalificacion = new SqlParameter();
                parCalificacion.ParameterName = "@calificacion";
                parCalificacion.SqlDbType = SqlDbType.Int;
                parCalificacion.Value = categoria.Calificacion;
                sqlComando.Parameters.Add(parCalificacion);

                SqlParameter parano = new SqlParameter();
                parano.ParameterName = "@ano";
                parano.SqlDbType = SqlDbType.Int;
                parano.Value = categoria.Ano;
                sqlComando.Parameters.Add(parano);

                
                respuesta = sqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el regirtro";
            }
            catch (Exception e)
            {
                respuesta = e.Message;
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                    sqlConnect.Close();
            }

            return respuesta;
        }

        public string Editar(Metodos categoria)
        {
            string respuesta = "";
            SqlConnection sqlConnect = new SqlConnection();
            try
            {
                sqlConnect.ConnectionString = Conexion.conexion;
                sqlConnect.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConnect;
                sqlComando.CommandText = "speditar_categoria";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdTitulo = new SqlParameter();
                parIdTitulo.ParameterName = "@id_pelicula";
                parIdTitulo.SqlDbType = SqlDbType.Int;
                parIdTitulo.Value = categoria.IdPelicula;
                sqlComando.Parameters.Add(parIdTitulo);

                SqlParameter parTitulo = new SqlParameter();
                parTitulo.ParameterName = "@titulo";
                parTitulo.SqlDbType = SqlDbType.VarChar;
                parTitulo.Size = 50;
                parTitulo.Value = categoria.Titulo;
                sqlComando.Parameters.Add(parTitulo);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 100;
                parDescripcion.Value = categoria.Descripcion;
                sqlComando.Parameters.Add(parDescripcion);

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@id_categoria";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = categoria.IdCategoria;
                sqlComando.Parameters.Add(parIdCategoria);

                SqlParameter parIMDB = new SqlParameter();
                parIMDB.ParameterName = "@IMDB";
                parIMDB.SqlDbType = SqlDbType.Int;
                parIMDB.Value = categoria.IMDB;
                sqlComando.Parameters.Add(parIMDB);

                SqlParameter parCalificacion = new SqlParameter();
                parCalificacion.ParameterName = "@calificacion";
                parCalificacion.SqlDbType = SqlDbType.Int;
                parCalificacion.Value = categoria.Calificacion;
                sqlComando.Parameters.Add(parCalificacion);

                SqlParameter parano = new SqlParameter();
                parano.ParameterName = "@ano";
                parano.SqlDbType = SqlDbType.Int;
                parano.Value = categoria.Ano;
                sqlComando.Parameters.Add(parano);


                respuesta = sqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el regirtro";
            }
            catch (Exception e)
            {
                respuesta = e.Message;
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                    sqlConnect.Close();
            }

            return respuesta;
        }

        public string Eliminar(Metodos categoria)
        {
            string respuesta = "";
            SqlConnection sqlConnect = new SqlConnection();
            try
            {
                sqlConnect.ConnectionString = Conexion.conexion;
                sqlConnect.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConnect;
                sqlComando.CommandText = "speliminar_categoria";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdTitulo = new SqlParameter();
                parIdTitulo.ParameterName = "@id_pelicula";
                parIdTitulo.SqlDbType = SqlDbType.Int;
                parIdTitulo.Value = categoria.IdPelicula;
                sqlComando.Parameters.Add(parIdTitulo);

                


                respuesta = sqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el regirtro";
            }
            catch (Exception e)
            {
                respuesta = e.Message;
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                    sqlConnect.Close();
            }

            return respuesta;
        }

        //MOSTRAR
        public DataTable Mostrar()
        {

            DataTable DtRespuesta = new DataTable("RegistroPeliculas");
            SqlConnection sqlconnect = new SqlConnection();
            try
            {
                sqlconnect.ConnectionString = Conexion.conexion;

                SqlCommand sqlcomando = new SqlCommand();
                sqlcomando.Connection = sqlconnect;
                sqlcomando.CommandText = "spmostrar_categoria";
                sqlcomando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlcomando);
                sqlData.Fill(DtRespuesta);
            }
            catch (Exception e)
            {
                DtRespuesta = null;
            }
            return DtRespuesta;
        }
        //BUSCAR TITULO
        public DataTable Buscar_Titulo(Metodos categoria)
        {
            DataTable DtRespuesta = new DataTable("RegistroPeliculas");
            SqlConnection sqlConnect = new SqlConnection();

            try
            {
                sqlConnect.ConnectionString = Conexion.conexion;

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConnect;
                sqlComando.CommandText = "spbuscar_Categoria";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parTituloBuscar = new SqlParameter();
                parTituloBuscar.ParameterName = "@textobuscar";
                parTituloBuscar.SqlDbType = SqlDbType.VarChar;
                parTituloBuscar.Size = 50;
                parTituloBuscar.Value = categoria.BuscarTitulo;
                sqlComando.Parameters.Add(parTituloBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlComando);
                SqlDat.Fill(DtRespuesta);

            }
            catch (Exception e)
            {
                DtRespuesta = null;
            }
            return DtRespuesta;
        }

    }
}
