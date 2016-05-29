using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1.Clases
{
    class DataBase
    {
        #region Singleton
        private static volatile DataBase instancia = null;

        public static DataBase Instance
        {
            get
            { return newInstance(); }
        }

        internal static DataBase newInstance()
        {
            if (instancia != null) { }
            else
            {
                instancia = new DataBase();
            }
            return instancia;
        }

        #endregion
        //Para obtener instancia escribir Database.Instance

        private string datosConexion = @"Data Source=localhost\SQLSERVER2012;"
                                + "Initial Catalog=GD1C2016;Integrated Security=false;"
                                + "UID=gd;PWD=gd2016;";

        private SqlConnection conexion;

        private DataBase()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = datosConexion;
        }

        public void abrirConexion()
        {
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        private SqlDataReader getDataReader(string consulta,char tipoConsulta,List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = consulta;

            switch (tipoConsulta)
            {
                case 'T':
                    comando.CommandType = CommandType.Text;
                    break;
                /*case 'D':
                    comando.CommandType = CommandType.TableDirect;
                    break;*///Lo comento porque por ahora no se cuando se usaria
                case 'P':
                    comando.CommandType = CommandType.StoredProcedure;
                    break;
            }

            foreach (SqlParameter parametro in parametros)
            {
                comando.Parameters.Add(parametro);
            }

            return comando.ExecuteReader();
        }

        public void agregarParametro(List<SqlParameter> lista, string parametro, object valor)
        {
            lista.Add(new SqlParameter(parametro, valor));
        }

        public SqlDataReader ejecutarStoredProcedure(string storedProcedure,List<SqlParameter> parametros)
        {
            return getDataReader(storedProcedure, 'P', parametros);
        }

        public SqlDataReader ejecutarConsulta(string consulta, List<SqlParameter> parametros)
        {
            return getDataReader(consulta, 'T', parametros);
        }

        public SqlDataReader ejecutarConsulta(string consulta)
        {
            return getDataReader(consulta, 'T', new List<SqlParameter>());
        }

        public object getValue(SqlDataReader dataReader,string nombreCampo)//hay que castear al valor pedido
        {
            return dataReader[nombreCampo];
        }

        public bool contieneFilas(SqlDataReader reader)
        {
            return reader.HasRows;
        }

    }
}
