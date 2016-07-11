using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Login
{
    public partial class CambiarPassword : Form
    {
        private Form formAnterior;
        private bool passUserHasheada;
        private UsuarioRepository repositorio;
        private Usuario usuario;

        public CambiarPassword(Form formAnterior,Usuario user,bool passUserHasheada)
        {
            this.passUserHasheada = passUserHasheada;
            this.formAnterior = formAnterior;
            usuario = user;
            repositorio = new UsuarioRepository();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nuevaPass1.Text!=nuevaPass2.Text)
            {
                MessageBox.Show("La nueva contraseña no coincide con su confirmacion");
                return;
            }

            string password = passUserHasheada ? repositorio.valorHasheado(passVieja.Text) : passVieja.Text;

            if (password!=usuario.pass)
            {
                MessageBox.Show("La contraseña actual no coincide con la especificada");
                return;
            }

            repositorio.updatePassword(usuario, nuevaPass1.Text);//Por ahi deberia de hacer mas validaciones

            formAnterior.Show();

            Close();
        }

        private void CambiarPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
