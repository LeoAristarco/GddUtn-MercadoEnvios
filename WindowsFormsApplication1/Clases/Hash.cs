using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Clases
{
    class Hash
    {
        public static string hashear(string texto)
        {
            UsuarioRepository repoUsuario = new UsuarioRepository();

            return repoUsuario.valorHasheado(texto);
        }
    }
}
