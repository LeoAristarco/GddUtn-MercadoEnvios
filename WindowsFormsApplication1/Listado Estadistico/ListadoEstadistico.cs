using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        private const string VENDEDORES_MENOS_VENDIDO = "Vendedores con mas productos no vendidos";
        private const string CLIENTES_MAS_COMPRAS = "Clientes con mas compras";
        private const string VENDEDORES_MAS_FACTURAS = "Vendedores con mas facturas";
        private const string VENDEDORES_MAYOR_FACTURA = "Vendedores con mayor facturacion";
        private const string VACIO = "Ninguno";
        private Form formAnterior;
        private Listado listado;
        private List<int> mesesFiltro;

        public ListadoEstadistico(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            tipoListado.Items.Add(VACIO);
            tipoListado.Items.Add(VENDEDORES_MENOS_VENDIDO);
            tipoListado.Items.Add(CLIENTES_MAS_COMPRAS);
            tipoListado.Items.Add(VENDEDORES_MAS_FACTURAS);
            tipoListado.Items.Add(VENDEDORES_MAYOR_FACTURA);

            tipoListado.SelectedItem = "ninguno";

            mes.Items.Add("ninguno");
            mes.Items.Add("enero");
            mes.Items.Add("febrero");
            mes.Items.Add("marzo");
            mes.Items.Add("abril");
            mes.Items.Add("mayo");
            mes.Items.Add("junio");
            mes.Items.Add("julio");
            mes.Items.Add("agosto");
            mes.Items.Add("septiembre");
            mes.Items.Add("octubre");
            mes.Items.Add("noviembre");
            mes.Items.Add("diciembre");

            mes.SelectedItem = "ninguno";

            anio.Text = "";

            for (int i = 0; i < 5; i++)
            {
                trimestre.Items.Add(i);
            }

            trimestre.SelectedIndex = 0;
            tipoListado.SelectedIndex = 0;

            filtro.Items.Clear();

            limpiarDataGrid();
        }

        private void limpiarDataGrid()
        {
            tablaEstadistica.Rows.Clear();
            tablaEstadistica.Columns.Clear();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void anio_TextChanged(object sender, EventArgs e)
        {
            if (anio.Text.Length>4)
            {
                anio.Text = anio.Text.Remove(anio.Text.Length - 1);
            }

            trimestre.Enabled = anio.Text.Length == 4;
        }

        private void trimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoListado.Enabled = (int)trimestre.SelectedItem != 0;
            mes.Enabled= (int)trimestre.SelectedItem != 0;
            buscarButton.Enabled = (int)trimestre.SelectedItem != 0;
        }

        private void limpiarBoton_Click(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void tipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarDataGrid();
            filtro.Items.Add("");
            filtro.SelectedItem = "";
            filtro.Items.Clear();//Esto es para que se borre el combo box cuando cambio a un listado sin filtro

            switch (tipoListado.SelectedItem.ToString())
            {
                case VENDEDORES_MENOS_VENDIDO:
                    listado = new VendedoresMenosVendido();
                    break;
                case VENDEDORES_MAS_FACTURAS:
                    listado = new VendedoresMasFacturas();
                    break;
                case VENDEDORES_MAYOR_FACTURA:
                    listado = new VendedoresMayorFactura();
                    break;
                case CLIENTES_MAS_COMPRAS:
                    listado = new ClientesMasCompras();
                    break;
            }

            if (tipoListado.SelectedItem.ToString()!=VACIO)
            {
                listado.initDataGrid(ref tablaEstadistica);
                filtroEspecial.Text = listado.initFiltros(ref filtro);

                filtro.Enabled = filtroEspecial.Text != "";
            }

            buscarButton.Enabled = tipoListado.SelectedItem.ToString() != VACIO;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Regex regAnio = new Regex("[0-9]");
            bool anioSonNumeros = regAnio.IsMatch(anio.Text);
            if (anio.Text.Length!=4||!anioSonNumeros)
            {
                MessageBox.Show("Año ingresado no valido");
                return;
            }
            if (Convert.ToInt16(trimestre.SelectedItem)==0)
            {
                MessageBox.Show("Debe seleccionar un trimestre");
                return;
            }

            tablaEstadistica.Rows.Clear();

            int trimestreSeleccionado = Convert.ToInt16(trimestre.SelectedItem);

            if ((trimestreSeleccionado*3<mes.SelectedIndex||mes.SelectedIndex<(trimestreSeleccionado*3-2))&& mes.SelectedIndex>0)
            {
                MessageBox.Show("Mes seleccionado no corresponde a trimestre");
                return;
            }

            updateFiltroMeses();

            if (listado==null)
            {
                MessageBox.Show("Debe seleccionar un listado");
                return;
            }

            listado.llenarDataGrid(ref tablaEstadistica, mesesFiltro, Convert.ToInt16(anio.Text));
        }

        private void updateFiltroMeses()
        {
            mesesFiltro = new List<int> { mes.SelectedIndex, 0, 0};

            if (mes.SelectedIndex!=0)
            {
                return;
            }

            int trimestreSeleccionado = Convert.ToInt16(trimestre.SelectedItem);

            for (int i = 0; i < 3; i++)
            {
                mesesFiltro[i] = 3*trimestreSeleccionado -2 + i;
            }
        }

        private void filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listado == null)
            {
                return;
            }
            listado.seleccionarFiltro(filtro.SelectedIndex);
        }

        private void ListadoEstadistico_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
