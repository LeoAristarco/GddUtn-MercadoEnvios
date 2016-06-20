using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    class ClientesMasCompras : Listado
    {
        public override void initDataGrid(ref DataGridView tablaEstadistica)
        {
            DataGridViewTextBoxColumn cCliente = new DataGridViewTextBoxColumn();
            cCliente.HeaderText = "Cliente";
            cCliente.ReadOnly = true;
            tablaEstadistica.Columns.Add(cCliente);
            DataGridViewTextBoxColumn cMail = new DataGridViewTextBoxColumn();
            cMail.HeaderText = "Mail";
            cMail.ReadOnly = true;
            tablaEstadistica.Columns.Add(cMail);
            DataGridViewTextBoxColumn cCantidadCompras = new DataGridViewTextBoxColumn();
            cCantidadCompras.HeaderText = "Cantidad de Compras";
            cCantidadCompras.ReadOnly = true;
            tablaEstadistica.Columns.Add(cCantidadCompras);
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
