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
using WindowsFormsApplication1.Login;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int cantidadCargada = 0;
        private Sistema sistema = Sistema.Instance;
        private bool mostrarLogin=false;
        LoginForm login;

        public Form1(LoginForm login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Hide();
            login.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sistema.darDeBajaPublicacionesVencidas();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barraProgreso.Increment(4);

            if (cantidadCargada < 100)
            {
                cantidadCargada += 4;
            }

            if (mostrarLogin)
            {
                Close();
            }

            if (!backgroundWorker1.IsBusy)
            {
                mostrarLogin = true;
                barraProgreso.Increment(100 - cantidadCargada);
            }
        }
    }
}
