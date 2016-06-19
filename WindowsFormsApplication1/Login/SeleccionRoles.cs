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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApplication1.Login
{
    public partial class SeleccionRoles : Form
    {
        public Logueo logueo { get; set; }

        private LoginForm formPadre;

        public SeleccionRoles(LoginForm formPadre)
        {
            InitializeComponent();

            this.formPadre = formPadre;
            logueo = formPadre.logueo;

            cargarComboBoxConDiccionarioRoles();
        }

        public void cargarComboBoxConDiccionarioRoles()
        {
            foreach (KeyValuePair<double, string> rol in logueo.roles)
            {
                comboBox_Roles.Items.Add(rol.Value);
            }
        }

        private void continuar_Boton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente funcionalidad", "Estamos trabajando", MessageBoxButtons.OK);
        }

        private void SeleccionRoles_Load(object sender, EventArgs e)
        {

        }

        private void SeleccionRoles_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Close();
        }
    }
}
