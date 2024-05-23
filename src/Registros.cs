using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PROYECTO
{
    public class Registros
    {
     

    
        public static DataTable ObtenerRegistrosPresos()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = ConexionBD.Conexion)
                {
                    conn.Open();
                    string query = "SELECT CodigoRegistro, Tipo, PresoNIF, Motivo, Fecha FROM registros WHERE PresoNIF IS NOT NULL;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los registros de presos: " + ex.Message);
            }

            return dt;
        }

        // Obtener registros de presos por rango de fechas
        public static DataTable ObtenerRegistrosPresos(DateTime fechaInicio, DateTime fechaFin)
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
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin.ToString("yyyy-MM-dd"));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtRegistros);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los registros de presos por rango de fechas: " + ex.Message);
            }

            return dtRegistros;
        }



        public static DataTable BuscarRegistrosPresosTexto(string valor)
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
                                     AND (CodigoRegistro LIKE @Valor OR Tipo LIKE @Valor OR PresoNIF LIKE @Valor OR Motivo LIKE @Valor OR Fecha LIKE @Valor);";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Valor", "%" + valor + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtRegistros);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar los registros de presos: " + ex.Message);
            }

            return dtRegistros;
        }



        // Obtener registros de empleados
        public static DataTable ObtenerRegistrosEmpleados()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = ConexionBD.Conexion)
                {
                    conn.Open();
                    string query = "SELECT CodigoRegistro, Tipo, EmpleadoNIF, Fecha FROM registros WHERE EmpleadoNIF IS NOT NULL;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los registros de empleados: " + ex.Message);
            }

            return dt;
        }

        

        public static DataTable ObtenerRegistrosEmpleados(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                using (MySqlConnection conn = ConexionBD.Conexion)
                {
                    conn.Open();
                    string query = @"SELECT CodigoRegistro, Tipo, EmpleadoNIF, Fecha 
                                     FROM registros 
                                     WHERE EmpleadoNIF IS NOT NULL 
                                     AND DATE(Fecha) BETWEEN @FechaInicio AND @FechaFin";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin.ToString("yyyy-MM-dd"));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtRegistros);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los registros de empleados por rango de fechas: " + ex.Message);
            }

            return dtRegistros;
        }



        public static DataTable BuscarRegistrosEmpleadosTexto(string valor)
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                using (MySqlConnection conn = ConexionBD.Conexion)
                {
                    conn.Open();
                    string query = @"SELECT CodigoRegistro, Tipo, EmpleadoNIF, Fecha 
                                     FROM registros 
                                     WHERE EmpleadoNIF IS NOT NULL 
                                     AND (CodigoRegistro LIKE @Valor OR Tipo LIKE @Valor OR EmpleadoNIF LIKE @Valor OR Fecha LIKE @Valor);";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Valor", "%" + valor + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtRegistros);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar los registros de empleados: " + ex.Message);
            }

            return dtRegistros;
        }



        
        public static int AgregarRegistroPreso(string tipoRegistro, string presoNIF, string motivo = null)
        {
            try
            {
                using (MySqlConnection conn = ConexionBD.Conexion)
                {
                    conn.Open();
                    string query = @"INSERT INTO registros (Tipo, PresoNIF, Motivo, Fecha)
                             VALUES (@Tipo, @PresoNIF, @Motivo, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Tipo", tipoRegistro);
                    cmd.Parameters.AddWithValue("@PresoNIF", presoNIF);
                    cmd.Parameters.AddWithValue("@Motivo", (tipoRegistro == "SALIDA" && motivo != null) ? motivo : (object)DBNull.Value);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el registro del preso: " + ex.Message);
            }
        }


       


        public static int AgregarRegistroEmpleado(string tipoRegistro, string empleadoNIF)
        {
            try
            {
                using (MySqlConnection conn = ConexionBD.Conexion)
                {
                    conn.Open();
                    string query = @"INSERT INTO registros (Tipo, EmpleadoNIF, Fecha)
                             VALUES (@Tipo, @EmpleadoNIF, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Tipo", tipoRegistro);
                    cmd.Parameters.AddWithValue("@EmpleadoNIF", empleadoNIF);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el registro del empleado: " + ex.Message);
            }
        }

    }
}
