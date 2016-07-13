using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Generar_Publicación
{
    class EstadoPublicacionRepository:Repository
    {
        public List<EstadoPublicacion> obetenerEstadosPublicacion()
        {
            List<Dictionary<string, object>> tabla = db.ejecutarConsulta("select * from CHAR_DE_30.ESTADO_PUBLICACION");

            List<EstadoPublicacion> estados = new List<EstadoPublicacion>();

            foreach (Dictionary<string,object> fila in tabla)
            {
                estados.Add(deserializarEstadoPublicacion(fila));
            }

            return estados;
        }

        private EstadoPublicacion deserializarEstadoPublicacion(Dictionary<string, object> fila)
        {
            long id = toLong(fila["id_estado"]);
            string nombre = fila["estado_nombre"].ToString();

            return new EstadoPublicacion(id, nombre);
        }

        internal EstadoPublicacion traerPorId(long v)
        {
            string consulta = "select * from CHAR_DE_30.ESTADO_PUBLICACION where id_estado=" + v.ToString();
            return deserializarEstadoPublicacion(db.ejecutarConsulta(consulta)[0]);
        }
    }
}
