using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            long id = (long)fila["id_visibilidad"];

            string nombre =(string) fila["visibilidad_nombre"];

            double precio = (double)fila["precio_visibilidad"];

            double porcentajeVenta = (double)fila["porcentaje_venta"];

            return new Visibilidad(id, nombre, precio, porcentajeVenta);
        }
    }
}
