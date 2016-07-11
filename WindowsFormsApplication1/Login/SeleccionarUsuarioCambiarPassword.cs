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

namespace WindowsFormsApplication1.Login
{
    public partial class SeleccionarUsuarioCambiarPassword : Form
    {
        private Form formAnterior;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public SeleccionarUsuarioCambiarPassword(Form formAnterior)
        {
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

            CambiarPassword cambiarPass = new CambiarPassword(formAnterior, user);
            Hide();
            cambiarPass.ShowDialog();
            Close();
        }
    }
}
