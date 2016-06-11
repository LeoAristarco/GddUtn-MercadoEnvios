using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    class PublicacionRepository:Repository
    {

        public void agregarPublicacion(Publicacion publicacion)
        {
            Dictionary<string, object> filaPublicacion = serializarConId(publicacion);

            hacerInsert(filaPublicacion);
        }

        public void agregarPublicacion()
        {
            Dictionary<string, object> filaPublicacion = new Dictionary<string, object>();

            //zdfadfsdfsf

            hacerInsert(filaPublicacion);
        }

        private void hacerInsert(Dictionary<string, object> filaPublicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            string insert = "insert into publicacion (";

            string valores = "value(";

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

        private Dictionary<string, object> serializarSinId(Publicacion publicacion)
        {
            Dictionary<string, object> fila = new Dictionary<string, object>();

            //fila.Add("id_publicacion",publicacion.id);//ESTO LO SACO PORQUE ES LA PK
            fila.Add("descripcion", publicacion.descripcion);
            fila.Add("stock", publicacion.stock);
            fila.Add("fecha_inicio",publicacion.fechaInicio);
            fila.Add("fecha_vencimiento",publicacion.fechaVencimiento);//EWsto hay q ver cmo se mapea
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
            Dictionary<string, object> filaPublicacion = serializarConId(publicacion);

            List<SqlParameter> parametros = new List<SqlParameter>();

            string update = "update publicacion set ";

            foreach (string clave in filaPublicacion.Keys)
            {
                db.agregarParametro(parametros, "@" + clave, filaPublicacion[clave]);
                update += clave + "=@" + clave + ", ";
            }

            update = update.Remove(update.Length - 1);
            update += " where id_publicacion = " + filaPublicacion["id_publicacion"];

            db.ejecutarConsulta(update , parametros);
        }

        private Dictionary<string, object> serializarConId(Publicacion publicacion)
        {
            Dictionary<string, object> fila = serializarSinId(publicacion);

            fila.Add("id_publicacion", publicacion.id);

            return fila;
        }

    }
}
