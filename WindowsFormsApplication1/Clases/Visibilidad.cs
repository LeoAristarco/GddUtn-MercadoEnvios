using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    class Visibilidad
    {
        public long id { get; }

        private string nombre;

        private double precio;

	    private double porcentajeVenta;

        public Visibilidad(long id,string nombre,double precio,double porcentajeVenta)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.porcentajeVenta = porcentajeVenta;
        }


    }
}
