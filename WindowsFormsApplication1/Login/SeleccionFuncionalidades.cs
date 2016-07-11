using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Rol;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.ABM_Visibilidad;
using WindowsFormsApplication1.Calificar;
using WindowsFormsApplication1.Clases;
using WindowsFormsApplication1.ComprarOfertar;
using WindowsFormsApplication1.Facturas;
using WindowsFormsApplication1.Generar_Publicación;
using WindowsFormsApplication1.Historial_Cliente;
using WindowsFormsApplication1.Listado_Estadistico;
using WindowsFormsApplication1.Login.ClasesLogin;

namespace WindowsFormsApplication1.Login
{
    public partial class SeleccionFuncionalidades : Form
    {
        public Logueo logueo { get; set; }
        public Usuario usuario { get; set; } 
        private SeleccionRoles formPadre;
        private LogueoDAO dataBase;

        public SeleccionFuncionalidades(SeleccionRoles formPadre)
        {
            InitializeComponent();

            this.formPadre = formPadre;
            logueo = formPadre.logueo;
            dataBase = new LogueoDAO();

            cargarComboBoxConFuncionalidades();

            //transformo objeto logueo a usuario
            
            usuario = new Usuario();
                usuario.id = Convert.ToInt32(logueo.idUsuario);
                usuario.nick = logueo.nick;
                usuario.pass = logueo.pass;

        }

        public void cargarComboBoxConFuncionalidades()
        {
            cbFuncionalidades.Items.Clear();
            cbFuncionalidades.ResetText();

            if (!logueo.funcionalidadesPorRol.ContainsKey(logueo.idRolSeleccionado)) return;
            
            List<string> items = new List<string>();
            items.AddRange(logueo.funcionalidadesPorRol.SingleOrDefault(x => x.Key.Equals(logueo.idRolSeleccionado)).Value.Values);

            foreach (string func in items)
            {
                cbFuncionalidades.Items.Add(func);
            }

        }

        private void continuar_Click(object sender, EventArgs e)
        {
            cbFuncionalidades.ResetText();

            if (cbFuncionalidades.SelectedItem == null)
            {
                MessageBox.Show("No ha seleccionado ninguna Funcionalidad", "Error", MessageBoxButtons.OK);
                return;
            }

            string funcionalidadSeleccionada = cbFuncionalidades.SelectedItem.ToString();
            
            redirigirAFuncionalidadElegida(funcionalidadSeleccionada);
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Hide();
            formPadre.Show();
            formPadre.cargarComboBoxConDiccionarioRoles();
        }

        private void SeleccionFuncionalidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Close();
        }

        private void redirigirAFuncionalidadElegida(string funcionalidadElegida)
        {
            /*ACA ESTA EL SWITHC PARA REDIRIGIR A LAS OTRAS VENTANAS, ES IMPORTANTE QUE EL OTRO FORM, HIJO DE ESTE
             * CONOSCA EL PADRE PARA QUE EL USUARIO PUEDA VOLVER HACIA ATRAS*/

            /*ES IMPORTANTE QUE ESTE ACTUALIZADO Y TENGA LAS OPCIONES IGUALES A LAS QUE ESTAN EN LA BD*/
            Form proximoForm = new Form();

            switch (funcionalidadElegida)
            {
                case "ABM_ROL":
                    proximoForm  = new ABMRol(this, usuario);
                    break;

                case "ABM_USUARIO":
                    proximoForm = new ABMUsuario(this);
                    break;

                case "ABM_VISIBILIDAD":
                    proximoForm = new ABMVisibilidad(this);
                    break;

                case "GENERAR_PUBLICACION":
                    proximoForm = new GenerarPublicacion(usuario, this);
                    break;

                case "COMPRAR/OFERTAR":
                    proximoForm = new Comprar_Ofertar(usuario, this);
                    break;

                case "HISTORIAL_CLIENTE":
                    proximoForm = new HistorialCliente(usuario, this);
                    break;

                case "CALIFICAR_VENDEDOR":
                    proximoForm = new CalificarVendedor(usuario, this);
                    break;

                case "FACTURAS_REALIZADAS":
                    proximoForm = new FacturasRealizadas(this);
                    break;

                case "ESTADISTICAS":
                    proximoForm = new ListadoEstadistico(this);
                    break;

                case "CAMBIAR_PASSWORD"://Hay que ver que nombre se le pone
                    proximoForm = new SeleccionarUsuarioCambiarPassword(usuario,this);
                    break;

                case "ABM_RUBRO":
                    MessageBox.Show("Esta funcionalidad esta deshabilitada");
                    return;
            }

            Hide();

            proximoForm.ShowDialog();
        }

        private void SeleccionFuncionalidades_Load(object sender, EventArgs e)
        {

        }
    }
}
