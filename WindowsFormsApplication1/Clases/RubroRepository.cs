using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Generar_Publicación
{
    internal class RubroRepository:Repository
    {
        internal List<Rubro> obtenerRubros()
        {
            List<Dictionary<string, object>> tabla = db.ejecutarConsulta("select * from RUBRO");

            List<Rubro> rubros = new List<Rubro>();

            foreach (Dictionary<string, object> fila in tabla)
            {
                rubros.Add(deserializarRubro(fila));
            }

            return rubros;
        }

        private Rubro deserializarRubro(Dictionary<string, object> fila)
        {
            return new Rubro(toLong(fila["id_rubro"]), (string)fila["descripción_corta"], (string)fila["descripción_larga"]);
        }

        internal void updateRubro(Rubro rubroAModificar)
        {
            Dictionary<string, object> filaPublicacion = serializarRubro(rubroAModificar);
            List<SqlParameter> parametros = new List<SqlParameter>();

            string update = "update RUBRO set ";

            foreach (string clave in filaPublicacion.Keys)
            {
                db.agregarParametro(parametros, "@" + clave, filaPublicacion[clave]);
                update += clave + "=@" + clave + ", ";
            }

            update = update.Remove(update.Length - 1);
            update += " where id_rubro = " + rubroAModificar.id.ToString();

            db.ejecutarConsulta(update, parametros);
        }

        internal void deleteRubro(Rubro rubro)
        {
            db.ejecutarConsulta("delete from RUBRO where id_rubro=" + rubro.id.ToString());
        }

        private Dictionary<string, object> serializarRubro(Rubro rubroAModificar)
        {
            Dictionary<string, object> fila = new Dictionary<string, object>();

            fila.Add("id_rubro", rubroAModificar.id);
            fila.Add("descripción_corta", rubroAModificar.descripcionCorta);
            fila.Add("descripción_larga", rubroAModificar.descripcionLarga);

            return fila;
        }
    }
}