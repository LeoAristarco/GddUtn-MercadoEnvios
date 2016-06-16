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

        public ABMVisibilidad(Form formAnterior)
        {

            this.formAnterior = formAnterior;

            visibilidades = repositorio.obtenerVisibilidades();

            InitializeComponent();
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
        private List<Visibilidad> visibilidades;

        private void volverButton_Click(object sender, EventArgs e)
        {
            Hide();
            formAnterior.ShowDialog();
        }

        private void ABMVisibilidad_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            DataGridViewTextBoxColumn cNombre = new DataGridViewTextBoxColumn();
            cNombre.HeaderText = "Nombre";
            cNombre.ReadOnly = true;
            tablaVisibilidad.Columns.Add(cNombre);
            DataGridViewTextBoxColumn cPrecio = new DataGridViewTextBoxColumn();
            cPrecio.HeaderText = "Precio";
            cPrecio.ReadOnly = true;
            tablaVisibilidad.Columns.Add(cPrecio);
            DataGridViewTextBoxColumn cPorcentaje = new DataGridViewTextBoxColumn();
            cPorcentaje.HeaderText = "Porcentaje de Venta";
            cPorcentaje.ReadOnly = true;
            tablaVisibilidad.Columns.Add(cPorcentaje);

            foreach (Visibilidad visibilidad in visibilidades)
            {
                tablaVisibilidad.Rows.Add(visibilidad.nombre);
                tablaVisibilidad.Rows.Add(visibilidad.precio);
                tablaVisibilidad.Rows.Add(visibilidad.porcentajeVenta);
            }
        }

        private void tablaVisibilidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            visibilidadSeleccionada = visibilidades[tablaVisibilidad.SelectedRows[0].Index];
            //aca deberia setear la visibilidad seleccionada
        }
    }
}
