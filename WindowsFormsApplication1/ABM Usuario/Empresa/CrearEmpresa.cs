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

namespace WindowsFormsApplication1.ABM_Usuario.Empresa
{
    public partial class CrearEmpresa : Form
    {
        private Usuario nuevoUser;
        private RegistrarUsuario registrarUsuario;

        public CrearEmpresa()
        {
            InitializeComponent();
        }

        public CrearEmpresa(Usuario nuevoUser, RegistrarUsuario registrarUsuario)
        {
            this.nuevoUser = nuevoUser;
            this.registrarUsuario = registrarUsuario;
        }
    }
}
