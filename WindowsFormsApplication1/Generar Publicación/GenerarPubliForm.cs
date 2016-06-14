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
        private Publicacion publicacion;

        private PublicacionRepository repositorio = new PublicacionRepository();
        private Form formularioAnterior;
        private List<Rubro> rubros;
        private List<TipoPublicacion> tipos;

        public GenerarPubliForm(Publicacion publicacion, Form formularioAnterior)
        {

            this.publicacion = publicacion;

            update = true;

            this.formularioAnterior = formularioAnterior;

            inicializarFormulario();
        }

        public GenerarPubliForm(Usuario usuario,Form formularioAnterior)
        {

            publicacion = new Publicacion();

            publicacion.responsable = usuario;

            update = false;

            this.formularioAnterior = formularioAnterior;

            inicializarFormulario();
        }

        private void GenerarPubliForm_Load(object sender, EventArgs e)
        {
        }

        private void inicializarFormulario()
        {
            InitializeComponent();

            VisibilidadRepository repoVisibilidad = new VisibilidadRepository();
            visibilidades = repoVisibilidad.obtenerVisibilidades();

            foreach (Visibilidad v in visibilidades)
            {
                visibilidad.Items.Add(v.nombre);
            }

            EstadoPublicacionRepository repoEstado = new EstadoPublicacionRepository();
            estados = repoEstado.obetenerEstadosPublicacion();

            foreach (EstadoPublicacion e in estados)
            {
                estado.Items.Add(e.nombre);
            }

            RubroRepository repoRubro = new RubroRepository();
            rubros = repoRubro.obtenerRubros();

            foreach (Rubro item in rubros)
            {
                rubro.Items.Add(item.descripcionCorta);
            }

            TipoPublicacionRepository repoTipo = new TipoPublicacionRepository();
            tipos = repoTipo.obtenerTiposPublicacion();

            foreach (TipoPublicacion item in tipos)
            {
                tipo.Items.Add(item.nombre);
            }

            if (update)
            {
                visibilidad.SelectedItem = publicacion.visibilidad.nombre;
                fechaFinalizacion.Value = publicacion.fechaVencimiento;
                estado.SelectedItem = publicacion.estado.nombre;
                tipo.SelectedItem = publicacion.tipo.nombre;
            }
            else
            {
                publicacion.descripcion = "";
                publicacion.hayEnvio = true;
                publicacion.precio = 0;
                publicacion.stock = 0;
            }

            descripcion.Text = publicacion.descripcion;
            hayEnvio.Checked = publicacion.hayEnvio;
            precio.Text = publicacion.precio.ToString();
            stock.Text = publicacion.stock.ToString();
        }

        private void limpiarFormulario()
        {
            //InitializeComponent();
            inicializarFormulario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setPublicacionInformation();

            if (update)
            {
                repositorio.updatePublicacion(publicacion);
            }

            else
            {
                repositorio.agregarPublicacion(publicacion);
            }
        }

        private void setPublicacionInformation()
        {
            publicacion.descripcion = descripcion.Text;
            publicacion.estado = estados[estado.SelectedIndex];
            publicacion.fechaInicio = new DateTime();//Vaya a saber vieja como la obtengo
            publicacion.fechaVencimiento = fechaFinalizacion.Value;
            publicacion.hayEnvio = hayEnvio.Checked;
            publicacion.precio = Convert.ToDouble(precio.Text);
            publicacion.rubro = rubros[rubro.SelectedIndex];
            publicacion.stock = Convert.ToInt64(stock.Text);
            publicacion.tipo = tipos[tipo.SelectedIndex];
        }

        public List<Visibilidad> visibilidades { get; set; }

        public List<EstadoPublicacion> estados { get; set; }

        public bool update { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formularioAnterior.Show();
            Hide();
        }

        private void tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipos[tipo.SelectedIndex].sosSubasta())
            {
                stock.Text = "1";
                stock.ReadOnly = true;
            }
            else
            {
                stock.ReadOnly = false;
            }
        }
    }
}
