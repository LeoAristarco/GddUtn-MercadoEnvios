using System;
using System.Collections.Generic;
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
            return new Rubro((long)fila["id_rubro"], (string)fila["descripción_corta"], (string)fila["descripción_larga"]);
        }
    }
}