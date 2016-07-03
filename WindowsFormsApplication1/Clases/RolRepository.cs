using System;
using System.Collections.Generic;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Rol
{
    internal class RolRepository:Repository
    {
        public List<Rol> obtenerRolesDe(Usuario usuario)
        {
            List<Rol> roles = new List<Rol>();

            return roles;
        }

        public void eliminarRolDe(Usuario user, Rol rolSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}