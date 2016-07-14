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

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class ABMPublicacion : Form
    {
        private Usuario usuario;
        private Form formAnterior;

        public ABMPublicacion(Usuario usuario,Form formAnterior)
        {
            this.usuario = usuario;
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarPublicacion grarPublicacion = new GenerarPublicacion(usuario, this);

            Hide();

            grarPublicacion.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarPublicacionesUser buscarPublicaciones = new BuscarPublicacionesUser(usuario, this);

            Hide();

            buscarPublicaciones.ShowDialog();
        }
    }
}
