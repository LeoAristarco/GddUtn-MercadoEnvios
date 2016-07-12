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
    public partial class HistorialCalificaciones : Form
    {
        private Form formAnterior;
        private CompraRepository repoCompras = new CompraRepository();
        private CalificacionRepository repoCalificaciones = new CalificacionRepository();
        private Usuario usuario;
        private List<Compra> compras;
        private List<long> calificaciones;

        public HistorialCalificaciones(Form formAnterior,Usuario user)
        {
            usuario = user;
            this.formAnterior = formAnterior;
            compras = repoCompras.obtenerUltimas5Compras(usuario);
            calificaciones = repoCalificaciones.obtenerResumenCalificaciones(usuario);
            InitializeComponent();
        }

        private void HistorialCalificaciones_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            cargarDataGrid();

            inicializarTextBoxes();
        }

        private void inicializarTextBoxes()
        {
            estrellas1.Text = calificaciones[0].ToString();
            estrellas2.Text = calificaciones[1].ToString();
            estrellas3.Text = calificaciones[2].ToString();
            estrellas4.Text = calificaciones[3].ToString();
            estrellas5.Text = calificaciones[4].ToString();
        }

        private void cargarDataGrid()
        {
            DataGridViewTextBoxColumn cDescripcion = new DataGridViewTextBoxColumn();
            cDescripcion.HeaderText = "Descripcion";
            cDescripcion.ReadOnly = true;
            tablaUltimas5Compras.Columns.Add(cDescripcion);
            DataGridViewTextBoxColumn cCantidadEstrellas = new DataGridViewTextBoxColumn();
            cCantidadEstrellas.HeaderText = "Cantidad de Estrellas";
            cCantidadEstrellas.ReadOnly = true;
            tablaUltimas5Compras.Columns.Add(cCantidadEstrellas);

            foreach (Compra compra in compras)
            {
                tablaUltimas5Compras.Rows.Add(compra.publicacion.descripcion, compra.calificacion.estrellas);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void HistorialCalificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
