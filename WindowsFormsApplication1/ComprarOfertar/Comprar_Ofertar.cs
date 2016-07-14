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
    public partial class Comprar_Ofertar : Form
    {
        private Publicacion publicacionSeleccionada;
        private PublicacionRepository repositorio = new PublicacionRepository();
        private Rubro rubroSeleccionado = null;
        private int numeroPagina = 1;
        private int cantidadMaxDePags = 0;
        private List<Publicacion> publicacionesFiltradas;
        private Usuario usuario;
        private Form formAnterior;

        public Comprar_Ofertar(Usuario usuario,Form formAnterior)
        {
            this.formAnterior = formAnterior;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void ComprarOfertar_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            inicializarDataGrid();
            tablaPublicacionesFiltradas.Rows.Clear();
            filtroDescripcion.Text = "";
            //NO HACE NADA!!
        }

        private void inicializarDataGrid()
        {
            DataGridViewTextBoxColumn cDescripcion = new DataGridViewTextBoxColumn();
            cDescripcion.HeaderText = "Descripcion";
            cDescripcion.ReadOnly = true;
            tablaPublicacionesFiltradas.Columns.Add(cDescripcion);
            DataGridViewTextBoxColumn cConEnvio = new DataGridViewTextBoxColumn();
            cConEnvio.HeaderText = "Con Envio";
            cConEnvio.ReadOnly = true;
            tablaPublicacionesFiltradas.Columns.Add(cConEnvio);
            DataGridViewTextBoxColumn cfechaFin = new DataGridViewTextBoxColumn();
            cfechaFin.HeaderText = "Fecha de Finalizacion";
            cfechaFin.ReadOnly = true;
            tablaPublicacionesFiltradas.Columns.Add(cfechaFin);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            filtroDescripcion.Text = "";
            rubroTextBox.Text = "";
            rubroSeleccionado = null;
        }

        public void agregarFiltroRubro(Rubro rubroSeleccionado)
        {
            this.rubroSeleccionado = rubroSeleccionado;
            rubroTextBox.Text = rubroSeleccionado.descripcionCorta;
        }

        private void btnAgregarRubros_Click(object sender, EventArgs e)
        {
            AgregarFiltrosRubro agregarFiltroRubro = new AgregarFiltrosRubro(this);
            Hide();
            agregarFiltroRubro.ShowDialog();
        }

        private void btnBorrarDescripcion_Click(object sender, EventArgs e)
        {
            filtroDescripcion.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            publicacionesFiltradas = repositorio.obtenerPublicacionesPorFiltro(filtroDescripcion.Text, rubroSeleccionado, numeroPagina);

            if (cantidadMaxDePags==0)
            {
                cantidadMaxDePags = repositorio.cantidadDePaginasFiltradas(filtroDescripcion.Text, rubroSeleccionado);
            }

            if (publicacionesFiltradas.Count>0)
            {
                publicacionSeleccionada = publicacionesFiltradas[0];
            }

            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            tablaPublicacionesFiltradas.Rows.Clear();
            foreach (Publicacion publicacion in publicacionesFiltradas)
            {
                tablaPublicacionesFiltradas.Rows.Add(publicacion.descripcion, publicacion.hayEnvio, publicacion.fechaVencimiento);
            }
            //POR AHORA SOLO CARGO ESTO,IGUAL SE DEBERIAN MOSTRAR SOLO 3 O 4 DATOS
        }

        private void btnPrimerPag_Click(object sender, EventArgs e)
        {
            numeroPagina = 1;
            btnBuscar_Click(new object(), new EventArgs());
        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {
            cantidadMaxDePags = repositorio.cantidadDePaginasFiltradas(filtroDescripcion.Text, rubroSeleccionado);
            numeroPagina = cantidadMaxDePags;
            btnBuscar_Click(new object(), new EventArgs());
        }

        private void btnSiguientePag_Click(object sender, EventArgs e)
        {
            numeroPagina++;

            cantidadMaxDePags = repositorio.cantidadDePaginasFiltradas(filtroDescripcion.Text, rubroSeleccionado);

            if (numeroPagina>cantidadMaxDePags)
            {
                numeroPagina = cantidadMaxDePags;
                return;
            }
            btnBuscar_Click(new object(), new EventArgs());
        }

        private void btnAnteriorPag_Click(object sender, EventArgs e)
        {
            numeroPagina--;

            if (numeroPagina <1)
            {
                numeroPagina = 1;
                return;
            }
            btnBuscar_Click(new object(), new EventArgs());
        }

        private void tablaPublicacionesFiltradas_Click(object sender, EventArgs e)
        {
            if (tablaPublicacionesFiltradas.CurrentCell.RowIndex>=publicacionesFiltradas.Count)
            {
                return;
            }

            publicacionSeleccionada = publicacionesFiltradas[tablaPublicacionesFiltradas.CurrentCell.RowIndex];
        }

        private void btnAbrirPublicacion_Click(object sender, EventArgs e)
        {
            DetallePublicacion verPublicacion = new DetallePublicacion(publicacionSeleccionada,formAnterior,usuario,true);
            Hide();
            verPublicacion.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void Comprar_Ofertar_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
