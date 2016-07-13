using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Facturas
{
    class FacturaRepository : Repository
    {
        internal List<Factura> buscarFacturasPorFiltro(long idUsuario, double montoMinimo, double montoMaximo, bool montoActivado, DateTime fechaMinima, DateTime fechaMaxima, bool fechaActivada,int pagina)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@idUsuario", idUsuario);
            db.agregarParametro(parametros, "@pagina", pagina);

            if (montoActivado)
            {
                db.agregarParametro(parametros, "@montoDesde", montoMinimo);
                db.agregarParametro(parametros, "@montoHasta", montoMaximo);
            }
            else
            {
                db.agregarParametro(parametros, "@montoDesde", null);
                db.agregarParametro(parametros, "@montoHasta", null);
            }


            if (fechaActivada)
            {
                db.agregarParametro(parametros, "@fechaDesde", fechaMinima);
                db.agregarParametro(parametros, "@fechaHasta", fechaMaxima);
            }
            else
            {
                db.agregarParametro(parametros, "@fechaDesde", null);
                db.agregarParametro(parametros, "@fechaHasta", null);
            }

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("CHAR_DE_30.st_obtenerFacturasVendedorPorPaginas", parametros);

            List<Factura> facturas = new List<Factura>();

            foreach (Dictionary<string,object> item in tabla)
            {
                facturas.Add(deserializarFactura(item));
            }

            return facturas;
        }

        internal int cantidadMaximaPaginasFacturasClienteFiltradas(long idUsuario, double montoMinimo, double montoMaximo, bool montoActivado, DateTime fechaMinima, DateTime fechaMaxima, bool fechaActivada)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@idUsuario", idUsuario);
            //db.agregarParametro(parametros, "@pagina", pagina);

            if (montoActivado)
            {
                db.agregarParametro(parametros, "@montoDesde", montoMinimo);
                db.agregarParametro(parametros, "@montoHasta", montoMaximo);
            }
            else
            {
                db.agregarParametro(parametros, "@montoDesde", null);
                db.agregarParametro(parametros, "@montoHasta", null);
            }


            if (fechaActivada)
            {
                db.agregarParametro(parametros, "@fechaDesde", fechaMinima);
                db.agregarParametro(parametros, "@fechaHasta", fechaMaxima);
            }
            else
            {
                db.agregarParametro(parametros, "@fechaDesde", null);
                db.agregarParametro(parametros, "@fechaHasta", null);
            }

            int cantPaginas = 0;

            cantPaginas = toInt(db.ejecutarStoredConRetorno("CHAR_DE_30.st_obtenerMaximaPaginaFacturasFiltradas", parametros, "@ultimaPagina", cantPaginas));

            return cantPaginas;
        }

        private Factura deserializarFactura(Dictionary<string, object> item)
        {
            Factura factura = new Factura();
            factura.id = toLong(item["id_factura"]);
            factura.formaDePago = item["forma_pago"].ToString();
            factura.tipoVisibilidad = item["tipo_visibilidad"].ToString();
            factura.costoVisibilidad = toDouble(item["costo_visibilidad"]);
            factura.totalAFacturar = toDouble(item["total_facturar"]);
            factura.fecha = toDate(item["factura_fecha"]);

            return factura;
        }
    }
}
