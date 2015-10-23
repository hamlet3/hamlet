using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConexionDb
    {
        private SqlConnection con;
        private SqlCommand Cmd;

        public ConexionDb() { 
            con =new SqlConnection( "Data Source=REYES-PC; Initial Catalog = RegistroPeliculas; Integrated Security=true");
            Cmd = new SqlCommand();
        }
        //EJECUTAR CONMANDOS CONTRA LA BASE DE DATOS
        public bool Ejecutar(String ComandoSql) {
            bool retorno = false;

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;
                Cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                con.Close();
            }
            return retorno;
        }
        public DataTable ObtenerDatos(String ComandoSql)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;

                adapter = new SqlDataAdapter(Cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally {
                con.Close();
            }
            return dt;

        }

        public Object ObtenerValor(String ComandoSql) {

            Object retorno = null;
            try
            {

                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;
                retorno = Cmd.ExecuteScalar();
                retorno = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                con.Close();
            }
            return retorno;
        }
    }
}
