using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class AsignarRolesUsuario : Form
    {
        private ABMRol formAnterior;
        private RolRepository repositorio;
        private List<Usuario> usuariosDG;

        public AsignarRolesUsuario(ABMRol formAnterior)
        {
            InitializeComponent();

            this.formAnterior = formAnterior;
            repositorio = new RolRepository();
            usuariosDG = new List<Usuario>(){ };

            inicializarDataGrid();
            cargarDataGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void inicializarDataGrid()
        {
            DataGridViewTextBoxColumn cNick = new DataGridViewTextBoxColumn();
            cNick.HeaderText = "Nick";
            cNick.ReadOnly = true;
            usuariosDataGrid.Columns.Add(cNick);
            DataGridViewTextBoxColumn cId = new DataGridViewTextBoxColumn();
            cId.HeaderText = "Id";
            cId.ReadOnly = true;
            usuariosDataGrid.Columns.Add(cId);
        }


        private void cargarDataGrid()
        {
            usuariosDG = repositorio.cargarUsuariosDelSistema();

            foreach (Usuario user in usuariosDG)
            {
                usuariosDataGrid.Rows.Add(user.nick, user.id);
            }
        }

        private void AsignarRolesUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnterior.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();

            Hide();
        }
    }
}
