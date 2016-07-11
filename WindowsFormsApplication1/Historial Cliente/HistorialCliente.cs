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
using WindowsFormsApplication1.ComprarOfertar;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class HistorialCliente : Form
    {
        private Publicacion publicacionSeleccionada;
        private PublicacionRepository repositorio = new PublicacionRepository();
        private int numeroPagina = 1;
        private int cantidadMaxDePags = 0;
        private List<Publicacion> publicaciones;
        private Usuario usuario;
        private Form formAnterior;
        private CalificacionRepository repoCalificaciones = new CalificacionRepository();
        private List<long> calificaciones;

        public HistorialCliente(Usuario usuario,Form formAnterior)
        {
            this.formAnterior = formAnterior;
            this.usuario = usuario;
            calificaciones = repoCalificaciones.obtenerResumenCalificaciones(usuario);
            InitializeComponent();
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            inicializarDataGrid();
            tablaPublicaciones.Rows.Clear();
            inicializarTextBoxes();
            //NO HACE NADA!!
        }

        private void inicializarTextBoxes()
        {
            estrellas1.Text = calificaciones[0].ToString();
            estrellas2.Text = calificaciones[1].ToString();
            estrellas3.Text = calificaciones[2].ToString();
            estrellas4.Text = calificaciones[3].ToString();
            estrellas5.Text = calificaciones[4].ToString();
        }

        private void inicializarDataGrid()
        {
            DataGridViewTextBoxColumn cDescripcion = new DataGridViewTextBoxColumn();
            cDescripcion.HeaderText = "Descripcion";
            cDescripcion.ReadOnly = true;
            tablaPublicaciones.Columns.Add(cDescripcion);
            DataGridViewTextBoxColumn cConEnvio = new DataGridViewTextBoxColumn();
            cConEnvio.HeaderText = "Con Envio";
            cConEnvio.ReadOnly = true;
            tablaPublicaciones.Columns.Add(cConEnvio);
            DataGridViewTextBoxColumn cfechaFin = new DataGridViewTextBoxColumn();
            cfechaFin.HeaderText = "Fecha de Finalizacion";
            cfechaFin.ReadOnly = true;
            tablaPublicaciones.Columns.Add(cfechaFin);
        }

        private void buscarPagina()
        {
            publicaciones = repositorio.obtenerComprasYOfertasPorPagina(usuario, numeroPagina);

            if (cantidadMaxDePags == 0)
            {
                cantidadMaxDePags = repositorio.cantidadDePaginasComprasYOfertasDeCliente(usuario);
            }

            if (publicaciones.Count > 0)
            {
                publicacionSeleccionada = publicaciones[0];
            }

            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            tablaPublicaciones.Rows.Clear();
            foreach (Publicacion publicacion in publicaciones)
            {
                tablaPublicaciones.Rows.Add(publicacion.descripcion, publicacion.hayEnvio, publicacion.fechaVencimiento);
            }
            //POR AHORA SOLO CARGO ESTO,IGUAL SE DEBERIAN MOSTRAR SOLO 3 O 4 DATOS
        }

        private void btnPrimerPag_Click(object sender, EventArgs e)
        {
            numeroPagina = 1;
            buscarPagina();
        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {
            numeroPagina = cantidadMaxDePags;
            buscarPagina();
        }

        private void btnSiguientePag_Click(object sender, EventArgs e)
        {
            numeroPagina++;

            if (numeroPagina > cantidadMaxDePags)
            {
                numeroPagina = cantidadMaxDePags;
                return;
            }
            buscarPagina();
        }

        private void btnAnteriorPag_Click(object sender, EventArgs e)
        {
            numeroPagina--;

            if (numeroPagina < 1)
            {
                numeroPagina = 1;
                return;
            }
            buscarPagina();
        }

        private void tablaPublicaciones_Click(object sender, EventArgs e)
        {
            if (tablaPublicaciones.Rows.Count==0)
            {
                return;
            }

            publicacionSeleccionada = publicaciones[tablaPublicaciones.CurrentCell.RowIndex];
        }

        private void btnAbrirPublicacion_Click(object sender, EventArgs e)
        {
            DetallePublicacion verPublicacion = new DetallePublicacion(publicacionSeleccionada, this, usuario,false);
            Hide();
            verPublicacion.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }
    }
}
