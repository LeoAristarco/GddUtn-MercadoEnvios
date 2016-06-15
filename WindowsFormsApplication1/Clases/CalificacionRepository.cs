using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Calificar
{
    internal class CalificacionRepository : Repository
    {
        internal void agregarCalificacion(Calificacion calificacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            //ACA HAY Q CARGAR LOS PARAMETROS

            db.ejecutarStoredProcedure("st_agregarCalificacion", parametros);
        }
    }
}