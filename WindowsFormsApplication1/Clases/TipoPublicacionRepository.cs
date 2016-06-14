using System;
using System.Collections.Generic;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Generar_Publicación
{
    internal class TipoPublicacionRepository : Repository
    {

        private TipoPublicacion deserializarTipoPublicacion(Dictionary<string, object> fila)
        {
            long id = toLong(fila["id_tipo"]);
            string nombre = (string)fila["tipo"];

            return new TipoPublicacion(id, nombre);
        }

        internal List<TipoPublicacion> obtenerTiposPublicacion()
        {
            List<Dictionary<string, object>> tabla = db.ejecutarConsulta("select * from TIPO_PUBLICACION");

            List<TipoPublicacion> tipos = new List<TipoPublicacion>();

            foreach (Dictionary<string, object> fila in tabla)
            {
                tipos.Add(deserializarTipoPublicacion(fila));
            }

            return tipos;
        }
    }
}