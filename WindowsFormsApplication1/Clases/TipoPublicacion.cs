using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Clases
{
    public class TipoPublicacion
    {
        internal long id;
        internal string nombre;

        public TipoPublicacion(long id,string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        internal bool sosSubasta()
        {
            return nombre.ToLower() == "subasta";
        }
    }
}