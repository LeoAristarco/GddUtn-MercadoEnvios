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


namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class RolesUsuarioDlg : Form
    {
        private Usuario usuario;
        private RolRepository repo;
        private List<Rol> rolesDelUsuario;
        private List<Rol> rolesDelSistema;

        public RolesUsuarioDlg(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            repo = new RolRepository();

            cargarDatosDeUsuario();
        }

        private void cargarDatosDeUsuario()
        {
            txtIdUser.Text = usuario.id.ToString();
            txtUsername.Text = usuario.nick;

            rolesDelUsuario = repo.obtenerRolesDe(usuario);
            rolesDelSistema = repo.TodosLosRolesDelSistema();

            //carga de la lista de checkboc
            foreach (Rol rol in rolesDelSistema)
            {
                cblRoles.Items.Add(rol.nombre, rolesDelUsuario.Any(x => x.id == rol.id));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void cblRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


