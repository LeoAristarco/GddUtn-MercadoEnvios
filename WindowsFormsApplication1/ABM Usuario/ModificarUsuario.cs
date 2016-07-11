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
    public partial class ModificarUsuario : Form
    {
        private Form formAnterior;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public ModificarUsuario(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void RegistrarUsuario_Button_Click(object sender, EventArgs e)
        {
            if (!repositorio.yaExisteEseNick(nick.Text))
            {
                MessageBox.Show("El usuario ingresado no existe");
                return;
            }

            Usuario user = new Usuario();
            user.nick = nick.Text;

            ElegirTipoUsuario elegirUser = new ElegirTipoUsuario(formAnterior, user, true);

            Hide();

            elegirUser.ShowDialog();

            Close();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
