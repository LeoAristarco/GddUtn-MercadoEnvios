using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario.Cliente
{
    class Cliente:Usuario
    {
        public long idCliente;
	    public string nombre;
        public string apellido;
        public string dni;
        public string tipoDeDocumento;
    }
}
