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
    public partial class BuscarCliente : Form
    {
        private Cliente clienteSeleccionado;
        private List<Cliente> clientesEncontrados = new List<Cliente>();
        private Form formAnterior;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public BuscarCliente(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            clientesEncontrados = repositorio.buscarClientes(filtroNombre.Text, filtroApellido.Text, filtroDni.Text, filtroMail.Text);

            cargarTablaClientes();
        }

        private void cargarTablaClientes()
        {
            foreach (Cliente cliente in clientesEncontrados)
            {
                tablaClientes.Rows.Add(cliente.nick, cliente.nombre, cliente.apellido, cliente.dni, cliente.mail);
            }

            modificar.Enabled = clientesEncontrados.Count > 0;
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            ModificarCliente modificar = new ModificarCliente(clienteSeleccionado, this);

            modificar.ShowDialog();

            Hide();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            inicializarTablaClientes();
        }

        private void inicializarTablaClientes()
        {
            DataGridViewTextBoxColumn cNick = new DataGridViewTextBoxColumn();
            cNick.HeaderText = "NickName";
            cNick.ReadOnly = true;
            tablaClientes.Columns.Add(cNick);
            DataGridViewTextBoxColumn cNombre = new DataGridViewTextBoxColumn();
            cNombre.HeaderText = "Nombre";
            cNombre.ReadOnly = true;
            tablaClientes.Columns.Add(cNombre);
            DataGridViewTextBoxColumn cApellido = new DataGridViewTextBoxColumn();
            cApellido.HeaderText = "Apellido";
            cApellido.ReadOnly = true;
            tablaClientes.Columns.Add(cApellido);
            DataGridViewTextBoxColumn cDocumento = new DataGridViewTextBoxColumn();
            cDocumento.HeaderText = "Documento";
            cDocumento.ReadOnly = true;
            tablaClientes.Columns.Add(cDocumento);
            DataGridViewTextBoxColumn cMail = new DataGridViewTextBoxColumn();
            cMail.HeaderText = "Mail";
            cMail.ReadOnly = true;
            tablaClientes.Columns.Add(cMail);
        }

        private void tablaClientes_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = clientesEncontrados[tablaClientes.CurrentCell.RowIndex];
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }
    }
}
