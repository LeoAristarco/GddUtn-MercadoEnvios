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

namespace WindowsFormsApplication1.Calificar
{
    public partial class CalificarVendedor : Form
    {
        private Form formAnterior;
        private CompraRepository repositorio = new CompraRepository();
        private List<Compra> comprasSinCalificar;
        private Usuario usuario;
        private Compra compraSeleccionada;

        public CalificarVendedor(Usuario usuario,Form formAnterior)
        {
            this.formAnterior = formAnterior;

            this.usuario = usuario;

            InitializeComponent();
            //ACA DEBERIA CARGAR LA LISTA DE COMPRAS
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            CalificarDetalle calificar = new CalificarDetalle(this,compraSeleccionada.calificacion,usuario);

            Hide();

            calificar.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void CalificarVendedor_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            comprasSinCalificar = repositorio.obtenerComprasSinCalificar(usuario);

            if (comprasSinCalificar.Count>0)
            {
                compraSeleccionada = comprasSinCalificar[0];
            }

            cargarPublicacionesADataGrid();
        }

        private void cargarPublicacionesADataGrid()
        {
            DataGridViewTextBoxColumn cDescripcion = new DataGridViewTextBoxColumn();
            cDescripcion.HeaderText = "Descripcion";
            cDescripcion.ReadOnly = true;
            tablaPublicacionesCalificar.Columns.Add(cDescripcion);
            DataGridViewTextBoxColumn cConEnvio = new DataGridViewTextBoxColumn();
            cConEnvio.HeaderText = "Con Envio";
            cConEnvio.ReadOnly = true;
            tablaPublicacionesCalificar.Columns.Add(cConEnvio);
            DataGridViewTextBoxColumn cfechaFin = new DataGridViewTextBoxColumn();
            cfechaFin.HeaderText = "Fecha de Finalizacion";
            cfechaFin.ReadOnly = true;
            tablaPublicacionesCalificar.Columns.Add(cfechaFin);

            foreach (Compra compra in comprasSinCalificar)
            {
                Publicacion publicacion = compra.publicacion;
                tablaPublicacionesCalificar.Rows.Add(publicacion.descripcion, publicacion.hayEnvio, publicacion.fechaVencimiento);
            }
            //POR AHORA SOLO CARGO ESTO,IGUAL SE DEBERIAN MOSTRAR SOLO 3 O 4 DATOS

        }

        private void tablaPublicacionesCalificar_Click(object sender, EventArgs e)
        {
            compraSeleccionada = comprasSinCalificar[tablaPublicacionesCalificar.CurrentCell.RowIndex];
        }

        private void btnVerPublicacion_Click(object sender, EventArgs e)
        {

        }
    }
}
