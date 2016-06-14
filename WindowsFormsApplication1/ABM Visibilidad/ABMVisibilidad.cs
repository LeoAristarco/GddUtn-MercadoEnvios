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

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class ABMVisibilidad : Form
    {
        private Form formAnterior;
        private VisibilidadRepository repositorio = new VisibilidadRepository();
        public ABMVisibilidad()
        {
            InitializeComponent();

            tablaVisibilidad = repositorio.llenarDataGrid();
        }

        private void nuevaButton_Click(object sender, EventArgs e)
        {
            GenerarVisibilidad grarVisibilidad = new GenerarVisibilidad(this);

            Hide();

            grarVisibilidad.ShowDialog();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            GenerarVisibilidad grarVisibilidad = new GenerarVisibilidad(visibilidadSeleccionada,this);

            Hide();

            grarVisibilidad.ShowDialog();
        }

        private Visibilidad visibilidadSeleccionada;

        private void volverButton_Click(object sender, EventArgs e)
        {
            Hide();
            formAnterior.ShowDialog();
        }

        private void ABMVisibilidad_Load(object sender, EventArgs e)
        {

        }


    }
}
