using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    class VendedoresMenosVendido : Listado
    {
        private UsuarioRepository repositorio = new UsuarioRepository();
        private List<Visibilidad> visibilidades = new List<Visibilidad>();

        public VendedoresMenosVendido()
        {
            VisibilidadRepository repoVisibilidad = new VisibilidadRepository();
            visibilidades = repoVisibilidad.obtenerVisibilidades();
        }

        public override void initDataGrid(ref DataGridView tablaEstadistica)
        {
            DataGridViewTextBoxColumn cVendedor = new DataGridViewTextBoxColumn();
            cVendedor.HeaderText = "Vendedor";
            cVendedor.ReadOnly = true;
            tablaEstadistica.Columns.Add(cVendedor);
            DataGridViewTextBoxColumn cMail = new DataGridViewTextBoxColumn();
            cMail.HeaderText = "Mail";
            cMail.ReadOnly = true;
            tablaEstadistica.Columns.Add(cMail);
            DataGridViewTextBoxColumn cMenorCantidadVendido = new DataGridViewTextBoxColumn();
            cMenorCantidadVendido.HeaderText = "Cantidad de productos no vendidos";
            cMenorCantidadVendido.ReadOnly = true;
            tablaEstadistica.Columns.Add(cMenorCantidadVendido);
        }

        public override void llenarDataGrid(ref DataGridView grilla, List<int> meses,int anio)
        {

            Visibilidad filtroSeleccionado = indexFiltro == 0 ? null : visibilidades[indexFiltro];

            Dictionary<Usuario,int> usuariosConVentasFallidas = repositorio.obtenerTop5ConMenosVentas(meses,anio,filtroSeleccionado);

            foreach (KeyValuePair<Usuario,int> item in usuariosConVentasFallidas)
            {
                grilla.Rows.Add(item.Key.nick, item.Key.mail, item.Value);
            }

        }

        public override string initFiltros(ref ComboBox comboBox)
        {
            comboBox.Items.Add("ninguno");

            foreach (Visibilidad item in visibilidades)
            {
                comboBox.Items.Add(item.nombre);
            }

            return "Visibilidades:";
        }
    }
}
