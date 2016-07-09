using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class ABMRol : Form
    {
        private RolRepository repositorio = new RolRepository();
        private Form formAnterior;
        private Usuario user;
        private List<Rol> roles;
        private Rol rolSeleccionado;

        public ABMRol(Form formAnterior,Usuario user)
        {
            this.formAnterior = formAnterior;
            this.user = user;
            InitializeComponent();
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {
            roles = repositorio.TodosLosRolesDelSistema();
            
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            inicializarDataGrid();

            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            foreach (Rol rol in roles)
            {
                tablaRoles.Rows.Add(rol.nombre, rol.habilitado);
            }
        }

        private void inicializarDataGrid()
        {
            DataGridViewTextBoxColumn cNombre = new DataGridViewTextBoxColumn();
            cNombre.HeaderText = "Nombre";
            cNombre.ReadOnly = true;
            tablaRoles.Columns.Add(cNombre);
            DataGridViewTextBoxColumn cHabilitado = new DataGridViewTextBoxColumn();
            cHabilitado.HeaderText = "Habilitado";
            cHabilitado.ReadOnly = true;
            tablaRoles.Columns.Add(cHabilitado);
        }

        private void Eliminar_Button_Click(object sender, EventArgs e)
        {
            repositorio.eliminarRolDe(user, rolSeleccionado);
        }

        private void tablaRoles_Click(object sender, EventArgs e)
        {
            rolSeleccionado = roles[tablaRoles.CurrentCell.RowIndex];
        }

        private void ABMRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnterior.Close();
        }

        private void Volver_Button_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Hide();
        }

        private void Nuevo_Button_Click(object sender, EventArgs e)
        {
            Rol rolNuevo = new Rol(Convert.ToInt64(tablaRoles.RowCount), "", true);
            EditorDeRoles editorForm = new EditorDeRoles(rolNuevo, false);

            editorForm.ShowDialog();
        }

        private void btnAsignarRoles_Click(object sender, EventArgs e)
        {
            AsignarRolesUsuario asignarRolesUsuario = new AsignarRolesUsuario(this);
            asignarRolesUsuario.Show();

            Hide();
        }

        private void Modificar_Button_Click(object sender, EventArgs e)
        {
            EditorDeRoles editorForm = new EditorDeRoles(rolSeleccionado, true);

            editorForm.ShowDialog();
        }

        private void tablaRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaRoles.CurrentRow.Index < tablaRoles.RowCount)
            {
                rolSeleccionado.id = roles[e.RowIndex].id;
                rolSeleccionado.nombre = roles[e.RowIndex].nombre;
                rolSeleccionado.habilitado = roles[e.RowIndex].habilitado;
            }
        }
    }
}
