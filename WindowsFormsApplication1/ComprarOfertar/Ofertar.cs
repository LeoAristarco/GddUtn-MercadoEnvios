using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class Ofertar : Form
    {
        private DetallePublicacion detallePublicacion;
        private Publicacion publicacion;
        private Usuario user;
        private OfertaRepository repositorio = new OfertaRepository();

        public Ofertar(Publicacion publicacion, Usuario user, DetallePublicacion detallePublicacion)
        {
            this.publicacion = publicacion;
            this.user = user;
            this.detallePublicacion = detallePublicacion;
            InitializeComponent();
        }

        private void Ofertar_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            detallePublicacion.Show();
            Close();
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            repositorio.ofertar(publicacion, user, Convert.ToDouble(montoOferta.Text));
            detallePublicacion.Show();
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            montoOferta.Text = "";
        }
    }
}
