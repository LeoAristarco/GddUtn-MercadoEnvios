namespace WindowsFormsApplication1.Clases
{
    public class EstadoPublicacion
    {
        public long id;// { get; }
        public string nombre;

        public EstadoPublicacion(long id,string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}