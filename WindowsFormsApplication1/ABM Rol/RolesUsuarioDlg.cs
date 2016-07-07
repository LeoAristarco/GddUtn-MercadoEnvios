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

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class RolesUsuarioDlg : Form
    {
        private Usuario usuario;

        public RolesUsuarioDlg(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void cargarDatosDeUsuario()
        {
            txtIdUser.Text = usuario.id.ToString();
            txtUsername.Text = usuario.nick;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
