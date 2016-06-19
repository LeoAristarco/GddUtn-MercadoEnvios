using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Login.ClasesLogin;

namespace WindowsFormsApplication1.Login
{
    public partial class SeleccionFuncionalidades : Form
    {
        public Logueo logueo { get; set; }

        private SeleccionRoles formPadre;

        private LogueoDAO dataBase;

        public SeleccionFuncionalidades(SeleccionRoles formPadre)
        {
            InitializeComponent();

            this.formPadre = formPadre;
            logueo = formPadre.logueo;
            dataBase = new LogueoDAO();

            cargarComboBoxConFuncionalidades();
        }

        private void cargarComboBoxConFuncionalidades()
        {
            if (!logueo.funcionalidadesPorRol.ContainsKey(logueo.idRolSeleccionado)) return;

            List<string> items = new List<string>();

            items.AddRange(logueo.funcionalidadesPorRol.SingleOrDefault(x => x.Key.Equals(logueo.idRolSeleccionado)).Value.Values);

            foreach (string func in items)
            {
                cbFuncionalidades.Items.Add(func);
            }
        }

        private void continuar_Click(object sender, EventArgs e)
        {

        }
    }
}
