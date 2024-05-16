using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    internal class Preso
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
        public Image Foto { get { return foto; } }


        public Preso(string Nif, string Nombre, string Apellidos, int Crimen, string Sexo, string Direccion, int CodigoPostal, string Correo, int Celda, Image fot,int tel)
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
            this.foto = fot;
            telefono = tel;


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
                        byte[] img = (byte[])reader["foto"];
                        MemoryStream ms = new MemoryStream(img);
                        Image foto = Image.FromStream(ms);

                        Preso user = new Preso(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8),foto, reader.GetInt32(9));
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
                        byte[] img = (byte[])reader["foto"];
                        MemoryStream ms = new MemoryStream(img);
                        Image foto = Image.FromStream(ms);

                        Preso user = new Preso(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8),foto, reader.GetInt32(9));
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
        public int AgregarPreso()
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

                    string consulta = String.Format("INSERT INTO presos (nif,nombre,apellidos,crimen,sexo,direccion,codigopostal,correo,celda,telefono,foto) VALUES " +
                        "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',@imagen)",this.nif,this.nombre,this.apellidos, crimen, sexo, direccion, codigoPostal, correo, celda, telefono);


                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    comando.Parameters.AddWithValue("imagen", aByte);
                    retorno = comando.ExecuteNonQuery();

                    ConexionBD.CerrarConexion();
                    MessageBox.Show("Recluso añadido correctamente");

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
                        byte[] img = (byte[])reader["foto"];
                        MemoryStream ms = new MemoryStream(img);
                        Image foto = Image.FromStream(ms);

                        Preso user = new Preso(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8), foto, reader.GetInt32(9));
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


    }
}
