﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ABM_Usuario.Cliente
{
    public partial class CrearCliente : Form
    {
        private Cliente nuevoCliente;
        private Usuario nuevoUser;
        private RegistrarUsuario registrarUsuario;
        private UsuarioRepository repositorio = new UsuarioRepository();

        public CrearCliente(Usuario nuevoUser, RegistrarUsuario registrarUsuario)
        {
            this.nuevoUser = nuevoUser;
            this.registrarUsuario = registrarUsuario;
            nuevoCliente = new Cliente();
            InitializeComponent();
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {
            cargarClienteVacio();
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            tiposDocumento.Items.Add("DNI");
        }

        private void cargarClienteVacio()
        {
            nuevoCliente.nombre = "";
            nuevoCliente.mail = "";
            nuevoCliente.nick = nuevoUser.nick;
            nuevoCliente.pass = nuevoUser.pass;
            nuevoCliente.tipoDeDocumento = "";
            nuevoCliente.apellido = "";
            nuevoCliente.calle = "";
            nuevoCliente.codigoPostal = 0;
            nuevoCliente.departamento = "";
            nuevoCliente.dni = "";
            nuevoCliente.localidad = "";
            nuevoCliente.numeroDeCalle = 0;
            nuevoCliente.numeroDePiso = 0;
            nuevoCliente.telefono = "";
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            CrearCliente_Load(new object(), new EventArgs());
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (!ejecutarValidaciones())
            {
                return;
            }

            cargarDatosACliente();

            repositorio.agregarCliente(nuevoCliente);

            Confirmacion confirmacion = new Confirmacion(nuevoUser, registrarUsuario);

            confirmacion.ShowDialog();

            Close();
        }

        private bool ejecutarValidaciones()
        {
            if (repositorio.yaExisteEseDni(numeroDocumento.Text))
            {
                MessageBox.Show("Error, DNI ya existente");
                return false;
            }

            return true;
        }

        private void cargarDatosACliente()
        {
            nuevoCliente.nombre = nombre.Text;
            nuevoCliente.mail = email.Text;
            nuevoCliente.tipoDeDocumento = tiposDocumento.SelectedItem.ToString();
            nuevoCliente.apellido = apellido.Text;
            nuevoCliente.calle = calle.Text;
            nuevoCliente.bajaLogica = false;
            nuevoCliente.codigoPostal = Convert.ToInt16(codigoPostal.Text);
            nuevoCliente.departamento = departamento.Text;
            nuevoCliente.dni = numeroDocumento.Text;
            nuevoCliente.localidad = localidad.Text;
            nuevoCliente.numeroDeCalle = Convert.ToInt16(numeroDeCalle.Text);
            nuevoCliente.numeroDePiso = Convert.ToInt16(numeroDePiso.Text);
            nuevoCliente.telefono = telefono.Text;
            nuevoCliente.fechaDeNacimiento=new DateTime(Convert.ToInt16(nacimientoAnio.Text), Convert.ToInt16(nacimientoMes.Text), Convert.ToInt16(nacimientoDia.Text));
        }

        private void back_Click(object sender, EventArgs e)
        {
            registrarUsuario.Show();
            Close();
        }
    }
}