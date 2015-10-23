using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class Estudios : ClaseMaestra
    {
        public int EstudioId { get; set; }
        public string Nombre { get; set; }
        ConexionDb conexion = new ConexionDb();

        public override bool Insertar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Insert into Estudios(Nombre) Values('{0}')",this.Nombre));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Editar()
        {
            try {
                conexion.Ejecutar(String.Format("update Estudios set Nombre='{0}' where EstudioId={1}",this.Nombre, this.EstudioId));
                return true;
            } catch (Exception) { return false; }
        }

        public override bool Eliminar()
        {
            try {
                conexion.Ejecutar(String.Format("delete from Estudios where EstudioId = {0}",this.EstudioId));
                return true;
            } catch (Exception) { return false; }
        }

        public override bool Buscar(int BuscarId)
        {
            DataTable datos = new DataTable();
            datos = conexion.ObtenerDatos("Select * from Estudios where EstudioId = "+ BuscarId);
            if (datos.Rows.Count > 0)
            {
                this.EstudioId = (int)datos.Rows[0]["EstudioId"];
                this.Nombre = datos.Rows[0]["Nombre"].ToString();
            }
            return datos.Rows.Count > 0;
        }
        
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            return conexion.ObtenerDatos("Select +"+Campos+" from Estudios where"+Condicion+" "+Orden);
        }
    }
}
