using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Usuario.Cliente;

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

        internal bool yaExisteEseDni(string dni)
        {
            string consulta = "select count(*) from CLIENTE where dni='" + dni + "'";

            return toInt(db.ejecutarConsulta(consulta)) > 0;
        }

        internal void agregarCliente(Cliente nuevoCliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            //cargo parametros
            //hay que checkear el nombre del stored
            db.ejecutarStoredProcedure("st_ingresar_Cliente", parametros);
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