using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Usuario.Cliente;
using WindowsFormsApplication1.ABM_Usuario.Empresa;

namespace WindowsFormsApplication1.Clases
{
    internal class UsuarioRepository:Repository
    {
        internal Usuario traerPorId(long v)
        {
            string consulta = "select * from USUARIO where id_usuario=" + v.ToString();
            return deserializarUsuario(db.ejecutarConsulta(consulta)[0]);
        }

        private Usuario deserializarUsuario(Dictionary<string, object> dictionary)
        {
            Usuario user = new Usuario();
            user.id = toLong(dictionary["id_usuario"]);//POR AHORA MAPEO SOLO ESTO
            return user;
        }

        internal List<Cliente> buscarClientes(string nombre, string apellido, string dni, string mail)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@nombre", nombre);
            db.agregarParametro(parametros, "@apellido", apellido);
            db.agregarParametro(parametros, "@numeroDocumento", dni);
            db.agregarParametro(parametros, "@mail", mail);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("st_buscar_clientes", parametros);

            List<Cliente> clientesEncontrados = new List<Cliente>();

            foreach (Dictionary<string,object> fila in tabla)
            {
                clientesEncontrados.Add(deserializarCliente(fila));
            }

            return clientesEncontrados;
        }

        internal void modificarEmpresa(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        internal void agregarEmpresa(Empresa nuevaEmpresa)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@nick", nuevaEmpresa.nick);
            db.agregarParametro(parametros, "@pass", nuevaEmpresa.pass);
            db.agregarParametro(parametros, "@fechaAltaSistema", Sistema.Instance.getDate());
            db.agregarParametro(parametros, "@fechaNacimiento", nuevaEmpresa.fechaDeNacimiento);
            db.agregarParametro(parametros, "@mail", nuevaEmpresa.mail);
            db.agregarParametro(parametros, "@telefono", nuevaEmpresa.telefono);
            db.agregarParametro(parametros, "@calle", nuevaEmpresa.calle);
            db.agregarParametro(parametros, "@numeroCalle", nuevaEmpresa.numeroDeCalle);
            db.agregarParametro(parametros, "@numeroPiso", nuevaEmpresa.numeroDePiso);
            db.agregarParametro(parametros, "@departamento", nuevaEmpresa.departamento);
            db.agregarParametro(parametros, "@localidad", nuevaEmpresa.localidad);
            db.agregarParametro(parametros, "@codigoPostal", nuevaEmpresa.codigoPostal);
            db.agregarParametro(parametros, "@razonSocial", nuevaEmpresa.razonSocial);
            db.agregarParametro(parametros, "@cuit", nuevaEmpresa.cuit);
            db.agregarParametro(parametros, "@nombreContacto", nuevaEmpresa.nombreDeContacto);
            db.agregarParametro(parametros, "@ciudad", nuevaEmpresa.ciudad);
            db.agregarParametro(parametros, "@rubro", nuevaEmpresa.rubro);

            db.ejecutarStoredProcedure("st_agregar_empresa", parametros);
        }

        internal bool yaExisteCuit(string cuit)
        {
            string consulta = "select count(*) from EMPRESA where cuit='" + cuit + "'";

            return toInt(db.ejecutarConsulta(consulta)) > 0;
        }

        internal List<Empresa> buscarEmpresas(string razonSocial, string cuit, string mail)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@razonSocial", razonSocial);
            db.agregarParametro(parametros, "@cuit", cuit);
            db.agregarParametro(parametros, "@mail", mail);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("st_buscar_empresas", parametros);

            List<Empresa> empresasEncontradas = new List<Empresa>();

            foreach (Dictionary<string, object> fila in tabla)
            {
                empresasEncontradas.Add(deserializarEmpresa(fila));
            }

