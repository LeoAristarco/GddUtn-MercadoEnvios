using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        internal void updateVisibilidad(Visibilidad visibilidad)
        {
            throw new NotImplementedException();
        }

        public DataGridView llenarDataGrid()
        {
            return db.obtenerDataGridView("select visibilidad_nombre,precio_visibilidad,porcentaje_venta from VISIBILIDAD");
        }
    }
}
