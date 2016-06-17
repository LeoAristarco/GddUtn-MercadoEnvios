using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Calificar;

namespace WindowsFormsApplication1.Clases
{
    public class Publicacion
    {
        public long id;// { get; }
        public string descripcion;// { get; }
        public long stock ;//{ get; }
        public DateTime fechaInicio;// { get; }
        public DateTime fechaVencimiento;// { get; }
        public double precio;// { get; }
        public Rubro rubro ;//{ get; }
        public Visibilidad visibilidad;// { get; }
        public EstadoPublicacion estado ;//{ get; }
        public Usuario responsable ;//{ get; }
        public TipoPublicacion tipo;// { get; }
        public bool hayEnvio;
        public Calificacion calificacion;

        public Publicacion(long id, string descripcion, long stock, DateTime fechaInicio, DateTime fechaVencimiento, double precio, Rubro rubro, Visibilidad visibilidad, EstadoPublicacion estado, Usuario responsable,TipoPublicacion tipo,bool hayEnvio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.stock = stock;
            this.fechaInicio = fechaInicio;
            this.fechaVencimiento = fechaVencimiento;
            this.precio = precio;
            this.rubro = rubro;
            this.visibilidad = visibilidad;
            this.estado = estado;
            this.responsable = responsable;
            this.tipo = tipo;
            this.hayEnvio = hayEnvio;
        }

        internal bool sosSubasta()
        {
            return tipo.sosSubasta();
        }

        public Publicacion()
        {
        }
    }
}
