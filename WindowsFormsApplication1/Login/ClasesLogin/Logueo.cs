using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Login.ClasesLogin
{
    public class Logueo
    {
        public string pass { get; set; }

        public string nick { get; set; }

        public Dictionary<double, string> roles { get; set; }

        public Logueo()
        {
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
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool logueoExitoso()
        {
            return roles != null;
        }
    }
}
