using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
   public class Actores : ClaseMaestra
    {

        public int ActorId { get; set; }
        public string Nombre { get; set; }
        public ConexionDb conexion = new ConexionDb();

        public Actores() { }

        public Actores(int actorId, string nombre) {
            this.ActorId = actorId;
            this.Nombre = nombre;
        }

        public override bool Insertar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Insert into Actores(Nombre) Values('{0}')", this.Nombre));
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public override bool Editar()
        {
            try
            {
                conexion.Ejecutar(String.Format("update Actores set Nombre='{0}' where ActorId = {1}", this.Nombre, this.ActorId));
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public override bool Eliminar()
        {
            try
            {
                conexion.Ejecutar(String.Format("delete from Actores where ActorId ={0}", this.ActorId));
                return true;
            }
            catch (Exception) { return false; }
        }

       
        public override bool Buscar(int BuscarId)
        {
            DataTable datos = new DataTable();
            datos = conexion.ObtenerDatos("Select * from Actores where ActorId = " + BuscarId);

            if (datos.Rows.Count>0) {
                this.ActorId = (int)datos.Rows[0]["ActorId"];
                this.Nombre = datos.Rows[0]["Nombre"].ToString();
            }
            return datos.Rows.Count > 0;
        }
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            return conexion.ObtenerDatos("select"+Campos+"from Actores where"+Condicion+" "+Orden);
        }
    }
}
