using MySql.Data.MySqlClient;
using PROYECTO.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public class Preso
    {
        private string nif;
        private string nombre;
        private string apellidos;
        private int crimen;
        private string sexo;
        private string direccion;
        private int codigoPostal;
        private string correo;
        private int celda;
        private int presente;
        private int telefono;
        private Image foto;



        public string Nif { get{ return nif; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }
        public int Crimen { get { return crimen; } }
        public string Sexo { get { return sexo; } }
        public string Direccion { get { return direccion; } }
        public int CodigoPostal { get { return codigoPostal; } }
        public string Correo { get { return correo; } }
        public int Celda { get { return celda; } }

        public int Telefono { get { return telefono; } }

        public Image Foto { get { return foto; } }


        public Preso(string Nif, string Nombre, string Apellidos, int Crimen, string Sexo, string Direccion, int CodigoPostal, string Correo, int Celda,int pres, Image fot,int tel)
        {
            this.nif = Nif;
            this.nombre = Nombre;
            this.apellidos = Apellidos;
            this.crimen = Crimen;
            this.sexo = Sexo;
            this.direccion = Direccion;
            this.codigoPostal = CodigoPostal;
            this.correo = Correo;
            this.celda = Celda;
            presente = pres;
            this.foto = fot;
            telefono = tel;


        }

        public static bool MarcarPresente(string nif)
        {
            bool exito = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();


                    string consulta = String.Format("SELECT Presente FROM presos WHERE NIF = '{0}';", nif);
                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        int presente = Convert.ToInt32(resultado);
                        int nuevoEstado = (presente == 1) ? 0 : 1;


                        string updateConsulta = String.Format("UPDATE presos SET Presente = {1} WHERE NIF = '{0}';", nif, nuevoEstado);
                        MySqlCommand updateComando = new MySqlCommand(updateConsulta, ConexionBD.Conexion);
                        int filasAfectadas = updateComando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            exito = true;
                        }
                    }

                    ConexionBD.CerrarConexion();
                }
                catch (Exception ex)
                {
                    ConexionBD.CerrarConexion();
                    MessageBox.Show(ex.Message);
                }
            }

            return exito;
        }

        public static bool MarcarBorrado(string nif)
        {
            bool exito = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string consulta = String.Format("UPDATE presos SET presente = 1 WHERE NIF = '{0}';", nif);

                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        exito = true;
                    }

                    ConexionBD.CerrarConexion();
                }
                catch (Exception ex)
                {
                    ConexionBD.CerrarConexion();
                    MessageBox.Show(ex.Message);
                }
            }

            return exito;
        }

        public static bool EstaPresente(string nif)
        {
            bool presente = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string consulta = String.Format("SELECT Presente FROM presos WHERE NIF = '{0}';", nif);

                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        presente = Convert.ToInt32(resultado) == 1;
                    }

                    ConexionBD.CerrarConexion();
                }
                catch (Exception ex)
                {
                    ConexionBD.CerrarConexion();
                    MessageBox.Show(ex.Message);
                }
            }

            return presente;
        }


        public static bool EstaBorrado(string nif)
        {
            bool presente = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string consulta = String.Format("SELECT Borrado FROM presos WHERE NIF = '{0}';", nif);

                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        presente = Convert.ToInt32(resultado) == 1;
                    }

                    ConexionBD.CerrarConexion();
                }
                catch (Exception ex)
                {
                    ConexionBD.CerrarConexion();
                    MessageBox.Show(ex.Message);
                }
            }

            return presente;
        }


        public static bool PresoRegistrado(string nif)
        {
            bool registrado = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string consulta = String.Format("SELECT COUNT(*) FROM presos WHERE NIF = '{0}';", nif);

                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        registrado = Convert.ToInt32(resultado) > 0;
                    }

                    ConexionBD.CerrarConexion();
                }
                catch (Exception ex)
                {
                    ConexionBD.CerrarConexion();
                    MessageBox.Show(ex.Message);
                }
            }

            return registrado;
        }


        public static List<Preso> MostrarPresos()
        {
            List<Preso> lista = new List<Preso>();


            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("Select * from presos;");

                MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);
                MySqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
                {
                    // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                    while (reader.Read())
                    {
                        Image foto = null;
                       
                        if (reader["foto"] == System.DBNull.Value)
                        {
                            foto = Resources.def;

                        }
                        else
                        {
                            byte[] img = (byte[])reader["foto"];
                            MemoryStream ms = new MemoryStream(img);
                            foto = Image.FromStream(ms);
                        }

                        Preso user = new Preso(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9),foto, reader.GetInt32(11));
                        lista.Add(user);
                    }
                    ConexionBD.CerrarConexion();

                    return lista;

                }

                // devolvemos la lista cargada con los usuarios.
                ConexionBD.CerrarConexion();

            }

            return lista;



        }
        public static List<Preso> MostrarPresosPorModulo(string mod)
        {
            List<Preso> lista = new List<Preso>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("SELECT * FROM presos INNER JOIN celdas ON presos.celda = celdas.CodigoCelda WHERE celdas.Modulo = '{0}';", mod);

                MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);
                MySqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
                {
                    // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                    while (reader.Read())
                    {
                        Image foto = null;

                        if (reader["foto"] == System.DBNull.Value)
                        {
                            foto = Resources.def;

                        }
                        else
                        {
                            byte[] img = (byte[])reader["foto"];
                            MemoryStream ms = new MemoryStream(img);
                            foto = Image.FromStream(ms);
                        }


                        Preso user = new Preso(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9), foto, reader.GetInt32(11));
                        lista.Add(user);
                    }
                    ConexionBD.CerrarConexion();

                    return lista;

                }

                // devolvemos la lista cargada con los usuarios.
                ConexionBD.CerrarConexion();

            }

            return lista;



        }
        public static List<Preso> MostrarPresosPorCelda(int celda)
        {
            List<Preso> lista = new List<Preso>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("SELECT * FROM presos WHERE celda = '{0}';", celda);

                MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);
                MySqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
                {
                    // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                    while (reader.Read())
                    {
                        Image foto = null;

                        if (reader["foto"] == System.DBNull.Value)
                        {
                            foto = Resources.def;

                        }
                        else
                        {
                            byte[] img = (byte[])reader["foto"];
                            MemoryStream ms = new MemoryStream(img);
                            foto = Image.FromStream(ms);
                        }


                        Preso user = new Preso(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9), foto, reader.GetInt32(11));
                        lista.Add(user);
                    }
                    ConexionBD.CerrarConexion();

                    return lista;

                }

                // devolvemos la lista cargada con los usuarios.
                ConexionBD.CerrarConexion();

            }

            return lista;



        }
        public bool presoPoli() 
        {
            ConexionBD.AbrirConexion();

            string consulta = String.Format("Select nombre from empleados where nif='{0}'",this.nif);


            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            object nom = comando.ExecuteScalar();

            ConexionBD.CerrarConexion();
            if (nom==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int AgregarPreso()
        {
            if (presoPoli())
            {
                MessageBox.Show("Nif presente en tabla empleados");
                return -1;
            }else
            {
                if (ConexionBD.Conexion != null)
                {
                    try
                    {


                        ConexionBD.AbrirConexion();
                        int retorno;
                        MemoryStream ms = new MemoryStream();
                        this.foto.Save(ms, ImageFormat.Jpeg);
                        byte[] aByte = ms.ToArray();

                        string consulta = String.Format("INSERT INTO presos (nif,nombre,apellidos,crimen,sexo,direccion,codigopostal,correo,celda,presente,telefono,foto) VALUES " +
                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',@imagen)", this.nif, this.nombre, this.apellidos, crimen, sexo, direccion, codigoPostal, correo, celda, 1, telefono);


                        MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                        comando.Parameters.AddWithValue("imagen", aByte);
                        retorno = comando.ExecuteNonQuery();

                        ConexionBD.CerrarConexion();
                        MessageBox.Show("Recluso añadido correctamente");
                        /////////////////////////////////////////////////////////
                        ConexionBD.AbrirConexion();


                        string con = String.Format("UPDATE celdas SET ocupacion = ocupacion + 1 WHERE codigocelda = '{0}'", celda);


                        MySqlCommand com = new MySqlCommand(con, ConexionBD.Conexion);
                        com.ExecuteNonQuery();

                        ConexionBD.CerrarConexion();
                        ///////////////////////////////////////////

                    }
                    catch (Exception ex)
                    {
                        ConexionBD.CerrarConexion();

                        MessageBox.Show(ex.Message);
                        return -1;
                    }
                    ConexionBD.CerrarConexion();

                    return -1;


                }
                return -1;
            }
            
           


        }
        public static List<Preso> MostrarPresosPorNombre(string nom)
        {
            List<Preso> lista = new List<Preso>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("SELECT * FROM presos WHERE nombre LIKE '%{0}%';", nom);

                MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);
                MySqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
                {
                    // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                    while (reader.Read())
                    {
                        Image foto = null;

                        if (reader["foto"] == System.DBNull.Value)
                        {
                            foto = Resources.def;

                        }
                        else
                        {
                            byte[] img = (byte[])reader["foto"];
                            MemoryStream ms = new MemoryStream(img);
                            foto = Image.FromStream(ms);
                        }

                        Preso user = new Preso(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9), foto, reader.GetInt32(11));
                        lista.Add(user);
                    }
                    ConexionBD.CerrarConexion();

                    return lista;

                }

                // devolvemos la lista cargada con los usuarios.
                ConexionBD.CerrarConexion();

            }

            return lista;



        }
        public static Image ConsultarImagenPreso( string ni)
        {
            Image foto=null;


            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string c = String.Format("Select foto from presos where nif='{0}';", ni);

                    MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);




                    if (com.ExecuteScalar() == System.DBNull.Value)
                    {
                        foto = Resources.def;

                    }
                    else
                    {
                        object fot = com.ExecuteScalar();

                        byte[] img = (byte[])fot;
                        MemoryStream ms = new MemoryStream(img);

                        foto = Image.FromStream(ms);

                    }

                    ConexionBD.CerrarConexion();
                    ConexionBD.CerrarConexion();

                    return foto;

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); return null;
                }

            }

            return foto;
        }
        public static bool DNICorrecto(string dni)
        {
            //Comprueba si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                return false;
            }

            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1).ToUpper();
            //intenta parsear para comprobar si son numeros
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }

            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniInteger % 23;

            if (control[mod] != dniLeter)
            {
                return false;
            }

            //DNI Valido
            return true;
        }

        public static int BorrarPreso(string ni, int celda)
        {
            int retorno = -1;
            if (ConexionBD.Conexion != null)
            {
                
                try
                {

                    ConexionBD.AbrirConexion();


                    string consulta = String.Format("Delete from presos where nif='{0}'", ni); ;


                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                     retorno = comando.ExecuteNonQuery();

                    ConexionBD.CerrarConexion();
                    /////////////////////////////////////////////////////////
                    ConexionBD.AbrirConexion();


                    string con = String.Format("UPDATE celdas SET ocupacion = ocupacion - 1 WHERE codigocelda = '{0}'", celda);


                    MySqlCommand com = new MySqlCommand(con, ConexionBD.Conexion);
                    com.ExecuteNonQuery();

                    ConexionBD.CerrarConexion();
                    ///////////////////////////////////////////
                    return retorno;



                }
                catch (Exception ex)
                {
                    ConexionBD.CerrarConexion();

                    MessageBox.Show(ex.Message);
                }
                ConexionBD.CerrarConexion();


            }
            return retorno;
        }

        public static int EditarPreso(string ni,string nom, string ap, int crim, string sex, string dir, int cod,string corr, int cel, int tel)
        {
            int retorno = -1;
            if (ConexionBD.Conexion != null)
            {

                try
                {

                    ConexionBD.AbrirConexion();


                    string consulta = String.Format("UPDATE presos SET nombre = '{1}',Apellidos = '{2}',Crimen = '{3}',Sexo = '{4}',Direccion = '{5}'," +
                        "CodigoPostal = '{6}',Correo = '{7}',Celda = '{8}',telefono = '{9}' WHERE nif='{0}' ", ni,nom,ap,crim,sex,dir,cod,corr,cel,tel); ;


                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    retorno = comando.ExecuteNonQuery();

                    ConexionBD.CerrarConexion();
                    return retorno;



                }
                catch (Exception ex)
                {
                    ConexionBD.CerrarConexion();

                    MessageBox.Show(ex.Message);
                }
                ConexionBD.CerrarConexion();


            }
            return retorno;
        }

        public static List<string> MostrarModulos()
        {
            List<string> lista = new List<string>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("Select CodigoModulo from modulos;");

                MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);
                MySqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
                { 
                    // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                    while (reader.Read())
                    {


                        lista.Add(reader.GetString(0));
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
