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
        private int _IdCategorias;
        private string _Descripcion;
        private int _Buscarid;

        public int IdCategorias
        {
            get { return _IdCategorias; }
            set { _IdCategorias = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int Buscarid
        {
            get { return _Buscarid; }
            set { _Buscarid = value; }
        }

        public Metodos() { }

        public Metodos(int idCategorias, string descripcion, int buscarid)
        {
            this.IdCategorias = idCategorias;
            this.Descripcion = descripcion;
            this.Buscarid = buscarid;
        }

        public String Incertar(Metodos categoria)
        {
            String respuesta = "";
            SqlConnection sqlConnect = new SqlConnection();
            try
            {
                sqlConnect.ConnectionString = Conexion.conexion;
                sqlConnect.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConnect;
                sqlComando.CommandText = "Incertar_Descripcion";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@id_Categoria";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Direction = ParameterDirection.Output;
                sqlComando.Parameters.Add(parIdCategoria);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@Descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 50;
                parDescripcion.Value = categoria.Descripcion;
                sqlComando.Parameters.Add(parDescripcion);

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

        public DataTable Mostrar()
        {

            DataTable DtRespuesta = new DataTable("RegistroPeliculas");
            SqlConnection sqlconnect = new SqlConnection();
            try
            {
                sqlconnect.ConnectionString = Conexion.conexion;
                sqlconnect.Open();

                SqlCommand sqlcomando = new SqlCommand();
                sqlcomando.Connection = sqlconnect;
                sqlcomando.CommandText = "Mostrar_RegistroPeliculas";
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

        public DataTable BuscarId(Metodos buscarid)
        {
            DataTable DtRespuesta = new DataTable("RegistroPeliculas");
            SqlConnection sqlConnect = new SqlConnection();

            try
            {
                sqlConnect.ConnectionString = Conexion.conexion;
                sqlConnect.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConnect;
                sqlComando.CommandText = "Buscar_idCategoria";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParBuscarId = new SqlParameter();
                sqlParBuscarId.ParameterName = "@idBuscar";
                sqlParBuscarId.SqlDbType = SqlDbType.VarChar;
                sqlParBuscarId.Size = 50;
                sqlParBuscarId.Value = buscarid.Buscarid;
                sqlComando.Parameters.Add(sqlParBuscarId);

            }
            catch (Exception e)
            {
                DtRespuesta = null;
            }
            return DtRespuesta;
        }

    }
}
