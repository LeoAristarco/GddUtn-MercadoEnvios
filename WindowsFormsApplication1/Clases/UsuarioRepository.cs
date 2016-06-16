using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Clases
{
    internal class UsuarioRepository:Repository
    {
        internal Usuario traerPorId(long v)
        {
            string consulta = "select * from USUARIO where id_usuario=" + v.ToString();
            return deserializarUsuario(db.ejecutarConsulta(consulta)[0]);
        }

        private Usuario deserializarUsuario(Dictionary<string, object> dictionary)
        {
            Usuario user = new Usuario();
            user.id = toLong(dictionary["id_usuario"]);//POR AHORA MAPEO SOLO ESTO
            return user;
        }
    }
}