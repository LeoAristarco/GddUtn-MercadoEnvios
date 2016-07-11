using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class RegistrarUsuario : Form
    {
        private Form formAnterior;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public RegistrarUsuario(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void RegistrarUsuario_Button_Click(object sender, EventArgs e)
        {
            if (nick.Text==""||pass.Text=="")
            {
                MessageBox.Show("Debe completar los 2 campos");
                return;
            }

            if (repositorio.yaExisteEseNick(nick.Text))
            {
                MessageBox.Show("Error, nombre de usuario ya existente");
                return;
            }

            Usuario nuevoUser = new Usuario();
            nuevoUser.nick = nick.Text;
            nuevoUser.pass = pass.Text;

            ElegirTipoUsuario elegirTipoUser = new ElegirTipoUsuario(this, nuevoUser,false);

            Hide();

            elegirTipoUser.ShowDialog();
        }

        private void RegistrarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
