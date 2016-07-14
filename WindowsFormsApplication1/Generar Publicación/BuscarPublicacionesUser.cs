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
    public partial class BuscarPublicacionesUser : Form
    {
        private Form formAnterior;
        private Usuario usuario;
        private PublicacionRepository repositorio = new PublicacionRepository();
        private Publicacion publicacionSeleccionada;
        private List<Publicacion> publicaciones;

        public BuscarPublicacionesUser(Usuario usuario,Form formAnterior)
        {
            this.formAnterior = formAnterior;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void inicializarFormulario()
        {
            inicializarDataGrid();
            tablaPublicaciones.Rows.Clear();
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

        private void BuscarPublicacionesUser_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
            buscarPublicaciones();
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            tablaPublicaciones.Rows.Clear();

            foreach (Publicacion publicacion in publicaciones)
            {
                tablaPublicaciones.Rows.Add(publicacion.descripcion, publicacion.hayEnvio, publicacion.fechaVencimiento);
            }
        }

        private void buscarPublicaciones()
        {
            publicaciones = repositorio.buscarPublicacionesDe(usuario);
        }

        private void tablaPublicaciones_Click(object sender, EventArgs e)
        {
            if (publicaciones.Count==0)
            {
                return;
            }

            if (tablaPublicaciones.CurrentCell.RowIndex >= publicaciones.Count)
            {
                return;
            }

            publicacionSeleccionada = publicaciones[tablaPublicaciones.CurrentCell.RowIndex];
        }

        private void btnAbrirPublicacion_Click(object sender, EventArgs e)
        {
            if (publicacionSeleccionada==null)
            {
                return;
            }

            GenerarPublicacion grarPublicacion = new GenerarPublicacion(usuario, publicacionSeleccionada, formAnterior);

            Hide();

            grarPublicacion.ShowDialog();

            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();

            Close();
        }
    }
}
