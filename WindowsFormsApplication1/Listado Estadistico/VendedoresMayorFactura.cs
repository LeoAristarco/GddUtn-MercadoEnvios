using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            throw new NotImplementedException();
        }

        public override void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio)
        {
            throw new NotImplementedException();
        }
    }
}
