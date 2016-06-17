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

            dataReader = dataBase.getDataReader(procedimientoSql, 'P', parametros);

            logueo.roles = mapearDataReadADiccionarioRoles();
            dataBase.cerrarConexion();
        }
        
        private Dictionary<long, string> mapearDataReadADiccionarioRoles()
        {
            if (!dataReader.HasRows) return null;

            Dictionary<long, string> roles = new Dictionary<long, string>();

            while (dataReader.Read())
            {
                long key = dataReader.GetSqlDecimal(3).Scale;
                string value = dataReader.GetString(4);
                
                roles.Add(key, value);              
            }

            return roles;
        }
    }
}
