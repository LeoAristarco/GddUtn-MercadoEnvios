namespace WindowsFormsApplication1.Calificar
{
    public class Calificacion
    {
        public long id;
        public int estrellas;
        public string comentarios;

        public Calificacion(long id, int estrellas, string comentarios)
        {
            this.id = id;
            this.estrellas = estrellas;
            this.comentarios = comentarios;
        }

        public Calificacion()
        {
        }
    }
}