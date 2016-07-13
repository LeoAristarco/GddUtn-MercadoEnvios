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
        private Form formAnterior;

        public Comprar(Publicacion publicacion, Usuario usuario, Form formAnterior)
        {
            this.publicacion = publicacion;
            this.usuario = usuario;
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cantidad.Text)>publicacion.stock)
            {
                MessageBox.Show("Cantidad supera stock disponible");
                return;
            }
            repositorio.comprar(publicacion, usuario, Convert.ToInt32(cantidad.Text), checkBox1.Checked);
            //SI TODO SALE BIEN..
            formAnterior.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked&&!publicacion.hayEnvio)
            {
                checkBox1.Checked = false;
                MessageBox.Show("Esta publicacion no permite envio");
            }
        }

        private void Comprar_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
