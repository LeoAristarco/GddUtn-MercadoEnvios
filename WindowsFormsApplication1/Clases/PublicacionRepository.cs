using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Calificar;
using WindowsFormsApplication1.Generar_Publicación;

namespace WindowsFormsApplication1.Clases
{
    class PublicacionRepository:Repository
    {

        public void agregarPublicacion(Publicacion publicacion)
        {
            //Dictionary<string, object> filaPublicacion = serializarSinId(publicacion);

            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@descripcion", publicacion.descripcion);
            db.agregarParametro(parametros, "@stock", publicacion.stock);
            db.agregarParametro(parametros, "@fecha_inicio", publicacion.fechaInicio.Date);
            db.agregarParametro(parametros, "@fecha_vencimiento", publicacion.fechaVencimiento.Date);
            db.agregarParametro(parametros, "@precio", publicacion.precio);
            db.agregarParametro(parametros, "@rubro", publicacion.rubro.id);
            db.agregarParametro(parametros, "@visibilidad", publicacion.visibilidad.id);
            db.agregarParametro(parametros, "@estado_publicacion", publicacion.estado.id);
            db.agregarParametro(parametros, "@usuario_responsable", publicacion.responsable.id);
            db.agregarParametro(parametros, "@tipo_publicacion", publicacion.tipo.id);
            db.agregarParametro(parametros, "@envio", publicacion.hayEnvio);

            //hacerInsert(filaPublicacion);
            db.ejecutarStoredProcedure("sp_AgregarPublicacion", parametros);
        }

        internal void darDeBajaPublicacionesVencidas(DateTime fechaSistema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@fechaDelSistema", fechaSistema);

            db.ejecutarStoredProcedure("st_actualizar_publicaciones_vencidas", parametros);
        }

        private void hacerInsert(Dictionary<string, object> filaPublicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            string insert = "insert into publicacion (";

            string valores = "values(";

            foreach (string clave in filaPublicacion.Keys)
            {
                db.agregarParametro(parametros, "@" + clave, filaPublicacion[clave]);
                insert += clave + ",";
                valores += "@" + clave + ",";
            }

            insert = insert.Remove(insert.Length - 1);
            insert += ") ";

            valores = valores.Remove(valores.Length - 1);
            valores += ")";

            db.ejecutarConsulta(insert + valores, parametros);
        }

        internal List<Publicacion> obtenerPublicacionesPorFiltro(string text, Rubro rubroSeleccionado, int numeroPagina)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros,"@descripcion", text);

            if (rubroSeleccionado==null)
            {
                db.agregarParametro(parametros, "@rubroId", null);
            }
            else
            {
                db.agregarParametro(parametros, "@rubroId", rubroSeleccionado.id);
            }

            db.agregarParametro(parametros, "@pagina", numeroPagina);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("st_buscar_publicaciones", parametros);

            List<Publicacion> publicacionesFiltradas = new List<Publicacion>();

            foreach (Dictionary<string,object> item in tabla)
            {
                publicacionesFiltradas.Add(deserializarPublicacionConIdYSinDatosFactura(item));
            }

