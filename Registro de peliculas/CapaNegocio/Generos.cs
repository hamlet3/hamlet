using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Generos : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public Generos(int generoId, string descripcion) {
            this.GeneroId = generoId;
            this.Descripcion = descripcion;
        }
        public Generos() { }


        public override bool Insertar()
        {

            try
            {
                conexion.Ejecutar(String.Format("Insert into Generos(Descripcion) Values('{0}')", this.Descripcion));
                return true;
            }
            catch (Exception) { return false; }
        }
       

        public override bool Editar()
        {
            try {
                conexion.Ejecutar(String.Format("update Generos set Descripcion = '{0}' where GeneroId = {1}", this.Descripcion, this.GeneroId));
                return true;
            }
            catch (Exception) { return false; }
        }


        public override bool Buscar(int BuscarId)
        {

            DataTable datos = new DataTable();

            datos = conexion.ObtenerDatos("Select * from Generos where GeneroId =" + BuscarId);
            if(datos.Rows.Count>0) {
                GeneroId = (int)datos.Rows[0]["GeneroId"];
                Descripcion = datos.Rows[0]["Descripcion"].ToString();
            }

            return datos.Rows.Count>0;
        }


        public override bool Eliminar()
        {
            try {
                conexion.Ejecutar(String.Format("delete from Generos where GeneroId = {0}", this.GeneroId));
                return true;
            }
            catch (Exception) { return false; }
        }

        

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            return conexion.ObtenerDatos(String.Format("Select" + Campos + "From RegistroPeliculas where " + Condicion + " " + Orden));
        }
    }
}
