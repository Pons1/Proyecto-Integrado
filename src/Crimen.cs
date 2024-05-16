using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    internal class Crimen
    {

        private int idCrimen;
        private string descripcion;
        private int condena;




        public int IdCrimen { get { return idCrimen; } }
        public string Descripcion { get { return descripcion; } }
        public int Condena { get { return condena; } }

        public Crimen(int id, string des, int con)
        {
            this.idCrimen = id;
            this.descripcion = des;
            this.condena = con;

        }

        public static List<int> MostrarIdCrimenes()
        {
            List<int> lista = new List<int>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("Select IdCrimen from crimenes;");

                MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);
                MySqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
                {
                    // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                    while (reader.Read())
                    {
                        
                        
                        lista.Add(reader.GetInt16(0));
                    }
                    ConexionBD.CerrarConexion();

                    return lista;

                }

                // devolvemos la lista cargada con los usuarios.
                ConexionBD.CerrarConexion();

            }

            return lista;



        }

    }

}
