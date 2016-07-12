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
    public partial class BuscarEmpresa : Form
    {
        private Empresa empresaSeleccionada;
        private List<Empresa> empresasEncontradas = new List<Empresa>();
        private Form formAnterior;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public BuscarEmpresa(Form formAnterior)
        {
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            empresasEncontradas = repositorio.buscarEmpresas(filtroRazonSocial.Text, filtroCuit.Text, filtroMail.Text);

            cargarTablaEmpresas();
        }

        private void cargarTablaEmpresas()
        {
            foreach (Empresa empresa in empresasEncontradas)
            {
                tablaEmpresas.Rows.Add(empresa.nick, empresa.razonSocial, empresa.cuit, empresa.mail, empresa.reputacion);
            }

            modificar.Enabled = empresasEncontradas.Count > 0;
        }

        private void BuscarEmpresa_Load(object sender, EventArgs e)
        {
            inicializarTablaEmpresas();
        }

        private void inicializarTablaEmpresas()
        {
            DataGridViewTextBoxColumn cNick = new DataGridViewTextBoxColumn();
            cNick.HeaderText = "NickName";
            cNick.ReadOnly = true;
            tablaEmpresas.Columns.Add(cNick);
            DataGridViewTextBoxColumn cRazonSocial = new DataGridViewTextBoxColumn();
            cRazonSocial.HeaderText = "Razon Social";
            cRazonSocial.ReadOnly = true;
            tablaEmpresas.Columns.Add(cRazonSocial);
            DataGridViewTextBoxColumn cCuit = new DataGridViewTextBoxColumn();
            cCuit.HeaderText = "CUIT";
            cCuit.ReadOnly = true;
            tablaEmpresas.Columns.Add(cCuit);
            DataGridViewTextBoxColumn cMail = new DataGridViewTextBoxColumn();
            cMail.HeaderText = "Mail";
            cMail.ReadOnly = true;
            tablaEmpresas.Columns.Add(cMail);
            DataGridViewTextBoxColumn cReputacion = new DataGridViewTextBoxColumn();
            cReputacion.HeaderText = "Reputacion";
            cReputacion.ReadOnly = true;
            tablaEmpresas.Columns.Add(cReputacion);
        }

        private void tablaEmpresas_Click(object sender, EventArgs e)
        {
            empresaSeleccionada = empresasEncontradas[tablaEmpresas.CurrentCell.RowIndex];
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            ModificarEmpresa modificar = new ModificarEmpresa(empresaSeleccionada, this);

            Hide();

            modificar.ShowDialog();
        }

        private void BuscarEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
