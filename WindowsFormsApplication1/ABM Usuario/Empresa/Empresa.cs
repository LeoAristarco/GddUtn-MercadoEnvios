using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario.Empresa
{
    class Empresa:Usuario
    {
        public long idEmpresa;
	    public string razonSocial;
        public string cuit;
        public string nombreDeContacto;
        public string ciudad;
        public double reputacion;
        public string rubro;
	    public long cantidadDeVotos;

    }
}
