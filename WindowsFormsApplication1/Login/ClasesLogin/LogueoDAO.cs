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
            
            logueo.roles = obtenerRolesPorProcedimientoSQL(procedimientoSql, parametros);
        }
        
        private Dictionary<double, string> obtenerRolesPorProcedimientoSQL(string nombreProcedimientoSQL, List<SqlParameter> parametros)
        {
            dataBase.abrirConexion();

            dataReader = dataBase.getDataReader(nombreProcedimientoSQL, 'P', parametros);

            if (!dataReader.HasRows)
            {
                dataBase.cerrarConexion();
                return null;
            }

            Dictionary<double, string> roles = new Dictionary<double, string>();
            while (dataReader.Read())
            {
                double key = dataReader.GetSqlDecimal(3).ToDouble();
                string value = dataReader.GetString(4);
                
                roles.Add(key, value);              
            }

            dataBase.cerrarConexion();
            return roles;
        }
    }
}
