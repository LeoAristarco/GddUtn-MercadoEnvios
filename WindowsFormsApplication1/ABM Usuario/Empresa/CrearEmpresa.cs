using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class CrearEmpresa : Form
    {
        private Usuario nuevoUser;
        private UsuarioRepository repositorio = new UsuarioRepository();
        private Empresa nuevaEmpresa;
        private Form formAnterior;

        public CrearEmpresa(Usuario nuevoUser, Form formAnterior)
        {
            this.nuevoUser = nuevoUser;
            this.formAnterior = formAnterior;
            nuevaEmpresa = new Empresa();
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (!ejecutarValidaciones())
            {
                return;
            }

            cargarDatosAEmpresa();

            string mensaje = repositorio.agregarEmpresa(nuevaEmpresa);

            if (mensaje!="todo piola")
            {
                MessageBox.Show(mensaje.ToUpper());
                return;
            }

            Confirmacion confirmacion = new Confirmacion(nuevoUser, formAnterior);

            confirmacion.ShowDialog();

            Close();
        }

        private void cargarDatosAEmpresa()
        {
            nuevaEmpresa.mail = email.Text;
            nuevaEmpresa.calle = calle.Text;
            nuevaEmpresa.bajaLogica = false;
            nuevaEmpresa.codigoPostal = codigoPostal.Text=="" ? 0 : Convert.ToInt16(codigoPostal.Text);
            nuevaEmpresa.departamento = departamento.Text;
            nuevaEmpresa.localidad = localidad.Text;
            nuevaEmpresa.numeroDeCalle = numeroDeCalle.Text=="" ? 0 : Convert.ToInt16(numeroDeCalle.Text);
            nuevaEmpresa.numeroDePiso = numeroDePiso.Text=="" ? 0 : Convert.ToInt16(numeroDePiso.Text);
            nuevaEmpresa.telefono = telefono.Text;
            nuevaEmpresa.fechaDeNacimiento = fechaNacimiento.Value;
            nuevaEmpresa.razonSocial = razonSocial.Text;
            nuevaEmpresa.cuit = cuit.Text;
            nuevaEmpresa.nombreDeContacto = nombreDeContacto.Text;
            nuevaEmpresa.ciudad = ciudad.Text;
            nuevaEmpresa.rubro = rubro.Text;

        }

        private bool ejecutarValidaciones()
        {
            if (razonSocial.Text=="")
            {
                MessageBox.Show("Debe completarse el campo razon social");
                return false;
            }
            if (email.Text == "")
            {
                MessageBox.Show("Debe completarse el campo email");
                return false;
            }
            if (calle.Text == "")
            {
                MessageBox.Show("Debe completarse el campo calle");
                return false;
            }
            if (cuit.Text == "")
            {
                MessageBox.Show("Debe completarse el campo cuit");
                return false;
            }
            if (rubro.Text == "")
            {
                MessageBox.Show("Debe completarse el campo rubro");
                return false;
            }

            return true;
        }

        private void CrearEmpresa_Load(object sender, EventArgs e)
        {
            cargarEmpresaVacia();
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            //Por ahora nada
        }

        private void cargarEmpresaVacia()
        {
            nuevaEmpresa.mail = "";
            nuevaEmpresa.nick = nuevoUser.nick;
            nuevaEmpresa.pass = nuevoUser.pass;
            nuevaEmpresa.calle = "";
            nuevaEmpresa.codigoPostal = 0;
            nuevaEmpresa.departamento = "";
            nuevaEmpresa.localidad = "";
            nuevaEmpresa.numeroDeCalle = 0;
            nuevaEmpresa.numeroDePiso = 0;
            nuevaEmpresa.telefono = "";
            nuevaEmpresa.razonSocial = "";
            nuevaEmpresa.cuit = "";
            nuevaEmpresa.nombreDeContacto = "";
            nuevaEmpresa.ciudad = "";
            nuevaEmpresa.rubro = "";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            CrearEmpresa_Load(new object(), new EventArgs());
        }
    }
}
