using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    public class Registros
    {
        public static DataTable ObtenerRegistrosConPresos()
        {
            DataTable dt = new DataTable();

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string query = "SELECT CodigoRegistro, Tipo, PresoNIF, Motivo, Fecha FROM registros WHERE PresoNIF IS NOT NULL;";
                    MySqlCommand cmd = new MySqlCommand(query, ConexionBD.Conexion);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    ConexionBD.CerrarConexion();
                }
                catch (Exception ex)
                {
                    ConexionBD.CerrarConexion();
                    throw new Exception("Error al obtener los registros: " + ex.Message);
                }
            }

            return dt;
        }


        public static DataTable ObtenerRegistros(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                using (MySqlConnection conn = ConexionBD.Conexion)
                {
                    conn.Open();
                    string query = @"SELECT CodigoRegistro, Tipo, PresoNIF, Motivo, Fecha 
                             FROM registros 
                             WHERE PresoNIF IS NOT NULL 
                             AND DATE(Fecha) BETWEEN @FechaInicio AND @FechaFin";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    // Convertir las fechas al formato 'yyyy-MM-dd' para la consulta SQL
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin.ToString("yyyy-MM-dd"));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtRegistros);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtRegistros;
        }




    }
}
