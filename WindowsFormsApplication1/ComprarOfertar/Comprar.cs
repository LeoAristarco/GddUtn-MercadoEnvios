using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Calificar;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class Comprar : Form
    {
        private Publicacion publicacion;
        private CompraRepository repositorio = new CompraRepository();
        private Usuario usuario;
        private DetallePublicacion detallePublicacion;

        public Comprar(Publicacion publicacion,Usuario usuario, DetallePublicacion detallePublicacion)
        {
            this.publicacion = publicacion;
            this.usuario = usuario;
            this.detallePublicacion = detallePublicacion;
            InitializeComponent();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            repositorio.comprar(publicacion, usuario, Convert.ToInt32(cantidad.Text));
            //SI TODO SALE BIEN..
            detallePublicacion.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detallePublicacion.Show();
            Close();
        }
    }
}
