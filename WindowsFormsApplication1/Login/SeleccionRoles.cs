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

        private LogueoDAO logueoDAO;

        private LoginForm formPadre;

        private SeleccionFuncionalidades formSiguiente;

        public SeleccionRoles(LoginForm formPadre)
        {
            InitializeComponent();

            this.formPadre = formPadre;
            logueo = formPadre.logueo;
            logueoDAO = new LogueoDAO();

            cargarComboBoxConDiccionarioRoles();
        }

        public void cargarComboBoxConDiccionarioRoles()
        {
            logueoDAO.loguear(logueo);

            comboBox_Roles.Items.Clear();
            foreach (KeyValuePair<double, string> rol in logueo.roles)
            {
                comboBox_Roles.Items.Add(rol.Value);
            }
        }

        private void continuar_Boton_Click(object sender, EventArgs e)
        {
            comboBox_Roles.ResetText();

            if (comboBox_Roles.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado ningun Rol", "Error", MessageBoxButtons.OK);
                return;
            }

            string nombreRolSeleccionado = comboBox_Roles.SelectedItem.ToString();
            double idRolSeleccionado = logueo.roles.FirstOrDefault(x => x.Value.Equals(nombreRolSeleccionado)).Key;

            logueoDAO.cargarFuncionalidadesDelRolElegido(idRolSeleccionado ,logueo);

            logueo.idRolSeleccionado = idRolSeleccionado;
            formSiguiente = new SeleccionFuncionalidades(this);
                formSiguiente.Show();

            Hide();
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
