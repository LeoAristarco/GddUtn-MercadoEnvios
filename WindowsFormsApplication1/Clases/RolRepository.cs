using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication1.Clases;


namespace WindowsFormsApplication1.ABM_Rol
{
    internal class RolRepository : Repository
    {
        public List<Rol> obtenerRolesDe(Usuario usuario)
        {
            List<Rol> roles = new List<Rol>();

            string procedimiento = "OBTENER_ROLES_POR_ID_USUARIO";

            SqlParameter pIdSUsuario = new SqlParameter("@id_usuario", usuario.id);
            List<SqlParameter> parametros = new List<SqlParameter> { pIdSUsuario };

            List<Dictionary<string, object>> listaBD = db.ejecutarStoredProcedure(procedimiento, parametros);

            foreach (Dictionary<string, object> dic in listaBD)
            {
                Rol rol = new Rol(Convert.ToInt64(dic["id_rol"]), (string)dic["rol_nombre"], (bool)dic["habilitado"]);
                roles.Add(rol);
            }

            return roles;
        }

        public List<Rol> TodosLosRolesDelSistema()
        {
            List<Rol> roles = new List<Rol>();

            string sql = "select * from ROL";

            List<Dictionary<string, object>> listaBD = db.ejecutarConsulta(sql);

            foreach (Dictionary<string, object> dic in listaBD)
            {
                Rol rol = new Rol(Convert.ToInt64(dic["id_rol"]), (string)dic["rol_nombre"], (bool)dic["habilitado"]);
                roles.Add(rol);
            }

            return roles;
        }


        public void eliminarRolDe(Usuario user, Rol rolSeleccionado)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> cargarUsuariosDelSistema()
        {
            List<Usuario> usuarios = new List<Usuario>() { };

            string procedimiento = "OBTENER_USUARIOS_PARA_ABM_ROL";
            List<SqlParameter> parametros = new List<SqlParameter> { };

            List<Dictionary<string, object>> listaBD = db.ejecutarStoredProcedure(procedimiento, parametros);

            foreach (Dictionary<string, object> dic in listaBD)
            {
                Usuario user = new Usuario();
                user.id = Convert.ToInt64(dic["id_usuario"]);
                user.nick = (string)dic["nick"];

                usuarios.Add(user);
            }

            return usuarios;
        }
        
        public void actualizarRolPorUsuario(Usuario user, List<Rol> rolesActualizados)
        {
            foreach (Rol rol in rolesActualizados)
            {
                string procedimiento = "ACTUALIZAR_ROL_POR_USUARIO";

                SqlParameter pIdSUsuario = new SqlParameter("@id_usuario", user.id);
                SqlParameter pIdRol = new SqlParameter("@id_rol", rol.id);
                SqlParameter pLoTieneElUSuario = new SqlParameter("@lo_tiene_el_usuario", rol.habilitado);

                List<SqlParameter> parametros = new List<SqlParameter> { pIdSUsuario , pIdRol, pLoTieneElUSuario};

                db.ejecutarStoredProcedure(procedimiento, parametros);
            }
        }
    }
}




