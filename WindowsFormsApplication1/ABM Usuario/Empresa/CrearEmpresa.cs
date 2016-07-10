using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Usuario.Cliente;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario.Empresa
{
    public partial class CrearEmpresa : Form
    {
        private Usuario nuevoUser;
        private RegistrarUsuario registrarUsuario;
        private UsuarioRepository repositorio = new UsuarioRepository();
        private Empresa nuevaEmpresa;

        public CrearEmpresa(Usuario nuevoUser, RegistrarUsuario registrarUsuario)
        {
            this.nuevoUser = nuevoUser;
            this.registrarUsuario = registrarUsuario;
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

            repositorio.agregarEmpresa(nuevaEmpresa);

            Confirmacion confirmacion = new Confirmacion(nuevoUser, registrarUsuario);

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
            if (repositorio.yaExisteRazonSocial(razonSocial.Text))
            {
                MessageBox.Show("Error, razon social ya existente");
                return false;
            }

            if (repositorio.yaExisteCuit(cuit.Text))
            {
                MessageBox.Show("Error, cuit ya existente");
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
