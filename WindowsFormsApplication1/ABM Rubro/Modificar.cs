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
    public partial class Modificar : Form
    {
        private Form formAnterior;
        private Rubro rubroAModificar;

        public Modificar(Rubro rubro,Form formAnterior)
        {
            InitializeComponent();
            rubroAModificar = rubro;
            this.formAnterior = formAnterior;
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            nombreRubro.Text = rubroAModificar.descripcionCorta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rubroAModificar.descripcionCorta = nombreRubro.Text;

            RubroRepository repo = new RubroRepository();

            repo.updateRubro(rubroAModificar);
        }
    }
}
