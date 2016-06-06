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
            List<SqlParameter> parametros = new List<SqlParameter>();

            Dictionary<string, object> filaPublicacion = serializarPublicacion(publicacion);

            string insert = "insert into publicacion (";

            string valores = "value(";

            foreach (string clave in filaPublicacion.Keys)
            {
                db.agregarParametro(parametros, "@" + clave, filaPublicacion[clave]);
                insert += clave+",";
                valores += "@" + clave+",";
            }

            insert = insert.Remove(insert.Length - 1);
            insert += ") ";

            valores = valores.Remove(valores.Length - 1);
            valores += ")";

            db.ejecutarConsulta(insert + valores, parametros);

        }

        private Dictionary<string, object> serializarPublicacion(Publicacion publicacion)
        {
            Dictionary<string, object> fila = new Dictionary<string, object>();

            fila.Add("id_publicacion",publicacion.id);
            fila.Add("descripcion",publicacion.descripcion);
            fila.Add("stock",publicacion.stock);
            //fila.Add("fecha_inicio",publicacion.fechaInicio);
            //fila.Add("fecha_vencimiento",publicacion.fechaVencimiento);//EWsto hay q ver cmo se mapea
            fila.Add("precio",publicacion.precio);
            fila.Add("rubro",publicacion.rubro.id);
            fila.Add("visibilidad",publicacion.visibilidad.id);
            fila.Add("estado_publicacion",publicacion.estado.id);
            fila.Add("usuario_responsable",publicacion.responsable.id);
            fila.Add("tipo_publicacion",publicacion.tipo.id);

            return fila;
        }
    }
}
