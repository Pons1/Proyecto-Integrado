using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROYECTO
{
    
        internal class ConexionBD
        {
            private static MySqlConnection conexion = null;
            private static readonly object padlock = new object();


            private ConexionBD() { }

            public static MySqlConnection Conexion
            {
                get
                {
                    lock (padlock)
                    {
                        if (conexion == null)
                        {
                            conexion = new MySqlConnection();
                            conexion.ConnectionString = "server=127.0.0.1;database=centralis;uid=root;pwd=";
                        }
                        return conexion;
                    }
                }
            }

            //Abre la conexión con la base de datos

            public static void AbrirConexion()
            {
                if (conexion != null)
                {
                    conexion.Open();
                }
            }
            //Cierra la conexión con la base de datos

            public static void CerrarConexion()
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
        }
}
