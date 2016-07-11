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
    public partial class ABMUsuario : Form
    {
        private Form formAnterior;
        //private UsuarioRepository repositorio = new UsuarioRepository();

        public ABMUsuario(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void ABMUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarUsuario crearUser = new RegistrarUsuario(this);
            Hide();
            crearUser.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarUser = new ModificarUsuario(this);
            Hide();
            modificarUser.ShowDialog();
        }
    }
}
