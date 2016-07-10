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

namespace WindowsFormsApplication1.ABM_Usuario.Cliente
{
    public partial class ModificarCliente : Form
    {
        private Cliente cliente;
        private Form formAnterior;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public ModificarCliente(Cliente cliente,Form formAnterior)
        {
            this.cliente = cliente;
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            cargarFormConDatosDeCliente();
        }

        private void cargarFormConDatosDeCliente()
        {
            nombre.Text = cliente.nombre;
            email.Text = cliente.mail;
            //nick.Text = cliente.nick;
            //pass.Text = cliente.pass;
            //tiposDocumento.SelectedItem = cliente.tipoDeDocumento;
            apellido.Text = cliente.apellido;
            calle.Text = cliente.calle;
            codigoPostal.Text = cliente.codigoPostal.ToString();
            departamento.Text = cliente.departamento;
            //numeroDocumento.Text = cliente.dni;
            localidad.Text = cliente.localidad;
            numeroDeCalle.Text = cliente.numeroDeCalle.ToString();
            numeroDePiso.Text = cliente.numeroDePiso.ToString();
            telefono.Text = cliente.telefono;
            habilitado.Checked = !cliente.bajaLogica;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!ejecutarValidaciones())
            {
                return;
            }

            cargarDatosACliente();

            repositorio.modificarCliente(cliente);

            formAnterior.Show();
            Close();
        }

        private void cargarDatosACliente()
        {
            cliente.nombre = nombre.Text;
            cliente.mail = email.Text;
            cliente.apellido = apellido.Text;
            cliente.calle = calle.Text;
            cliente.bajaLogica = !habilitado.Checked;
            cliente.codigoPostal = codigoPostal.Text == "" ? 0 : Convert.ToInt16(codigoPostal.Text);
            cliente.departamento = departamento.Text;
            cliente.localidad = localidad.Text;
            cliente.numeroDeCalle = numeroDeCalle.Text == "" ? 0 : Convert.ToInt16(numeroDeCalle.Text);
            cliente.numeroDePiso = numeroDePiso.Text == "" ? 0 : Convert.ToInt16(numeroDePiso.Text);
            cliente.telefono = telefono.Text;
        }

        private bool ejecutarValidaciones()
        {
            //Por ahora nada
            return true;
        }
    }
}
