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
    public partial class CrearCliente : Form
    {
        private Usuario nuevoUser;
        private RegistrarUsuario registrarUsuario;

        public CrearCliente()
        {
            InitializeComponent();
        }

        public CrearCliente(Usuario nuevoUser, RegistrarUsuario registrarUsuario)
        {
            this.nuevoUser = nuevoUser;
            this.registrarUsuario = registrarUsuario;
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
