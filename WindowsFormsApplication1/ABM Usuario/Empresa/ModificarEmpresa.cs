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

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class ModificarEmpresa : Form
    {
        private Form formAnterior;
        private Empresa empresa;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public ModificarEmpresa(Empresa empresa, Form formAnterior)
        {
            this.empresa = empresa;
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!ejecutarValidaciones())
            {
                return;
            }

            cargarDatosEmpresa();

            repositorio.modificarEmpresa(empresa);

            formAnterior.Show();
            Close();
        }

        private void cargarDatosEmpresa()
        {
            empresa.mail = email.Text;
            empresa.bajaLogica = !habilitado.Checked;
            empresa.codigoPostal = codigoPostal.Text == "" ? 0 : Convert.ToInt16(codigoPostal.Text);
            empresa.departamento = departamento.Text;
            empresa.localidad = localidad.Text;
            empresa.numeroDeCalle = numeroDeCalle.Text == "" ? 0 : Convert.ToInt16(numeroDeCalle.Text);
            empresa.numeroDePiso = numeroDePiso.Text == "" ? 0 : Convert.ToInt16(numeroDePiso.Text);
            empresa.telefono = telefono.Text;
            empresa.nombreDeContacto = nombreDeContacto.Text;
            empresa.ciudad = ciudad.Text;
            empresa.rubro = rubro.Text;
        }

        private bool ejecutarValidaciones()
        {
            //por ahora nada
            return true;
        }

        private void ModificarEmpresa_Load(object sender, EventArgs e)
        {
            cargarFormConDatosDeEmpresa();
        }

        private void cargarFormConDatosDeEmpresa()
        {
            //nick.Text = empresa.nick;
            //pass.Text = empresa.pass;
            habilitado.Checked = !empresa.bajaLogica;
            email.Text = empresa.mail;
            calle.Text = empresa.calle;
            habilitado.Checked =  !empresa.bajaLogica;
            codigoPostal.Text = empresa.codigoPostal.ToString();
            departamento.Text = empresa.departamento;
            localidad.Text = empresa.localidad;
            numeroDeCalle.Text = empresa.numeroDeCalle.ToString();
            numeroDePiso.Text = empresa.numeroDePiso.ToString();
            telefono.Text = empresa.telefono;
            nombreDeContacto.Text = empresa.nombreDeContacto;
            ciudad.Text = empresa.ciudad;
            rubro.Text = empresa.rubro;
        }
    }
}
