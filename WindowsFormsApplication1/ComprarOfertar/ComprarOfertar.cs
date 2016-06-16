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
        private bool busquedaConFiltros = false;
        private List<Rubro> filtrosRubro = new List<Rubro>();

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
            tablaPublicacionesFiltradas = repositorio.obtenerDataGridPublicacionesFiltradas();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            busquedaConFiltros = false;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (filtroDescripcion.Text==""&&filtrosRubro.Count==0)
            {
                busquedaConFiltros = false;
            }
            else
            {
                busquedaConFiltros = true;
            }
        }
    }
}
