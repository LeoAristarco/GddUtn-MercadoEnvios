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
            ofertaActual.Text = publicacion.precio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            detallePublicacion.Show();
            Close();
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            int monto = Convert.ToInt32(montoOferta.Text);
            if (montoOferta.Text.Contains(",")|| montoOferta.Text.Contains("."))
            {
                MessageBox.Show("No se permiten ofertas con valores decimales");
                return;
            }
            if (monto<=publicacion.precio)
            {
                MessageBox.Show("La cantidad ofertada debe ser mayor a la actual");
                return;
            }

            string retornoValidacion = repositorio.validacionDeOferta(publicacion, user);

            if (retornoValidacion!= "todo piolaa")
            {
                MessageBox.Show(retornoValidacion.ToUpper());
            }

            repositorio.ofertar(publicacion, user, monto,checkBox1.Checked);
            detallePublicacion.Show();
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            montoOferta.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !publicacion.hayEnvio)
            {
                checkBox1.Checked = false;
                MessageBox.Show("Esta publicacion no permite envio");
            }
        }
    }
}
