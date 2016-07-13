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
        private CompraRepository repositorioCompra = new CompraRepository();
        private OfertaRepository repositorioOferta = new OfertaRepository();
        private UsuarioRepository repoUsuario = new UsuarioRepository();
        private int numeroPaginaCompra = 1;
        private int numeroPaginaOferta = 1;
        private int cantidadMaxDePagsCompra = 0;
        private int cantidadMaxDePagsOferta = 0;
        private List<Compra> compras;
        private List<Oferta> ofertas;
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
            buscarPaginaCompra();
            buscarPaginaOferta();
        }

        private void inicializarFormulario()
        {
            inicializarDataGridCompra();
            inicializarDataGridOferta();
            tablaCompras.Rows.Clear();
            tablaOfertas.Rows.Clear();
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

            int cantidadOperaciones = repoUsuario.cantidadOperacionesSinCalificar(usuario);
            cantOperacionesSinCalificar.Text = cantidadOperaciones.ToString();
        }

        private void inicializarDataGridCompra()
        {
            DataGridViewTextBoxColumn cDescripcion = new DataGridViewTextBoxColumn();
            cDescripcion.HeaderText = "Descripcion";
            cDescripcion.ReadOnly = true;
            tablaCompras.Columns.Add(cDescripcion);
            DataGridViewTextBoxColumn cCantidad = new DataGridViewTextBoxColumn();
            cCantidad.HeaderText = "Cantidad";
            cCantidad.ReadOnly = true;
            tablaCompras.Columns.Add(cCantidad);
            DataGridViewTextBoxColumn cMonto = new DataGridViewTextBoxColumn();
            cMonto.HeaderText = "Monto";
            cMonto.ReadOnly = true;
            tablaCompras.Columns.Add(cMonto);
            DataGridViewTextBoxColumn cfechaOperacion = new DataGridViewTextBoxColumn();
            cfechaOperacion.HeaderText = "Fecha de Operacion";
            cfechaOperacion.ReadOnly = true;
            tablaCompras.Columns.Add(cfechaOperacion);
        }

        private void inicializarDataGridOferta()
        {
            DataGridViewTextBoxColumn cDescripcion = new DataGridViewTextBoxColumn();
            cDescripcion.HeaderText = "Descripcion";
            cDescripcion.ReadOnly = true;
            tablaOfertas.Columns.Add(cDescripcion);
            DataGridViewTextBoxColumn cMonto = new DataGridViewTextBoxColumn();
            cMonto.HeaderText = "Monto ofertado";
            cMonto.ReadOnly = true;
            tablaOfertas.Columns.Add(cMonto);
            DataGridViewTextBoxColumn cConcretada = new DataGridViewTextBoxColumn();
            cConcretada.HeaderText = "Oferta concretada";
            cConcretada.ReadOnly = true;
            tablaOfertas.Columns.Add(cConcretada);
            DataGridViewTextBoxColumn cfechaOperacion = new DataGridViewTextBoxColumn();
            cfechaOperacion.HeaderText = "Fecha de oferta";
            cfechaOperacion.ReadOnly = true;
            tablaOfertas.Columns.Add(cfechaOperacion);
        }

        private void buscarPaginaCompra()
        {
            compras = repositorioCompra.obtenerComprasPorPagina(usuario, numeroPaginaCompra);

            if (cantidadMaxDePagsCompra == 0)
            {
                cantidadMaxDePagsCompra = repositorioCompra.cantidadDePaginasComprasDeCliente(usuario);
            }

            cargarDataGridCompra();
        }

        private void buscarPaginaOferta()
        {
            ofertas = repositorioOferta.obtenerOfertasPorPagina(usuario, numeroPaginaOferta);

            if (cantidadMaxDePagsOferta == 0)
            {
                cantidadMaxDePagsOferta = repositorioOferta.cantidadDePaginasOfertasDeCliente(usuario);
            }

            cargarDataGridOferta();
        }

        private void cargarDataGridCompra()
        {
            tablaCompras.Rows.Clear();
            foreach (Compra compra in compras)
            {
                tablaCompras.Rows.Add(compra.publicacion.descripcion, compra.cantidad, compra.monto, compra.fechaDeOperacion);
            }
        }

        private void cargarDataGridOferta()
        {
            tablaOfertas.Rows.Clear();
            foreach (Oferta oferta in ofertas)
            {
                tablaOfertas.Rows.Add(oferta.publicacion.descripcion, oferta.montoOfertado, oferta.concretada, oferta.fechaOferta);
            }
        }

        private void btnPrimerPag_Click(object sender, EventArgs e)
        {
            numeroPaginaCompra = 1;
            buscarPaginaCompra();
        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {
            numeroPaginaCompra = cantidadMaxDePagsCompra;
            buscarPaginaCompra();
        }

        private void btnSiguientePag_Click(object sender, EventArgs e)
        {
            numeroPaginaCompra++;

            if (numeroPaginaCompra > cantidadMaxDePagsCompra)
            {
                numeroPaginaCompra = cantidadMaxDePagsCompra;
                return;
            }
            buscarPaginaCompra();
        }

        private void btnAnteriorPag_Click(object sender, EventArgs e)
        {
            numeroPaginaCompra--;

            if (numeroPaginaCompra < 1)
            {
                numeroPaginaCompra = 1;
                return;
            }
            buscarPaginaCompra();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void HistorialCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroPaginaOferta = cantidadMaxDePagsOferta;
            buscarPaginaOferta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numeroPaginaOferta++;

            if (numeroPaginaOferta > cantidadMaxDePagsOferta)
            {
                numeroPaginaOferta = cantidadMaxDePagsOferta;
                return;
            }
            buscarPaginaOferta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numeroPaginaOferta--;

            if (numeroPaginaOferta < 1)
            {
                numeroPaginaOferta = 1;
                return;
            }
            buscarPaginaOferta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeroPaginaOferta = 1;
            buscarPaginaOferta();
        }
    }
}
