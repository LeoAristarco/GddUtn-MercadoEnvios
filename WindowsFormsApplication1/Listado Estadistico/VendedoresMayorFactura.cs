using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    class VendedoresMayorFactura : Listado
    {
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
            DataGridViewTextBoxColumn cMayorFactura = new DataGridViewTextBoxColumn();
            cMayorFactura.HeaderText = "Monto facturado";
            cMayorFactura.ReadOnly = true;
            tablaEstadistica.Columns.Add(cMayorFactura);
        }

        public override string initFiltros(ref ComboBox filtro)
        {
            return "";
        }

        public override void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio)
        {
            Dictionary<Usuario, long> usuariosConMayorFactura = repositorio.obtenerTop5ConMayorFactura(meses, anio);

            foreach (KeyValuePair<Usuario, long> item in usuariosConMayorFactura)
            {
                grilla.Rows.Add(item.Key.nick, item.Key.mail, item.Value);
            }
        }
    }
}
