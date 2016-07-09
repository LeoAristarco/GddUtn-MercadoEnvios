using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    public class Rol
    {
        public long id;
        public string nombre;
        public bool habilitado;

        public Rol(long id,string nombre,bool habilitado)
        {
            this.id = id;
            this.nombre = nombre;
            this.habilitado = habilitado;
        }
    }
}
