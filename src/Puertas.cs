using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    internal class Puertas
    {
        private int CodigoPuerta;

        public Puertas(int nombre)
        {
            this.CodigoPuerta = nombre;
        }


        public bool ComprobarEstado(Puertas puert)
        {
            string nombre = puert.CodigoPuerta.ToString();
            bool accionador = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string query = "SELECT * FROM puertas WHERE CodigoPuerta = @codigoPuerta AND Abierto = 0";
                    using (MySqlCommand com = new MySqlCommand(query, ConexionBD.Conexion))
                    {
                        com.Parameters.AddWithValue("@codigoPuerta", nombre);

                        using (MySqlDataReader reader = com.ExecuteReader())
                        {
                            if (reader.HasRows) // En caso de que haya registros en el objeto reader
                            {
                                // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                                while (reader.Read())
                                {
                                    accionador = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de la excepción (puedes registrar el error o manejarlo según sea necesario)
                    Console.WriteLine("Ocurrió un error al comprobar el estado: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }
            }

            return accionador;
        }




        public int AbrirPuerta(int puert)
        {
            

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string query = "UPDATE puertas SET Abierto = 1 WHERE CodigoPuerta = @puert AND Abierto = 0";
                    using (MySqlCommand com = new MySqlCommand(query, ConexionBD.Conexion))
                    {
                        com.Parameters.AddWithValue("@puert", puert);
                        int rowsAffected = com.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar la puerta: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("La conexión a la base de datos no está disponible.");
            }
            return 0;   
        }

        public int CerrarPuerta(int puert)
        {


            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string query = "UPDATE puertas SET Abierto = 0 WHERE CodigoPuerta = @puert AND Abierto = 1";
                    using (MySqlCommand com = new MySqlCommand(query, ConexionBD.Conexion))
                    {
                        com.Parameters.AddWithValue("@puert", puert);
                        int rowsAffected = com.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar la puerta: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("La conexión a la base de datos no está disponible.");
            }
            return 0;
        }


    }
}
