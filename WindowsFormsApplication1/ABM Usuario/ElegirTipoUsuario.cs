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
using WindowsFormsApplication1.ABM_Usuario.Empresa;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class ElegirTipoUsuario : Form
    {
        private Usuario nuevoUser;
        private RegistrarUsuario registrarUsuario;
        private string tipoDeUserSeleccionado = "";//Lo inicializo en ninguno

        public ElegirTipoUsuario(RegistrarUsuario registrarUsuario, Usuario nuevoUser)
        {
            this.registrarUsuario = registrarUsuario;
            this.nuevoUser = nuevoUser;
            InitializeComponent();
        }

        private void inicializarListBox()
        {
            tiposDeUsuario.Items.Add("Cliente");
            tiposDeUsuario.Items.Add("Empresa");
        }

        private void continuar_Boton_Click(object sender, EventArgs e)
        {
            Form crearUsuarioCompleto = new Form();

            switch (tipoDeUserSeleccionado)
            {
                case "Cliente": crearUsuarioCompleto = new CrearCliente(nuevoUser, registrarUsuario);
                    break;

                case "Empresa":
                    crearUsuarioCompleto = new CrearEmpresa(nuevoUser, registrarUsuario);
                    break;

                case "":
                    MessageBox.Show("Error, debe seleccionar un tipo de usuario a registrar");
                    return;
            }

            crearUsuarioCompleto.ShowDialog();
            Close();
        }

        private void ElegirTipoUsuario_Load(object sender, EventArgs e)
        {
            inicializarListBox();
        }

        private void tiposDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDeUserSeleccionado = tiposDeUsuario.SelectedItem.ToString();
        }
    }
}
