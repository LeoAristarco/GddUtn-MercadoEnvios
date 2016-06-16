using System;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Calificar
{
    internal class Compra
    {
        public long id;
	    public Usuario comprador;
        public Publicacion publicacion;
        public DateTime fechaDeOperacion;
	    public double monto;
        public int cantidad;
        public Calificacion calificacion;
    }
}