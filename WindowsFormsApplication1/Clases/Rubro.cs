namespace WindowsFormsApplication1.Clases
{
    public class Rubro
    {
        public long id;//{ get; }
        public string descripcionCorta;
        public string descripcionLarga;

        public Rubro(long id,string descripcionCorta,string descripcionLarga)
        {
            this.id = id;
            this.descripcionCorta = descripcionCorta;
            this.descripcionLarga = descripcionLarga;
        }
    }
}