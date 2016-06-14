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
            List<Dictionary<string, object>> tabla = db.ejecutarConsulta("select * from ESTADO_PUBLICACION");

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
            string nombre =(string) fila["estado_nombre"];

            return new EstadoPublicacion(id, nombre);
        }
    }
}
