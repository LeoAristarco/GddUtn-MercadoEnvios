using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Calificar
{
    internal class CalificacionRepository : Repository
    {
        internal void updateCalificacion(Calificacion calificacion)
        {
            string update = "update CALIFICACION set calif_estrellas=" + calificacion.estrellas.ToString() + ", "
                + "calif_detalle=" + calificacion.comentarios + " where id_calificacion=" + calificacion.id.ToString();

            db.ejecutarConsulta(update);
        }

        internal Calificacion traerPorId(long v)
        {
            string consulta = "select * from ESTADO_PUBLICACION where id_estado=" + v.ToString();
            return deserializarCalificacion(db.ejecutarConsulta(consulta)[0]);
        }

        private Calificacion deserializarCalificacion(Dictionary<string, object> fila)
        {
            long id = toLong(fila["id_calificacion"]);
            int estrellas = toInt(fila["calif_estrellas"]);
            string comentarios = fila["calif_detalle"].ToString();

            return new Calificacion(id, estrellas,comentarios);
        }
    }
}