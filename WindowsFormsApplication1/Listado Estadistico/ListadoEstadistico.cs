using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        private const string VENDEDORES_MAS_VENDIDO = "Vendedores Con mas productos no vendidos";
        private const string CLIENTES_MAS_COMPRAS = "Clientes con mas compras";
        private const string VENDEDORES_MAS_FACTURAS = "Vendedores con mas facturas";
        private const string VENDEDORES_MAYOR_FACTURA = "Vendedores con mayor facturacion";
        private const string VACIO = "Ninguno";
        private Form formAnterior;

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
            tipoListado.Items.Add(VENDEDORES_MAS_VENDIDO);
            tipoListado.Items.Add(CLIENTES_MAS_COMPRAS);
            tipoListado.Items.Add(VENDEDORES_MAS_FACTURAS);
            tipoListado.Items.Add(VENDEDORES_MAYOR_FACTURA);

            for (int i = 0; i < 5; i++)
            {
                trimestre.Items.Add(i);
            }

            trimestre.SelectedIndex = 0;
            tipoListado.SelectedIndex = 0;

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
        }

        private void limpiarBoton_Click(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void tipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipoListado.SelectedItem.ToString())
            {
                case VENDEDORES_MAS_VENDIDO:
                    iniciarVenderoresMasVendido();
                    break;
                case VENDEDORES_MAS_FACTURAS:
                    iniciarVenderoresMasFacturas();
                    break;
                case VENDEDORES_MAYOR_FACTURA:
                    iniciarVenderoresMayorFactura();
                    break;
                case CLIENTES_MAS_COMPRAS:
                    iniciarClientesMasCompras();
                    break;
            }
        }

        private void iniciarClientesMasCompras()
        {
            throw new NotImplementedException();
        }

        private void iniciarVenderoresMayorFactura()
        {
            throw new NotImplementedException();
        }

        private void iniciarVenderoresMasFacturas()
        {
            throw new NotImplementedException();
        }

        private void iniciarVenderoresMasVendido()
        {
            throw new NotImplementedException();
        }
    }
}
