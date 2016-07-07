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
    public partial class ElegirTipoUsuario : Form
    {
        private Usuario nuevoUser;
        private RegistrarUsuario registrarUsuario;

        public ElegirTipoUsuario(RegistrarUsuario registrarUsuario, Usuario nuevoUser)
        {
            this.registrarUsuario = registrarUsuario;
            this.nuevoUser = nuevoUser;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