            return empresasEncontradas;

        }

        internal bool yaExisteRazonSocial(string razonSocial)
        {
            string consulta = "select count(*) from EMPRESA where razon_social='" + razonSocial + "'";

            return toInt(db.ejecutarConsulta(consulta)) > 0;
        }

        private Empresa deserializarEmpresa(Dictionary<string, object> fila)
        {
            Empresa empresa = new Empresa();

            empresa.id = toLong(fila["id_usuario"]);
            empresa.idEmpresa = toLong(fila["id_empresa"]);
            empresa.mail = fila["mail"].ToString();
            empresa.nick = fila["nick"].ToString();
            empresa.pass = fila["pass"].ToString();
            empresa.calle = fila["calle"].ToString();
            empresa.codigoPostal = toInt(fila["codigo_postal"]);
            empresa.departamento = fila["departamento"].ToString();
            empresa.localidad = fila["localidad"].ToString();
            empresa.numeroDeCalle = toInt(fila["numero_calle"]);
            empresa.numeroDePiso = toInt(fila["numero_piso"]);
            empresa.telefono = fila["telefono"].ToString();
            empresa.bajaLogica = toBool(fila["baja_logica"]);
            empresa.fechaDeNacimiento = toDate(fila["fecha_nacimiento"]);
            empresa.razonSocial = fila["razon_social"].ToString();
            empresa.nombreDeContacto = fila["nombre_contacto"].ToString();
            empresa.ciudad = fila["ciudad"].ToString();
            empresa.rubro = fila["rubro"].ToString();
            empresa.cuit = fila["cuit"].ToString();
            empresa.reputacion = toDouble(fila["reputacion"]);
            empresa.cantidadDeVotos = toInt(fila["cantidad_votos"]);

            return empresa;
        }

        private Cliente deserializarCliente(Dictionary<string, object> fila)
        {
            Cliente nuevoCliente = new Cliente();

            nuevoCliente.id = toLong(fila["id_usuario"]);
            nuevoCliente.idCliente = toLong(fila["id_cliente"]);
            nuevoCliente.nombre = fila["nombre"].ToString();
            nuevoCliente.mail = fila["mail"].ToString();
            nuevoCliente.nick = fila["nick"].ToString();
            nuevoCliente.pass = fila["pass"].ToString();
            nuevoCliente.tipoDeDocumento = fila["tipo_documento"].ToString();
            nuevoCliente.apellido = fila["apellido"].ToString();
            nuevoCliente.calle = fila["calle"].ToString();
            nuevoCliente.codigoPostal = toInt(fila["codigo_postal"]);
            nuevoCliente.departamento = fila["departamento"].ToString();
            nuevoCliente.dni = fila["dni"].ToString();
            nuevoCliente.localidad = fila["localidad"].ToString();
            nuevoCliente.numeroDeCalle = toInt(fila["numero_calle"]);
            nuevoCliente.numeroDePiso = toInt(fila["numero_piso"]);
            nuevoCliente.telefono = fila["telefono"].ToString();
            nuevoCliente.bajaLogica = toBool(fila["baja_logica"]);
            nuevoCliente.fechaDeNacimiento = toDate(fila["fecha_nacimiento"]);

            return nuevoCliente;
        }

        internal Dictionary<Usuario, int> obtenerTop5ConMenosVentas(List<int> meses, int anio, Visibilidad visibilidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            for (int i = 1; i < 4; i++)
            {
                db.agregarParametro(parametros, "@mes" + i.ToString(), meses[i-1]);
            }

            db.agregarParametro(parametros, "@anio", anio);

            if (visibilidad==null)
            {
                db.agregarParametro(parametros, "@visibilidad", null);
            }
            else
            {
                db.agregarParametro(parametros, "@visibilidad", visibilidad.id);
            }

            List<Dictionary<string,object>> tabla = db.ejecutarStoredProcedure("st_top5_vendedores_menos_venta", parametros);

            Dictionary<Usuario, int> dictionaryUsersVentasFallidas = new Dictionary<Usuario, int>();

            foreach (Dictionary<string,object> item in tabla)
            {
                Usuario user = new Usuario();
                user.nick = item["nick"].ToString();
                user.mail = item["mail"].ToString();
                dictionaryUsersVentasFallidas.Add(user, toInt(item["cant_productos_no_vendidos"]));
            }

            return dictionaryUsersVentasFallidas;
        }

        internal void modificarCliente(Cliente cliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            //cargo parametros
            //hay que checkear el nombre del stored
            db.ejecutarStoredProcedure("st_ingresar_Cliente", parametros);
        }

        internal bool yaExisteEseDni(string dni)
        {
            string consulta = "select count(*) from CLIENTE where dni='" + dni + "'";

            return toInt(db.ejecutarConsulta(consulta)) > 0;
        }

        internal void agregarCliente(Cliente nuevoCliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            db.agregarParametro(parametros, "@nick", nuevoCliente.nick);
            db.agregarParametro(parametros, "@pass", nuevoCliente.pass);
            db.agregarParametro(parametros, "@fechaAltaSistema", Sistema.Instance.getDate());
            db.agregarParametro(parametros, "@fechaNacimiento", nuevoCliente.fechaDeNacimiento);
            db.agregarParametro(parametros, "@mail", nuevoCliente.mail);
            db.agregarParametro(parametros, "@telefono", nuevoCliente.telefono);
            db.agregarParametro(parametros, "@calle", nuevoCliente.calle);
            db.agregarParametro(parametros, "@numeroCalle", nuevoCliente.numeroDeCalle);
            db.agregarParametro(parametros, "@numeroPiso", nuevoCliente.numeroDePiso);
            db.agregarParametro(parametros, "@departamento", nuevoCliente.departamento);
            db.agregarParametro(parametros, "@localidad", nuevoCliente.localidad);
            db.agregarParametro(parametros, "@codigoPostal", nuevoCliente.codigoPostal);
            db.agregarParametro(parametros, "@nombre", nuevoCliente.nombre);
            db.agregarParametro(parametros, "@apellido", nuevoCliente.apellido);
            db.agregarParametro(parametros, "@dni", nuevoCliente.dni);
            db.agregarParametro(parametros, "@tipo_documento", nuevoCliente.tipoDeDocumento);

            db.ejecutarStoredProcedure("st_agregar_cliente", parametros);
        }

        internal bool yaExisteEseNick(string nick)
        {
            string consulta = "select count(*) from USUARIO where nick='" + nick + "'";

            return toInt(db.ejecutarConsulta(consulta)) > 0;
        }

        internal void updatePassword(Usuario usuario, string nuevaPass)
        {
            string update = "update Usuario set pass=" + nuevaPass + " where id_usuario=" + usuario.id.ToString();
            db.ejecutarConsulta(update);
        }

        internal Dictionary<Usuario, long> obtenerTop5ConMayorFactura(List<int> meses, int anio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            for (int i = 1; i < 4; i++)
            {
                db.agregarParametro(parametros, "@mes" + i.ToString(), meses[i - 1]);
            }

            db.agregarParametro(parametros, "@anio", anio);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("st_top5_vendedores_mayor_monto_facturado", parametros);

            Dictionary<Usuario, long> dictionaryUsersMayorFactura = new Dictionary<Usuario, long>();

            foreach (Dictionary<string, object> item in tabla)
            {
                Usuario user = new Usuario();
                user.nick = item["nick"].ToString();
                user.mail = item["mail"].ToString();
                dictionaryUsersMayorFactura.Add(user, toLong(item["mayor_monto_facturado"]));
            }

            return dictionaryUsersMayorFactura;
        }

        internal Dictionary<Usuario, int> obtenerTop5ConMasFacturas(List<int> meses, int anio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            for (int i = 1; i < 4; i++)
            {
                db.agregarParametro(parametros, "@mes" + i.ToString(), meses[i - 1]);
            }

            db.agregarParametro(parametros, "@anio", anio);

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("st_top5_vendedores_mayor_facturas", parametros);

            Dictionary<Usuario, int> dictionaryUsersMasFacturas = new Dictionary<Usuario, int>();

            foreach (Dictionary<string, object> item in tabla)
            {
                Usuario user = new Usuario();
                user.nick = item["nick"].ToString();
                user.mail = item["mail"].ToString();
                dictionaryUsersMasFacturas.Add(user, toInt(item["cant_de_facturas"]));
            }

            return dictionaryUsersMasFacturas;
        }

        internal Dictionary<Usuario, int> obtenerTop5ConMasCompras(List<int> meses, int anio, Rubro rubro)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            for (int i = 1; i < 4; i++)
            {
                db.agregarParametro(parametros, "@mes" + i.ToString(), meses[i - 1]);
            }

            db.agregarParametro(parametros, "@anio", anio);

            if (rubro == null)
            {
                db.agregarParametro(parametros, "@rubro", null);
            }
            else
            {
                db.agregarParametro(parametros, "@rubro", rubro.id);
            }

            List<Dictionary<string, object>> tabla = db.ejecutarStoredProcedure("st_top5_clientes_mas_compras", parametros);

            Dictionary<Usuario, int> dictionaryUsersMasCompras = new Dictionary<Usuario, int>();

            foreach (Dictionary<string, object> item in tabla)
            {
                Usuario user = new Usuario();
                user.nick = item["nick"].ToString();
                user.mail = item["mail"].ToString();
                dictionaryUsersMasCompras.Add(user, toInt(item["cant_de_productos_comprados"]));
            }

            return dictionaryUsersMasCompras;
        }
    }
}