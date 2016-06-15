using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Calificar
{
    public partial class CalificarVendedor : Form
    {
        private Form formAnterior;

        public CalificarVendedor()
        {
            InitializeComponent();
            //ACA DEBERIA CARGAR LA LISTA DE PUBLICACIONES
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            CalificarDetalle calificar = new CalificarDetalle(this);

            Hide();

            calificar.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
            formAnterior.ShowDialog();
        }
    }
}
