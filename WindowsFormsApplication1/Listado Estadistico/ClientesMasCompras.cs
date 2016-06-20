using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;
using WindowsFormsApplication1.Generar_Publicación;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    class ClientesMasCompras : Listado
    {
        private List<Rubro> rubros;

        public ClientesMasCompras()
        {
            RubroRepository repoRubro = new RubroRepository();
            rubros = repoRubro.obtenerRubros();
        }

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

        public override string initFiltros(ref ComboBox lista)
        {
            lista.Items.Add("ninguno");

            foreach (Rubro item in rubros)
            {
                lista.Items.Add(item.descripcionCorta);
            }

            lista.SelectedItem = "ninguno";

            return "Rubros: ";
        }

        public override void llenarDataGrid(ref DataGridView grilla, List<int> meses, int anio)
        {
            Rubro filtroSeleccionado = indexFiltro == 0 ? null : rubros[indexFiltro];

            Dictionary<Usuario, int> usuariosConMasCompras = repositorio.obtenerTop5ConMasCompras(meses, anio, filtroSeleccionado);

            foreach (KeyValuePair<Usuario, int> item in usuariosConMasCompras)
            {
                grilla.Rows.Add(item.Key.nick, item.Key.mail, item.Value);
            }
        }
    }
}
