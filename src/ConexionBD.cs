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
        private MySqlConnection conexion;
        public MySqlConnection Conexion { get { return conexion; } }

        public ConexionBD()
        {
            string server = "server=127.0.0.1;";
            string port = "port=3306;";
            string database = "database=proyecto;";
            string usuario = "uid=root;";
            string password = "pwd=;";
            string convert = "Convert Zero Datetime=True;";
            string connectionstring = server + port + database + usuario + password + convert;

            conexion = new MySqlConnection(connectionstring);
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
