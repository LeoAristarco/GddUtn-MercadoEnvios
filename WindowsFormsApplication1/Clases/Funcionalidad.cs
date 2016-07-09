using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    public class Funcionalidad
    {
        public long id { get; set; }
        public string nombre { get; set; } 
        public bool habilitado { get; set; }

        public Funcionalidad(long id, string nombre, bool habilitado)
        {
            this.id = id;
            this.nombre = nombre;
            this.habilitado = habilitado;
        }
    }
}
