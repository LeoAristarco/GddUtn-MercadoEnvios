using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Clases
{
    class VisibilidadRepository:Repository
    {
        public List<Visibilidad> obtenerVisibilidades()
        {
            string consulta = "select * from VISIBILIDAD";

            List<Dictionary<string,object>> tablaVisibilidad = db.ejecutarConsulta(consulta);

            List<Visibilidad> visibilidades = new List<Visibilidad>();

            foreach (Dictionary<string,object> fila in tablaVisibilidad)
            {
                visibilidades.Add(deserializarVisibilidad(fila));
            }

            return visibilidades;
        }

        private Visibilidad deserializarVisibilidad(Dictionary<string, object> fila)
        {
            long id = toLong(fila["id_visibilidad"]);

            string nombre =(string) fila["visibilidad_nombre"];

            double precio = toDouble(fila["precio_visibilidad"]);

            double porcentajeVenta = toDouble(fila["porcentaje_venta"]);

            return new Visibilidad(id, nombre, precio, porcentajeVenta);
        }

        internal void agregarVisibilidad(Visibilidad visibilidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros, "@visibilidad_nombre", visibilidad.nombre);
            db.agregarParametro(parametros, "@precio_visibilidad", visibilidad.precio);
            db.agregarParametro(parametros, "@porcentaje_venta", visibilidad.porcentajeVenta);
            
            db.ejecutarStoredProcedure("sp_AgregarVisibilidad", parametros);
        }

        internal void updateVisibilidad(Visibilidad visibilidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros, "@id_visibilidad", visibilidad.id);
            db.agregarParametro(parametros, "@visibilidad_nombre", visibilidad.nombre);
            db.agregarParametro(parametros, "@precio_visibilidad", visibilidad.precio);
            db.agregarParametro(parametros, "@porcentaje_venta", visibilidad.porcentajeVenta);

            db.ejecutarStoredProcedure("sp_EditarVisibilidad", parametros);
        }

        internal Visibilidad traerPorId(long v)
        {
            string consulta = "select * from VISIBILIDAD where id_visibilidad=" + v.ToString();
            return deserializarVisibilidad(db.ejecutarConsulta(consulta)[0]);
        }

        internal string eliminarVisibilidad(Visibilidad visibilidadSeleccionada)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros, "@id_visibilidad", visibilidadSeleccionada.id);

            string error = db.ejecutarStoredConRetorno("sp_EliminarVisibilidad", parametros, "@tipoError", "").ToString();

            return error;

        }
    }
}
