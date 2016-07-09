using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Login;

namespace WindowsFormsApplication1.Facturas
{
    public partial class FacturasRealizadas : Form
    {
        private SeleccionFuncionalidades seleccionFuncionalidades;

        public FacturasRealizadas()
        {
            InitializeComponent();
        }

        public FacturasRealizadas(SeleccionFuncionalidades seleccionFuncionalidades)
        {
            this.seleccionFuncionalidades = seleccionFuncionalidades;
        }
    }
}
