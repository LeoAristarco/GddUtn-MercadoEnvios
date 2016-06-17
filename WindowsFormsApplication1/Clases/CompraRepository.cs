using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Calificar
{
    internal class CompraRepository:Repository
    {
        private const double PRECIO_DE_ENVIO=100;
        internal List<Compra> obtenerComprasDe(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        internal void comprar(Publicacion publicacion, Usuario user, int cantidad,bool hayEnvio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros,"@publicacion", publicacion.id);
            db.agregarParametro(parametros, "@fecha_operacion", Sistema.Instance.getDate());
            db.agregarParametro(parametros, "@monto", publicacion.precio);
            db.agregarParametro(parametros, "@cantidad",cantidad );
            db.agregarParametro(parametros, "@precio_envio", hayEnvio ? PRECIO_DE_ENVIO : 0);
            db.agregarParametro(parametros, "@factura", publicacion.factura.id);
            db.agregarParametro(parametros, "@descripcion", publicacion.descripcion);
            db.agregarParametro(parametros, "@comprador", user.id);

            db.ejecutarStoredProcedure("st_insertarCompraSubasta", parametros);
        }

        internal string validacionDeCompra(Publicacion publicacion,Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            string tipoError = "";

            db.agregarParametro(parametros, "@id_cliente",user.id);
            db.agregarParametro(parametros, "@usuario_responsable",publicacion.responsable.id);
            db.agregarParametro(parametros, "@id_publicacion",publicacion.id);
            //db.agregarParametro(parametros, "@tipoError",tipoError);


            tipoError = db.ejecutarStoredConRetorno("st_validacion_de_compra_oferta", parametros, "@tipoError", "").ToString();

            return tipoError;
        }
    }
}