            return publicacionesFiltradas;
        }

        private Publicacion deserializarPublicacionConIdYSinDatosFactura(Dictionary<string, object> item)
        {
            Publicacion publicacion = new Publicacion();
            VisibilidadRepository repoVisib = new VisibilidadRepository();
            EstadoPublicacionRepository repoEstado = new EstadoPublicacionRepository();
            UsuarioRepository repoUser = new UsuarioRepository();
            TipoPublicacionRepository repoTipo = new TipoPublicacionRepository();
            RubroRepository repoRubro = new RubroRepository();

            publicacion.id = toLong(item["id_publicacion"]);
            publicacion.hayEnvio = toBool(item["envio"]);
            publicacion.descripcion = item["descripcion"].ToString();
            publicacion.stock = toLong(item["stock"]);
            publicacion.fechaInicio = toDate(item["fecha_inicio"]);
            publicacion.fechaVencimiento = toDate(item["fecha_vencimiento"]);
            publicacion.precio = toDouble(item["precio"]);
            publicacion.rubro = repoRubro.traerPorId(toLong(item["rubro"]));
            publicacion.visibilidad = repoVisib.traerPorId(toLong(item["visibilidad"]));
            publicacion.estado = repoEstado.traerPorId(toLong(item["estado_publicacion"]));
            publicacion.tipo = repoTipo.traerPorId(toLong(item["tipo_publicacion"]));
            publicacion.factura = new Factura();
            publicacion.factura.id = toLong(item["factura"]);
            publicacion.responsable = repoUser.traerPorId(toLong(item["usuario_responsable"]));//MAPEAR BIEN USUARIO

            return publicacion;
        }

        internal int cantidadDePaginasFiltradas(string text, Rubro rubroSeleccionado)
        {
            int cantidadPaginas = 0;

            List<SqlParameter> parametros = new List<SqlParameter>();
            db.agregarParametro(parametros, "@descripcion", text);

            if (rubroSeleccionado == null)
            {
                db.agregarParametro(parametros, "@rubroId", null);
            }
            else
            {
                db.agregarParametro(parametros, "@rubroId", rubroSeleccionado.id);
            }

            //db.agregarParametro(parametros, "@pagina", numeroPagina);
            //db.agregarParametro(parametros, "@ultimaPagina", cantidadPaginas);

            cantidadPaginas = toInt(db.ejecutarStoredConRetorno("st_buscar_publicaciones_ULTIMA_PAGINA", parametros, "@ultimaPagina",0));

            return cantidadPaginas;//No se como hacer con un stored que devuelve un int
        }

        public Publicacion deserializarPublicacionConId(Dictionary<string, object> item)
        {
            Publicacion publicacion = new Publicacion();
            VisibilidadRepository repoVisib = new VisibilidadRepository();
            EstadoPublicacionRepository repoEstado = new EstadoPublicacionRepository();
            UsuarioRepository repoUser = new UsuarioRepository();
            TipoPublicacionRepository repoTipo = new TipoPublicacionRepository();
            RubroRepository repoRubro = new RubroRepository();

            publicacion.id = toLong(item["id_publicacion"]);
            publicacion.hayEnvio = toBool(item["envio"]);
            publicacion.descripcion = item["descripcion"].ToString();
            publicacion.stock = toLong(item["stock"]);
            publicacion.fechaInicio = toDate(item["fecha_inicio"]);
            publicacion.fechaVencimiento = toDate(item["fecha_vencimiento"]);
            publicacion.precio = toDouble(item["precio"]);
            publicacion.rubro = repoRubro.traerPorId(toLong(item["rubro"]));
            publicacion.visibilidad = repoVisib.traerPorId(toLong(item["visibilidad"]));
            publicacion.estado = repoEstado.traerPorId(toLong(item["estado_publicacion"]));
            publicacion.responsable = repoUser.traerPorId(toLong(item["usuario_responsable"]));
            publicacion.tipo = repoTipo.traerPorId(toLong(item["tipo_publicacion"]));

            return publicacion;
        }

        private Dictionary<string, object> serializarSinId(Publicacion publicacion)
        {
            Dictionary<string, object> fila = new Dictionary<string, object>();

            //fila.Add("id_publicacion",publicacion.id);//ESTO LO SACO PORQUE ES LA PK
            fila.Add("descripcion", publicacion.descripcion);
            fila.Add("stock", publicacion.stock);
            fila.Add("fecha_inicio",publicacion.fechaInicio.Date);//Aca hay que obtener la fecha de un archivo
            fila.Add("fecha_vencimiento",publicacion.fechaVencimiento.Date);//Esto al parecer se mapea asi
            fila.Add("precio", publicacion.precio);
            fila.Add("rubro", publicacion.rubro.id);
            fila.Add("visibilidad", publicacion.visibilidad.id);
            fila.Add("estado_publicacion", publicacion.estado.id);
            fila.Add("usuario_responsable", publicacion.responsable.id);
            fila.Add("tipo_publicacion", publicacion.tipo.id);

            return fila;
        }

        internal void updatePublicacion(Publicacion publicacion)
        {
            Dictionary<string, object> filaPublicacion = serializarSinId(publicacion);

            List<SqlParameter> parametros = new List<SqlParameter>();

            string update = "update publicacion set ";

            foreach (string clave in filaPublicacion.Keys)
            {
                db.agregarParametro(parametros, "@" + clave, filaPublicacion[clave]);
                update += clave + "=@" + clave + ", ";
            }

            update = update.Remove(update.Length - 1);
            update += " where id_publicacion = " + publicacion.id.ToString();

            db.ejecutarConsulta(update , parametros);
        }

        /*private Dictionary<string, object> serializarConId(Publicacion publicacion)
        {
            Dictionary<string, object> fila = serializarSinId(publicacion);

            fila.Add("id_publicacion", publicacion.id);

            return fila;
        }*/
    }
}
