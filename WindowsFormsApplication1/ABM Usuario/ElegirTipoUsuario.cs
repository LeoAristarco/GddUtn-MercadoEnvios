using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class ElegirTipoUsuario : Form
    {
        private string tipoDeUserSeleccionado = "";//Lo inicializo en ninguno
        private Usuario usuario;
        private bool update;
        private Form formAnterior;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public ElegirTipoUsuario(Form formAnterior, Usuario usuario,bool update)
        {
            this.update = update;
            this.formAnterior = formAnterior;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void inicializarListBox()
        {
            tiposDeUsuario.Items.Add("CLIENTE");
            tiposDeUsuario.Items.Add("EMPRESA");
        }

        private void continuar_Boton_Click(object sender, EventArgs e)
        {
            switch (tipoDeUserSeleccionado)
            {
                case "CLIENTE": ejecutarAbmCliente();
                    break;

                case "EMPRESA": ejecutarAbmEmpresa();
                    break;

                case "":
                    MessageBox.Show("Error, debe seleccionar un tipo de usuario a registrar");
                    return;
            }
        }

        private void ejecutarAbmEmpresa()
        {
            Form formACargar = new Form();

            if (update)
            {
                Empresa empresa = repositorio.traerEmpresaPorNick(usuario.nick);

                if (empresa==null)
                {
                    MessageBox.Show("Error, el usuario ingresado no es del tipo Empresa");
                    return;
                }

                formACargar = new ModificarEmpresa(empresa, formAnterior);
            }
            else
            {
                formACargar = new CrearEmpresa(usuario, formAnterior);
            }

            Hide();
            formACargar.ShowDialog();
            Close();
        }

        private void ejecutarAbmCliente()
        {
            Form formACargar = new Form();

            if (update)
            {
                Cliente cliente = repositorio.traerClientePorNick(usuario.nick);

                if (cliente == null)
                {
                    MessageBox.Show("Error, el usuario ingresado no es del tipo Cliente");
                    return;
                }

                formACargar = new ModificarCliente(cliente, formAnterior);
            }
            else
            {
                formACargar = new CrearCliente(usuario, formAnterior);
            }

            Hide();
            formACargar.ShowDialog();
            Close();
        }

        private void ElegirTipoUsuario_Load(object sender, EventArgs e)
        {
            inicializarListBox();
        }

        private void tiposDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDeUserSeleccionado = tiposDeUsuario.SelectedItem.ToString();
        }
    }
}
