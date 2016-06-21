using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Login.ClasesLogin
{
    public class Logueo
    {
        public string pass { get; set; }

        public string nick { get; set; }

        public double idUsuario { get; set; }

        public Dictionary<double, string> roles { get; set; }

        public bool bajaLogica { get; set; }

        public double idRolSeleccionado { get; set; }

        public Dictionary<double, Dictionary<double, string>> funcionalidadesPorRol { get; set; } //<id_rol , <id_func, desc_func> >

        public string mensageError { get; set; }

        public Logueo()
        {
            iniciarVariables();
        }

        private void iniciarVariables()
        {
            bajaLogica = false;
            idUsuario = -1;
            roles = new Dictionary<double, string>();

            idRolSeleccionado = -1;
            funcionalidadesPorRol = new Dictionary<double, Dictionary<double, string>>();
        }


        public void cargarNickYPass(string nick, string pass)
        {
            this.nick = nick;
            this.pass = pass;
        }

        public bool nickYPassSonValidos()
        {
            if (nick == "" || pass == "")
            {
                mensageError = "Los campos no pueden estar vacios";
                return false;
            }

            return true;
        }

        public bool logueoExitoso()
        {
            if (idUsuario == -1)
            {
                iniciarVariables();
                mensageError = "El Nick o el Pass son incorrectos";
                return false;
            }

            if (bajaLogica)
            {
                iniciarVariables();
                mensageError = "Ha sido bloqueado, comuniquese con el Administrador";
                return false;
            }

            return true;
        }
    }
}
