using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ComprarOfertar
{
    internal class OfertaRepository:Repository
    {
        public void ofertar(Publicacion publicacion, Usuario user, int monto)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@publicacion", publicacion.id);
            db.agregarParametro(parametros, "@fecha_oferta", Sistema.Instance.getDate());
            db.agregarParametro(parametros, "@monto_ofertado", monto);
            db.agregarParametro(parametros, "@ofertante", user.id);

            db.ejecutarStoredProcedure("sp_AgregarOferta", parametros);
        }
    }
}