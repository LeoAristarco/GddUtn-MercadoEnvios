using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Confirmacion : Form
    {
        private Usuario nuevoUser;
        private Form formAnterior;

        public Confirmacion(Usuario nuevoUser, Form formAnterior)
        {
            this.nuevoUser = nuevoUser;
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void Confirmacion_Load(object sender, EventArgs e)
        {
            nick.Text = nuevoUser.nick;
            pass.Text = nuevoUser.pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }
    }
}
