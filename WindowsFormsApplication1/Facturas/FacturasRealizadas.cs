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
using WindowsFormsApplication1.Login;

namespace WindowsFormsApplication1.Facturas
{
    public partial class FacturasRealizadas : Form
    {
        private int numeroPagina = 1;
        private int cantidadMaxDePags = 0;
        private Form formAnterior;
        private long idUsuario = -1;
        private DateTime fechaMinima;
        private DateTime fechaMaxima;
        private double montoMaximo = 0;
        private double montoMinimo = 0;
        private FacturaRepository repositorioFactura = new FacturaRepository();
        private UsuarioRepository repositorioUsuario = new UsuarioRepository();
        private List<Factura> facturasFiltradas = new List<Factura>();

        public FacturasRealizadas(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            cargarDatos();

            if (cantidadMaxDePags==0)
            {
                cantidadMaxDePags = repositorioFactura.cantidadMaximaPaginasFacturasClienteFiltradas(idUsuario, montoMinimo, montoMaximo, filtroMontoActivado.Checked, fechaMinima, fechaMaxima, filtroFechaActivado.Checked);
            }

            facturasFiltradas = repositorioFactura.buscarFacturasPorFiltro(idUsuario, montoMinimo, montoMaximo, filtroMontoActivado.Checked, fechaMinima, fechaMaxima, filtroFechaActivado.Checked,numeroPagina);

            cargarDataGrid();

        }

        private void cargarDataGrid()
        {
            tablaFacturas.Rows.Clear();

            foreach (Factura factura in facturasFiltradas)
            {
                tablaFacturas.Rows.Add(factura.formaDePago,factura.tipoVisibilidad,factura.fecha,factura.totalAFacturar);
            }
        }

        private void cargarDatos()
        {
            idUsuario = repositorioUsuario.obtenerIdUsuarioPorNick(username.Text);
            fechaMinima = fechaDesde.Value;
            fechaMaxima = fechaHasta.Value;
            montoMinimo = montoDesde.Text=="" ? 0 : Convert.ToDouble(montoDesde.Text);
            montoMaximo = montoHasta.Text=="" ? 0 : Convert.ToDouble(montoHasta.Text);
        }

        private void FacturasRealizadas_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            montoDesde.Text = "0";
            montoHasta.Text = "0";
            username.Text = "";
            initDataGrid();
        }

        private void initDataGrid()
        {
            DataGridViewTextBoxColumn cFormaPago = new DataGridViewTextBoxColumn();
            cFormaPago.HeaderText = "Forma de Pago";
            cFormaPago.ReadOnly = true;
            tablaFacturas.Columns.Add(cFormaPago);
            DataGridViewTextBoxColumn cTipoVisibilidad = new DataGridViewTextBoxColumn();
            cTipoVisibilidad.HeaderText = "Tipo de Visibilidad";
            cTipoVisibilidad.ReadOnly = true;
            tablaFacturas.Columns.Add(cTipoVisibilidad);
            DataGridViewTextBoxColumn cFecha = new DataGridViewTextBoxColumn();
            cFecha.HeaderText = "Fecha";
            cFecha.ReadOnly = true;
            tablaFacturas.Columns.Add(cFecha);
            DataGridViewTextBoxColumn cImporte = new DataGridViewTextBoxColumn();
            cImporte.HeaderText = "Importe";
            cImporte.ReadOnly = true;
            tablaFacturas.Columns.Add(cImporte);
        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {
            numeroPagina = cantidadMaxDePags;

            buscarButton_Click(new object(), new EventArgs());
        }

        private void btnPrimerPag_Click(object sender, EventArgs e)
        {
            numeroPagina = 1;

            buscarButton_Click(new object(), new EventArgs());
        }

        private void btnAnteriorPag_Click(object sender, EventArgs e)
        {
            numeroPagina--;

            if (numeroPagina<1)
            {
                numeroPagina = 1;
            }

            buscarButton_Click(new object(), new EventArgs());
        }

        private void btnSiguientePag_Click(object sender, EventArgs e)
        {
            numeroPagina++;

            if (numeroPagina > cantidadMaxDePags)
            {
                numeroPagina = cantidadMaxDePags;
            }

            buscarButton_Click(new object(), new EventArgs());
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            montoDesde.Text = "0";
            montoHasta.Text = "0";
            username.Text = "";
            filtroFechaActivado.Checked = false;
            filtroMontoActivado.Checked = false;
        }

        private void FacturasRealizadas_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
