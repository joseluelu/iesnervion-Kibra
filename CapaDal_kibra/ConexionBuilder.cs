using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CapaDal_kibra
{
    public class ConexionBuilder
    {
        //public String server = "localhost";
        //public String bbdd = "proyecto_kibra";
        private const string usuario = "kibra";
        private const string pass = "Ornitomastoideo27";
        private string stringConexion;
            

        public ConexionBuilder() {
            stringConexion =
                "Server=tcp:buenillodb.database.windows.net,1433;Database=Proyecto_kibra;User ID=" + usuario + "@buenillodb;Password=" + pass + ";Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        /// <summary>
        /// Metodo que devuelve una conexion a la bbdd.
        /// </summary>
        /// <returns></returns>
        public SqlConnection getConexion()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString=stringConexion;
            try
            {
                conexion.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return conexion;
        }


    }
}
