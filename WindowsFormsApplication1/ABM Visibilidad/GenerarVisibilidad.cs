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

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class GenerarVisibilidad : Form
    {
        private Form formAnterior;
        private Visibilidad visibilidad;
        private bool update;
        private VisibilidadRepository repositorio = new VisibilidadRepository();
        
        public GenerarVisibilidad(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            visibilidad = new Visibilidad(0, "", 0, 0);
            update = false;
            inicializarFormulario();
        }

        public GenerarVisibilidad(Visibilidad visibilidadSeleccionada, Form formAnterior)
        {
            this.visibilidad = visibilidadSeleccionada;
            this.formAnterior = formAnterior;
            update = true;
            inicializarFormulario();
        }

        private void GenerarVisibilidad_Load(object sender, EventArgs e)
        {
        }

        private void inicializarFormulario()
        {
            InitializeComponent();

            nombre.Text = visibilidad.nombre;
            costo.Text = visibilidad.precio.ToString();
            porcentaje.Text = (100*visibilidad.porcentajeVenta).ToString();
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            setVisibilidad();

            if (update)
            {
                repositorio.updateVisibilidad(visibilidad);
            }
            else
            {
                repositorio.agregarVisibilidad(visibilidad);
            }
        }

        private void setVisibilidad()
        {
            visibilidad.nombre = nombre.Text;
            visibilidad.porcentajeVenta = Convert.ToDouble(porcentaje.Text) / 100;
            visibilidad.precio = Convert.ToDouble(costo.Text);
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Hide();
            formAnterior.Show();
        }

        private void GenerarVisibilidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
