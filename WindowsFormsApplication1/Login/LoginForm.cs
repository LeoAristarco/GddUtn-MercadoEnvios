using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Login.ClasesLogin;

namespace WindowsFormsApplication1.Login
{
    public partial class LoginForm : Form
    {
        private Logueo logueo;

        private LogueoDAO logueoDAO;

        public LoginForm()
        {
            InitializeComponent();

            logueo = new Logueo();
            logueoDAO = new LogueoDAO();             
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            logueo.cargarNickYPass(nick_TextBox.Text, pass_TextBox.Text);

            if (!logueo.nickYPassSonValidos()) return;

            logueoDAO.loguear(logueo);
            
            if(logueo.logueoExitoso())
            {
                MessageBox.Show("Bienvenido " + logueo.nick + "..!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se encontro el Usuario", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
