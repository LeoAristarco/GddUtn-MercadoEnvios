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
    public partial class CalificarDetalle : Form
    {
        private Form formAnterior;
        private Calificacion calificacion;
        private CalificacionRepository repositorio = new CalificacionRepository();

        public CalificarDetalle(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void CalificarDetalle_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            estrellas.Items.Clear();

            for (int i = 1; i < 6; i++)
            {
                estrellas.Items.Add(i);
            }
            textoLibre.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textoLibre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();

            formAnterior.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            setCalificacion();
            repositorio.agregarCalificacion(calificacion);
        }

        private void setCalificacion()
        {
            calificacion = new Calificacion(0, Convert.ToInt16(estrellas.SelectedItem), textoLibre.Text);
        }
    }
}
