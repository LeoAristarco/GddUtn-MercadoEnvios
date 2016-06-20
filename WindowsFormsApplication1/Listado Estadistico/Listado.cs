using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    abstract class Listado
    {
        internal int indexFiltro = 0;

        public abstract void initDataGrid(ref DataGridView grilla);
        public abstract void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio);

        public void seleccionarFiltro(int selectedIndex)
        {
            indexFiltro = selectedIndex;
        }

        public abstract string initFiltros(ref ComboBox filtro);

    }
}
