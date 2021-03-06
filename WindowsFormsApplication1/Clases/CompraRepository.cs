﻿using System;
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
            //db.agregarParametro(parametros, "@descripcion", publicacion.descripcion);
            db.agregarParametro(parametros, "@comprador", user.id);

            db.ejecutarStoredProcedure("CHAR_DE_30.st_insertarCompraSubasta", parametros);
        }

        internal List<Compra> obtenerUltimas5Compras(Usuario usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<Compra> compras = new List<Compra>();

            db.agregarParametro(parametros, "@id_usuario", usuario.id);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("CHAR_DE_30.st_ultimas5compras", parametros);

            foreach (Dictionary<string,object> item in tabla)
            {
                Compra compra = new Compra();
                compra.publicacion = new Publicacion();
                compra.publicacion.descripcion = item["descripcion"].ToString();
                compra.calificacion = new Calificacion();
                compra.calificacion.estrellas = compra.calificacion.estrellas = toInt(item["calif_estrellas"]);

                compras.Add(compra);
            }

            return compras;
        }

        internal string validacionDeCompra(Publicacion publicacion,Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            string tipoError = "";

            db.agregarParametro(parametros, "@id_cliente",user.id);
            db.agregarParametro(parametros, "@usuario_responsable",publicacion.responsable.id);
            db.agregarParametro(parametros, "@id_publicacion",publicacion.id);
            //db.agregarParametro(parametros, "@tipoError",tipoError);

            //tipoError = db.ejecutarStoredProcedure("st_validacion_de_compra_oferta", parametros)[0]["tipo_de_error"].ToString();

            //tipoError = db.ejecutarStoredProcedure("st_validacion_de_compra_oferta", parametros)[0]["error"].ToString();


            tipoError = db.ejecutarStoredConRetorno("CHAR_DE_30.st_validacion_de_compra_oferta", parametros, "@tipoError", "").ToString();

            switch (tipoError)
            {
                case "i":
                    tipoError = "Error, un usuario no puede comprarse a si mismo";
                    break;

                case "p":
                    tipoError = "Error, un usuario no puede comprar una publicacion en estado pausado";
                    break;

                case "c":
                    tipoError = "Error, un usuario no puede comprar con mas de 3 compras sin calificar";
                    break;

                default:
                    tipoError = "todo piolaa";
                    break;
            }

            return tipoError;
        }

        internal List<Compra> obtenerComprasSinCalificar(Usuario usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros, "@id_usuario", usuario.id);
            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("CHAR_DE_30.st_mostrarPublicacionesSinCalificar", parametros);
            List<Compra> comprasSinCalificar = new List<Compra>();

            foreach (Dictionary<string, object> item in tabla)
            {
                comprasSinCalificar.Add(deserializarCompraVaciaConPublicacion(item));
            }

            return comprasSinCalificar;
        }

        private Compra deserializarCompraVaciaConPublicacion(Dictionary<string, object> item)
        {
            PublicacionRepository repoPublicacion = new PublicacionRepository();
            CalificacionRepository repoCalificacion = new CalificacionRepository();
            Compra compra = new Compra();
            compra.publicacion = repoPublicacion.deserializarPublicacionConId(item);
            compra.calificacion = repoCalificacion.traerPorId(toLong(item["id_calificacion"]));

            return compra;
        }

        internal List<Compra> obtenerComprasPorPagina(Usuario usuario, int numeroPaginaCompra)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros,"@idUsuario",usuario.id);

            db.agregarParametro(parametros,"@pagina",numeroPaginaCompra);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("CHAR_DE_30.st_comprasDeCliente", parametros);

            List<Compra> compras = new List<Compra>();

            foreach (Dictionary<string,object> fila in tabla)
            {
                compras.Add(deserializarCompraConPublicacionConDetalle(fila));
            }

            return compras;
        }

        private Compra deserializarCompraConPublicacionConDetalle(Dictionary<string, object> fila)
        {
            Compra compra = new Compra();
            Publicacion publicacion=new Publicacion();
            publicacion.id = toLong(fila["id_publicacion"]);
            publicacion.descripcion = fila["descripcion"].ToString();
            compra.publicacion = publicacion;
            compra.cantidad = toInt(fila["cantidad"]);
            compra.monto = toDouble(fila["monto"]);
            compra.fechaDeOperacion = toDate(fila["fecha_operacion"]);

            return compra;
        }


        internal int cantidadDePaginasComprasDeCliente(Usuario usuario)
        {
            int cantidadPaginas = 0;

            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros, "@idUsuario", usuario.id);

            cantidadPaginas = toInt(db.ejecutarStoredConRetorno("CHAR_DE_30.st_cantidadPaginasComprasDeCliente", parametros, "@ultimaPagina", 0));

            return cantidadPaginas;
        }
    }
}