using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication1.Calificar;
using WindowsFormsApplication1.Clases;
using WindowsFormsApplication1.Historial_Cliente;

namespace WindowsFormsApplication1.ComprarOfertar
{
    internal class OfertaRepository : Repository
    {
        private const double PRECIO_DE_ENVIO = 100;

        public void ofertar(Publicacion publicacion, Usuario user, int monto, bool hayEnvio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@publicacion", publicacion.id);
            db.agregarParametro(parametros, "@fecha_oferta", Sistema.Instance.getDate());
            db.agregarParametro(parametros, "@monto_ofertado", monto);
            db.agregarParametro(parametros, "@ofertante", user.id);
            db.agregarParametro(parametros, "@precio_envio", hayEnvio ? PRECIO_DE_ENVIO : 0);

            db.ejecutarStoredProcedure("VARCHAR_DE_30.sp_AgregarOferta", parametros);
        }

        internal string validacionDeOferta(Publicacion publicacion, Usuario user)
        {
            CompraRepository compraRepo = new CompraRepository();

            return compraRepo.validacionDeCompra(publicacion, user);
        }

        internal List<Oferta> obtenerOfertasPorPagina(Usuario usuario, int numeroPaginaOferta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@idUsuario", usuario.id);

            db.agregarParametro(parametros, "@pagina", numeroPaginaOferta);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("VARCHAR_DE_30.st_subastasDeCliente", parametros);

            List<Oferta> ofertas = new List<Oferta>();

            foreach (Dictionary<string, object> fila in tabla)
            {
                ofertas.Add(deserializarOfertaConPublicacionConDetalle(fila));
            }

            return ofertas;
        }

        private Oferta deserializarOfertaConPublicacionConDetalle(Dictionary<string, object> fila)
        {
            Oferta oferta = new Oferta();
            Publicacion publicacion = new Publicacion();
            publicacion.id = toLong(fila["id_publicacion"]);
            publicacion.descripcion = fila["descripcion"].ToString();
            oferta.publicacion = publicacion;
            oferta.fechaOferta = toDate(fila["fecha_oferta"]);
            oferta.montoOfertado = toDouble(fila["monto_ofertado"]);
            oferta.concretada = toBool(fila["concretada"]);

            return oferta;
        }

        internal int cantidadDePaginasOfertasDeCliente(Usuario usuario)
        {
            int cantidadPaginas = 0;

            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros, "@idUsuario", usuario.id);

            cantidadPaginas = toInt(db.ejecutarStoredConRetorno("VARCHAR_DE_30.st_cantidadPaginasSubastasDeCliente", parametros, "@ultimaPagina", 0));

            return cantidadPaginas;
        }
    }
}