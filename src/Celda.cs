using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    internal class Celda
    {
        private int codigoCelda;
        private string modulo;





        public int CodigoCelda { get { return codigoCelda; } }
        public string Modulo { get { return modulo; } }


        public Celda(int id, string mod)
        {
            this.codigoCelda = id;
            this.modulo = mod;


        }

        public static List<int> MostrarIdCeldas()
        {
            List<int> lista = new List<int>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("Select CodigoCelda from celdas where ocupacion <4;");

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
