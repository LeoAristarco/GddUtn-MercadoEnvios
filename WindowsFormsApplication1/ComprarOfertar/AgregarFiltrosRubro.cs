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

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class AgregarFiltrosRubro : Form
    {
        RubroRepository repositorio = new RubroRepository();
        private List<Rubro> rubros;
        private ComprarOfertar formAnterior;
        private Rubro rubroSeleccionado;

        public AgregarFiltrosRubro(ComprarOfertar formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void AgregarFiltrosRubro_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            rubros = repositorio.obtenerRubros();

            foreach (Rubro item in rubros)
            {
                rubroListBox.Items.Add(item.descripcionCorta,false);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            formAnterior.agregarFiltroRubro(rubroSeleccionado);
            formAnterior.Show();
            Close();
        }

        private void rubroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rubroSeleccionado = rubros[rubroListBox.SelectedIndex];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void btnNinguno_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(new object(), new EventArgs());
        }
    }
}
