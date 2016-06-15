namespace WindowsFormsApplication1.Calificar
{
    internal class Calificacion
    {
        public long id;
        int calificacion;
        string comentarios;

        public Calificacion(long id, int calificacion, string comentarios)
        {
            this.id = id;
            this.calificacion = calificacion;
            this.comentarios = comentarios;
        }
    }
}