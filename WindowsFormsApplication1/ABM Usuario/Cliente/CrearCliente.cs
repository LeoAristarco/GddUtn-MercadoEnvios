using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class CrearCliente : Form
    {
        private Cliente nuevoCliente;
        private Usuario nuevoUser;
        private UsuarioRepository repositorio = new UsuarioRepository();
        private Form formAnterior;

        public CrearCliente(Usuario nuevoUser, Form formAnterior)
        {
            this.nuevoUser = nuevoUser;
            this.formAnterior = formAnterior;
            nuevoCliente = new Cliente();
            InitializeComponent();
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {
            cargarClienteVacio();
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            tiposDocumento.Items.Add("DNI");
            numeroDeCalle.Text = "0";
            numeroDePiso.Text = "0";
            codigoPostal.Text = "0";
        }

        private void cargarClienteVacio()
        {
            nuevoCliente.nombre = "";
            nuevoCliente.mail = "";
            nuevoCliente.nick = nuevoUser.nick;
            nuevoCliente.pass = nuevoUser.pass;
            nuevoCliente.tipoDeDocumento = "";
            nuevoCliente.apellido = "";
            nuevoCliente.calle = "";
            nuevoCliente.codigoPostal = 0;
            nuevoCliente.departamento = "";
            nuevoCliente.dni = "";
            nuevoCliente.localidad = "";
            nuevoCliente.numeroDeCalle = 0;
            nuevoCliente.numeroDePiso = 0;
            nuevoCliente.telefono = "";
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            CrearCliente_Load(new object(), new EventArgs());
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (!ejecutarValidaciones())
            {
                return;
            }

            cargarDatosACliente();

            repositorio.agregarCliente(nuevoCliente);

            Confirmacion confirmacion = new Confirmacion(nuevoUser, formAnterior);

            Hide();

            confirmacion.ShowDialog();

            Close();
        }

        private bool ejecutarValidaciones()
        {
            if (repositorio.yaExisteEseDni(numeroDocumento.Text))
            {
                MessageBox.Show("Error, DNI ya existente");
                return false;
            }

            return true;
        }

        private void cargarDatosACliente()
        {
            nuevoCliente.nombre = nombre.Text;
            nuevoCliente.mail = email.Text;
            nuevoCliente.tipoDeDocumento = tiposDocumento.SelectedItem.ToString();
            nuevoCliente.apellido = apellido.Text;
            nuevoCliente.calle = calle.Text;
            nuevoCliente.bajaLogica = false;
            nuevoCliente.codigoPostal = codigoPostal.Text=="" ? 0 : Convert.ToInt16(codigoPostal.Text);
            nuevoCliente.departamento = departamento.Text;
            nuevoCliente.dni = numeroDocumento.Text;
            nuevoCliente.localidad = localidad.Text;
            nuevoCliente.numeroDeCalle = numeroDeCalle.Text=="" ? 0 : Convert.ToInt16(numeroDeCalle.Text);
            nuevoCliente.numeroDePiso = numeroDePiso.Text=="" ? 0 : Convert.ToInt16(numeroDePiso.Text);
            nuevoCliente.telefono = telefono.Text;
            nuevoCliente.fechaDeNacimiento = fechaNacimiento.Value;
        }

        private void back_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }
    }
}
