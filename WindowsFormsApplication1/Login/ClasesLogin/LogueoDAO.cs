using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Login.ClasesLogin
{
    public class LogueoDAO
    {
        private BD dataBase;

        private SqlDataReader dataReader;

        public LogueoDAO()
        {
            dataBase = BD.getInstance();
        }

        public void loguear(Logueo logueo)
        {
            string procedimientoSql = "VERIFICAR_LOGUEO";

            SqlParameter pNick = new SqlParameter("@nick", logueo.nick);
            SqlParameter pPass = new SqlParameter("@pass", logueo.pass);
            List<SqlParameter> parametros = new List<SqlParameter> { pNick, pPass };
            
            cargarLogueoConProcedimientoSQL(procedimientoSql, parametros, logueo);
        }
        
        private void cargarLogueoConProcedimientoSQL(string nombreProcedimientoSQL, List<SqlParameter> parametros, Logueo logueo)
        {
            dataBase.abrirConexion();

            dataReader = dataBase.getDataReader(nombreProcedimientoSQL, 'P', parametros);

            if (!dataReader.HasRows)
            {
                dataBase.cerrarConexion();
                return;
            }
            
            while (dataReader.Read())
            {
                double key = dataReader.GetSqlDecimal(1).ToDouble();
                string value = dataReader.GetString(2);
                logueo.roles.Add(key, value);            

                logueo.bajaLogica = dataReader.GetBoolean(3);
                logueo.idUsuario = dataReader.GetSqlDecimal(0).ToDouble();
            }
            
            dataBase.cerrarConexion();
        }

        public void cargarFuncionalidadesDelRolElegido(double idRol, Logueo logueo)
        {

            if (logueo.funcionalidadesPorRol.ContainsKey(idRol)) return;

            dataBase.abrirConexion();

            string procedimiento = "OBTENER_FUNCIONALIDADES_POR_ID_ROL";

            SqlParameter pIdRol = new SqlParameter("@id_rol", idRol);
            List<SqlParameter> parametros = new List<SqlParameter> { pIdRol };

            dataReader = dataBase.getDataReader(procedimiento, 'P', parametros);

            if (!dataReader.HasRows)
            {
                dataBase.cerrarConexion();
                return;
            }

            double keyRol = idRol;
            Dictionary<double, string> dic = new Dictionary<double, string>();

            while (dataReader.Read())
            {
                double keyFunc = dataReader.GetSqlDecimal(0).ToDouble();
                string value = dataReader.GetString(1);

                dic.Add(keyFunc, value);
            }

            logueo.funcionalidadesPorRol.Add(keyRol, dic);
            logueo.idRolSeleccionado = idRol;

            dataBase.cerrarConexion();
        }

    }
}
