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
    public partial class ComprarOfertar : Form
    {
        private Publicacion publicacionSeleccionada;
        private PublicacionRepository repositorio = new PublicacionRepository();
        private bool hayFiltroTexto = false;
        private bool hayFiltroRubro = false;
        private Rubro rubroSeleccionado = null;
        private int numeroPagina = 1;
        private int cantidadMaxDePags = 0;
        private List<Publicacion> publicacionesFiltradas;

        public ComprarOfertar()
        {
            InitializeComponent();
        }

        private void Publicaciones_Datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selecciono publicacion
        }

        private void ComprarOfertar_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            tablaPublicacionesFiltradas.Rows.Clear();
            filtroDescripcion.Text = "";
            //NO HACE NADA!!
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            filtroDescripcion.Text = "";
            rubroTextBox.Text = "";
            hayFiltroTexto = false;
            hayFiltroRubro = false;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (filtroDescripcion.Text=="")
            {
                hayFiltroTexto = false;
            }
        }
        public void agregarFiltroRubro(Rubro rubroSeleccionado)
        {
            this.rubroSeleccionado = rubroSeleccionado;
            hayFiltroRubro = true;
            rubroTextBox.Text = rubroSeleccionado.descripcionCorta;
        }

        private void btnAgregarRubros_Click(object sender, EventArgs e)
        {
            AgregarFiltrosRubro agregarFiltroRubro = new AgregarFiltrosRubro(this);
            Hide();
            ShowDialog();
        }

        private void btnBorrarDescripcion_Click(object sender, EventArgs e)
        {
            filtroDescripcion.Text = "";
            hayFiltroTexto = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            publicacionesFiltradas = repositorio.obtenerPublicacionesPorFiltro(filtroDescripcion.Text, rubroSeleccionado, numeroPagina);

            if (cantidadMaxDePags==0)
            {
                cantidadMaxDePags = repositorio.cantidadDePaginasFiltradas(filtroDescripcion.Text, rubroSeleccionado, numeroPagina);
            }

            cargarDataGrid();
        }

        private void cargarDataGrid()
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

            foreach (Publicacion publicacion in publicacionesFiltradas)
            {
                tablaPublicacionesFiltradas.Rows.Add(publicacion.descripcion);
                tablaPublicacionesFiltradas.Rows.Add(publicacion.hayEnvio);
                tablaPublicacionesFiltradas.Rows.Add(publicacion.fechaVencimiento);
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
            numeroPagina = cantidadMaxDePags;
            btnBuscar_Click(new object(), new EventArgs());
        }

        private void btnSiguientePag_Click(object sender, EventArgs e)
        {
            numeroPagina++;

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
    }
}
