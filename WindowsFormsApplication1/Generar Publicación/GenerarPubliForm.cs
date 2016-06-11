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
    public partial class GenerarPubliForm : Form
    {
        private Publicacion publicacion = null;
        private Usuario usuario;

        private PublicacionRepository repositorio;
        public GenerarPubliForm(Publicacion publicacion)
        {
            InitializeComponent();
            this.publicacion = publicacion;
            this.usuario = publicacion.responsable;
            update = true;
        }

        public GenerarPubliForm(Usuario usaurio)
        {
            InitializeComponent();

            this.usuario = usuario;

            update = false;
        }

        private void GenerarPubliForm_Load(object sender, EventArgs e)
        {
            repositorio = new PublicacionRepository();

            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            VisibilidadRepository repoVisibilidad = new VisibilidadRepository();
            visibilidades = repoVisibilidad.obtenerVisibilidades();

            foreach (Visibilidad v in visibilidades)
            {
                visibilidad.Items.Add(v);
            }

            EstadoPublicacionRepository repoEstado = new EstadoPublicacionRepository();
            estados = repoEstado.obetenerEstadosPublicacion();

            foreach (EstadoPublicacion e in estados)
            {
                estado.Items.Add(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (update)
            {
                repositorio.updatePublicacion(publicacion);
            }

            else
            {
                repositorio.agregarPublicacion(publicacion);
            }

        }

        public List<Visibilidad> visibilidades { get; set; }

        public List<EstadoPublicacion> estados { get; set; }

        public bool update { get; set; }
    }
}
