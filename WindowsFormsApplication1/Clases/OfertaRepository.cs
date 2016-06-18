using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ComprarOfertar
{
    internal class OfertaRepository:Repository
    {
        private const double PRECIO_DE_ENVIO = 100;

        public void ofertar(Publicacion publicacion, Usuario user, int monto,bool hayEnvio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@publicacion", publicacion.id);
            db.agregarParametro(parametros, "@fecha_oferta", Sistema.Instance.getDate());
            db.agregarParametro(parametros, "@monto_ofertado", monto);
            db.agregarParametro(parametros, "@ofertante", user.id);
            db.agregarParametro(parametros, "@precio_envio", hayEnvio ? PRECIO_DE_ENVIO : 0);

            db.ejecutarStoredProcedure("sp_AgregarOferta", parametros);
        }
    }
}