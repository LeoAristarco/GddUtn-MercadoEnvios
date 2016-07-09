using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario.Empresa
{
    public partial class ModificarEmpresa : Form
    {
        private Form formAnterior;
        private Empresa empresaSeleccionada;

        public ModificarEmpresa()
        {
            InitializeComponent();
        }

        public ModificarEmpresa(Empresa empresaSeleccionada, Form formAnterior)
        {
            this.empresaSeleccionada = empresaSeleccionada;
            this.formAnterior = formAnterior;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
