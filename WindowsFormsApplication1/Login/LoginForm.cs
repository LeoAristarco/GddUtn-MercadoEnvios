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
        public Logueo logueo { get; set; }

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

            if (!logueo.nickYPassSonValidos())
            {
                MessageBox.Show(logueo.mensageError, "Error", MessageBoxButtons.OK);
                return;
            }

            logueoDAO.loguear(logueo);
            
            if(logueo.logueoExitoso())
            {
                SeleccionRoles seleccionRoles = new SeleccionRoles(this);
                seleccionRoles.Show();

                Hide();
            }
            else
            {
                MessageBox.Show(logueo.mensageError, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
