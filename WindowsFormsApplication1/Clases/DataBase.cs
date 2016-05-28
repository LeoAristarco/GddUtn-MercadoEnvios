using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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


    }
}
