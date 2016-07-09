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

        public List<Funcionalidad> obtenerTodasLasFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            string sql = "select * from FUNCIONALIDAD";

            List<Dictionary<string, object>> listaBD = db.ejecutarConsulta(sql);

            foreach (Dictionary<string, object> dic in listaBD)
            {
                Funcionalidad func = new Funcionalidad(Convert.ToInt64(dic["id_funcionalidad"]), (string)dic["funcionalidad_nombre"], (bool)dic["habilitado"]);
                funcionalidades.Add(func);
            }

            return funcionalidades;
        }

        public List<Funcionalidad> obtenerLasFuncionalidadesDel(Rol rol)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            string procedimiento = "OBTENER_FUNCIONALIDADES_DEL_ROL";
            SqlParameter p1 = new SqlParameter("@id_rol", rol.id);
            List<SqlParameter> parametros = new List<SqlParameter> { p1};

            List<Dictionary<string, object>> listaBD = db.ejecutarStoredProcedure(procedimiento, parametros);

            foreach (Dictionary<string, object> dic in listaBD)
            {
                Funcionalidad func = new Funcionalidad(Convert.ToInt64(dic["id_funcionalidad"]), (string)dic["funcionalidad_nombre"], (bool)dic["habilitado"]);
                funcionalidades.Add(func);
            }

            return funcionalidades;
        }

        public void crearNuevoRol(Rol rol, List<Funcionalidad> funcionalidades)
        {
            //inserto nuevo rol
            string procedimiento = "INSERTAR_NUEVO_ROL";

            SqlParameter p1 = new SqlParameter("@nombre", rol.nombre);
            SqlParameter p2 = new SqlParameter("@hab", rol.habilitado);

            List<SqlParameter> parametros = new List<SqlParameter> { p1, p2 };

            db.ejecutarStoredProcedure(procedimiento, parametros);

            //obtengo el id del nuevo rol que inserte
            string sql = "select id_rol from ROL where rol_nombre = '"+rol.nombre+"'";
            rol.id = Convert.ToInt64(db.ejecutarConsulta(sql)[0]["id_rol"]);

            //ahora inserto las funcionalidades
            foreach (Funcionalidad fun in funcionalidades)
            {
                string procedimiento2 = "ACTUALIZAR_FUNCIONALIDADES_DE_ROL";

                SqlParameter pIdRol = new SqlParameter("@id_rol", rol.id);
                SqlParameter pIdFun = new SqlParameter("@id_funcionalidad", fun.id);
                SqlParameter pLoTiene = new SqlParameter("@lo_tiene", fun.habilitado);

                List<SqlParameter> parametros2 = new List<SqlParameter> { pIdRol, pIdFun, pLoTiene };

                db.ejecutarStoredProcedure(procedimiento2, parametros2);
            }
        }

        public void actualizarRolYSusFuncionalidades(Rol rol, List<Funcionalidad> funcionalidades)
        {
            //actualizo el rol
            string procedimiento2 = "ACTUALIZAR_ROL";

            SqlParameter pIdRol = new SqlParameter("@id_rol", rol.id);
            SqlParameter pNombre = new SqlParameter("@nombre", rol.nombre);
            SqlParameter pHab = new SqlParameter("@habilitado", rol.habilitado);

            List<SqlParameter> parametros2 = new List<SqlParameter> { pIdRol, pNombre, pHab };

            db.ejecutarStoredProcedure(procedimiento2, parametros2);

            //actualizo las funcionalidades
            foreach (Funcionalidad fun in funcionalidades)
            {
                string procedimiento = "ACTUALIZAR_FUNCIONALIDADES_DE_ROL";

                SqlParameter p1 = new SqlParameter("@id_rol", rol.id);
                SqlParameter p2 = new SqlParameter("@id_funcionalidad", fun.id);
                SqlParameter p3 = new SqlParameter("@lo_tiene", fun.habilitado);

                List<SqlParameter> parametros = new List<SqlParameter> { p1, p2, p3 };

                db.ejecutarStoredProcedure(procedimiento, parametros);
            }
        }
    }
}




