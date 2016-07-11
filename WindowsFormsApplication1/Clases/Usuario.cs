using System;
using WindowsFormsApplication1.ABM_Rol;

namespace WindowsFormsApplication1.Clases
{
    public class Usuario
    {
        public long id;//{ get; }
        public string nick = "";
        public string mail;
        public string pass;
        //public int intentosLogin;
	    //public bool primerIngreso;
        public bool bajaLogica;
        //fechaalta_sistema date,
        public DateTime fechaDeNacimiento;
	    public string telefono;
	    public string calle;
	    public int numeroDeCalle;
	    public int numeroDePiso;
	    public string departamento;
	    public string localidad;
	    public int codigoPostal;

        public bool tenesRolAdministrativo()
        {
            return (new RolRepository()).tieneRolAdministrativo(this);
        }
    }
}