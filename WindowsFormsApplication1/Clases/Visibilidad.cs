using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    public class Visibilidad
    {
        public long id;// { get; }

        public string nombre;

        public double precio;

	    public double porcentajeVenta;

        public Visibilidad(long id,string nombre,double precio,double porcentajeVenta)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.porcentajeVenta = porcentajeVenta;
        }


    }
}
