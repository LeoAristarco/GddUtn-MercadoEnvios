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
    public partial class Confirmacion : Form
    {
        private Usuario nuevoUser;
        private RegistrarUsuario registrarUsuario;

        public Confirmacion()
        {
            InitializeComponent();
        }

        public Confirmacion(Usuario nuevoUser, RegistrarUsuario registrarUsuario)
        {
            this.nuevoUser = nuevoUser;
            this.registrarUsuario = registrarUsuario;
        }

        private void Confirmacion_Load(object sender, EventArgs e)
        {
            nick.Text = nuevoUser.nick;
            pass.Text = nuevoUser.pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrarUsuario.Show();
            Close();
        }
    }
}
