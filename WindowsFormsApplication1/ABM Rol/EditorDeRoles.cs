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
    public partial class EditorDeRoles : Form
    {
        //hago lo mas negro para reutilizar el form, true = modificar, false = nuevo
        private RolRepository repo;
        public bool modificarONuevo;
        private Rol rol;
        private List<Funcionalidad> funcionalidades;
        private List<Funcionalidad> funcionalidadesDelRol;
        private Form formAnterior;

        public EditorDeRoles(Rol rol, bool modificarONuevo,Form formAnterior)
        {
            this.formAnterior = formAnterior;

            InitializeComponent();

            repo = new RolRepository();
            this.modificarONuevo = modificarONuevo;
            this.rol = rol;

            if (modificarONuevo)
            {//modificar
                cargarFuncionalidadesDeRolParaEditar();
            }
            else
            {//nuevo
                cargarFuncionalidadesDeRolNuevo();
            }
        }

        private void cargarFuncionalidadesDeRolNuevo()
        {
            //cargo las funcioanlidades de todo el sistema
            funcionalidades = repo.obtenerTodasLasFuncionalidades();

            Nombre_Textbox.Text = "";
            Habilitado_Checkbox.Checked = true;

            //carga de la lista de checkboc
            Funcionalidades_Checkboxlist.Items.Clear();
            foreach (Funcionalidad fun in funcionalidades)
            {
                Funcionalidades_Checkboxlist.Items.Add(fun.nombre, false);
            }
        }

        private void cargarFuncionalidadesDeRolParaEditar()
        {
            //primero cargo las funcionalidades del rol que voy a modificar
            funcionalidadesDelRol = repo.obtenerLasFuncionalidadesDel(rol);
            //cargo las funcioanlidades de todo el sistema
            funcionalidades = repo.obtenerTodasLasFuncionalidades();

            Nombre_Textbox.Text = rol.nombre;
            Habilitado_Checkbox.Checked = rol.habilitado;

            //carga de la lista de checkboc
            Funcionalidades_Checkboxlist.Items.Clear();
            foreach (Funcionalidad fun in funcionalidades)
            {
                if (funcionalidadesDelRol.Any(x => x.id == fun.id))
                {
                    fun.habilitado = true;
                }
                else
                {
                    fun.habilitado = false;
                }

                Funcionalidades_Checkboxlist.Items.Add(fun.nombre, fun.habilitado);
            }
        }

        private void Guardar_Button_Click(object sender, EventArgs e)
        {
            if (modificarONuevo)
            {//modificar
                try
                {
                    rol.nombre = Nombre_Textbox.Text.ToUpper().Trim();
                    rol.habilitado = Habilitado_Checkbox.Checked;

                    repo.actualizarRolYSusFuncionalidades(rol, funcionalidades);

                    MessageBox.Show("Modificacion Exitosa", "Aviso", MessageBoxButtons.OK);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el alta", "Error", MessageBoxButtons.OK);
                    throw;
                }
            }
            else
            {//nuevo
                try
                {
                    rol.nombre = Nombre_Textbox.Text.ToUpper().Trim();
                    rol.habilitado = Habilitado_Checkbox.Checked;

                    repo.crearNuevoRol(rol, funcionalidades);

                    MessageBox.Show("Alta Exitosa", "Aviso", MessageBoxButtons.OK);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el alta", "Error", MessageBoxButtons.OK);
                    throw;
                }

            }
        }

        private void Funcionalidades_Checkboxlist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int indice = Funcionalidades_Checkboxlist.SelectedIndex;
            if (indice >= 0)
            {
                funcionalidades[indice].habilitado = !funcionalidades[indice].habilitado;
            }
        }

        private void EditorDeRoles_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }

        private void Cancelar_Button_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }
    }
}
