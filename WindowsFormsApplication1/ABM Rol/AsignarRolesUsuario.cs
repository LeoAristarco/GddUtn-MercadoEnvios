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
        private Usuario usuario;

        public AsignarRolesUsuario(ABMRol formAnterior)
        {
            InitializeComponent();

            this.formAnterior = formAnterior;
            repositorio = new RolRepository();
            usuariosDG = new List<Usuario>(){ };
            usuario = new Usuario();

            inicializarDataGrid();
            cargarDataGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            usuariosDataGrid.CellClick += UsuariosDataGrid_CellClick;
            
            RolesUsuarioDlg rolesUsuarioDlg = new RolesUsuarioDlg(usuario,this);
            rolesUsuarioDlg.ShowDialog();
        }

        private void UsuariosDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hay que validar que no clickee el la ultima fila que rome todo
            //intento validarlo pero no funciona
            if (usuariosDataGrid.CurrentRow.Index < usuariosDataGrid.RowCount)
            {
                usuario.nick = usuariosDataGrid.CurrentRow.Cells[0].Value.ToString();
                usuario.id = Convert.ToInt64(usuariosDataGrid.CurrentRow.Cells[1].Value);
            }
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
            Hide();

            formAnterior.Show();
        }

        private void usuariosDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AsignarRolesUsuario_Load(object sender, EventArgs e)
        {

        }

        private void AsignarRolesUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
