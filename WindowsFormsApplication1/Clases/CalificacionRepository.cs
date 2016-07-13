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
            string update = "update VARCHAR_DE_30.CALIFICACION set calif_estrellas=" + calificacion.estrellas.ToString() + ", "
                + "calif_detalle='" + calificacion.comentarios + "' where id_calificacion=" + calificacion.id.ToString();

            db.ejecutarConsulta(update);
        }

        internal Calificacion traerPorId(long v)
        {
            string consulta = "select * from VARCHAR_DE_30.CALIFICACION where id_calificacion=" + v.ToString();
            return deserializarCalificacion(db.ejecutarConsulta(consulta)[0]);
        }

        private Calificacion deserializarCalificacion(Dictionary<string, object> fila)
        {
            long id = toLong(fila["id_calificacion"]);
            string comentarios = fila["calif_detalle"].ToString();
            int estrellas = 0;

            if (fila["calif_estrellas"].ToString()!="")
            {
                estrellas = toInt(fila["calif_estrellas"]);
            }

            return new Calificacion(id, estrellas,comentarios);
        }

        internal List<long> obtenerResumenCalificaciones(Usuario usuario)
        {
            List<long> calificaciones = new List<long>();

            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@id_usuario", usuario.id);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("VARCHAR_DE_30.st_resumenDeEstrellasDadas", parametros);

            for (int i = 1; i < 6; i++)
            {
                string index = i.ToString() + " estrella";
                calificaciones.Add(toLong(tabla[0][index]));
            }

            return calificaciones;
        }
    }
}