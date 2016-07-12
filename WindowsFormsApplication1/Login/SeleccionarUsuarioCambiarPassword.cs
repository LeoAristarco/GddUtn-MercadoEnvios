using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Login
{
    public partial class SeleccionarUsuarioCambiarPassword : Form
    {
        private Form formAnterior;
        private UsuarioRepository repositorio = new UsuarioRepository();
        private Usuario usuario;

        public SeleccionarUsuarioCambiarPassword(Usuario usuario,Form formAnterior)
        {
            this.usuario = usuario;
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void RegistrarUsuario_Button_Click(object sender, EventArgs e)
        {
            if (!repositorio.yaExisteEseNick(nick.Text))
            {
                MessageBox.Show("Error el usuario ingresado no existe");
                return;
            }
            Usuario user = repositorio.obtenerUsuarioPorNick(nick.Text);

            CambiarPassword cambiarPass = new CambiarPassword(formAnterior, user,true);
            Hide();
            cambiarPass.ShowDialog();
            Close();
        }

        private void SeleccionarUsuarioCambiarPassword_Load(object sender, EventArgs e)
        {
            if (Sistema.Instance.rolActualUsuarioLogueado != "ADMINISTRATIVO")
            {
                CambiarPassword cambiarPass = new CambiarPassword(formAnterior, usuario,false);
                Hide();
                cambiarPass.ShowDialog();
                Close();
            }
        }

        private void SeleccionarUsuarioCambiarPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
