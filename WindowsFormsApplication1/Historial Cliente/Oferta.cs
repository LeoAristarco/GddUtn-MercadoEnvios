using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public class Oferta
    {
        public long id;
        public Usuario ofertante;
        public Publicacion publicacion;
        public DateTime fechaOferta;
        public bool concretada;
        public double montoOfertado;
        public int precioEnvio;
    }
}
