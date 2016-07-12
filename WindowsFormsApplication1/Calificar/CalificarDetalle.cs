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

namespace WindowsFormsApplication1.Calificar
{
    public partial class CalificarDetalle : Form
    {
        private Form formAnterior;
        private Calificacion calificacion;
        private CalificacionRepository repositorio = new CalificacionRepository();
        private Usuario usuario;

        public CalificarDetalle(Form formAnterior,Calificacion calificacion,Usuario user)
        {
            usuario = user;
            this.formAnterior = formAnterior;
            this.calificacion = calificacion;
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
            formAnterior.Show();
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            setCalificacion();
            repositorio.updateCalificacion(calificacion);

            HistorialCalificaciones historial = new HistorialCalificaciones(formAnterior, usuario);

            Hide();

            historial.ShowDialog();
        }

        private void setCalificacion()
        {
            calificacion.estrellas = Convert.ToInt16(estrellas.SelectedItem);
            calificacion.comentarios = textoLibre.Text;
        }

        private void CalificarDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
