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
using WindowsFormsApplication1.Generar_Publicación;

namespace WindowsFormsApplication1.ABM_Rubro
{
    public partial class ABMRubro : Form
    {
        RubroRepository repositorio;
        private List<Rubro> rubrosActuales;
        private Form formAnterior;

        public ABMRubro(Form formAnterior)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
        }

        private void ABMRubro_Load(object sender, EventArgs e)
        {
            repositorio = new RubroRepository();
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            rubrosActuales = repositorio.obtenerRubros();

            foreach (Rubro item in rubrosActuales)
            {
                rubroActual.Items.Add(item.descripcionCorta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificar formModify = new Modificar(rubrosActuales[rubroActual.SelectedIndex],formAnterior);

            formModify.Show();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            repositorio.deleteRubro(rubrosActuales[rubroActual.SelectedIndex]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Hide();
        }
    }
}
