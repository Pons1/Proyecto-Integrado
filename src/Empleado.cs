using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    internal class Empleado
    {
        private string nif;
        private string nombre;
        private string apellidos;
        private string puesto;
        private string contraseña;
        private string sexo;
        private string turno;
        private string direccion;
        private int codigoPostal;
        private string correo;
        private int celda;
        private int telefono;
        private Image foto;



        public string Nif { get { return nif; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }
        public string Puesto { get { return puesto; } }
        public string Sexo { get { return sexo; } }
        public string Turno { get { return turno; } }
        public string Direccion { get { return direccion; } }
        public int CodigoPostal { get { return codigoPostal; } }
        public string Correo { get { return correo; } }
        public int Celda { get { return celda; } }
        public int Telefono { get { return telefono; } }

        public Image Foto { get { return foto; } }



        public Empleado(string Nif, string Nombre, string Apellidos, string puesto, string Sexo, string turno,  string dir,int CodigoPostal, string Correo, int Celda, Image fot, int tel,string contra)
        {
            this.nif = Nif;
            this.nombre = Nombre;
            this.apellidos = Apellidos;
            this.puesto = puesto;
            this.sexo = Sexo;
            this.turno=turno;
            this.direccion = dir;
            this.codigoPostal = CodigoPostal;
            this.correo = Correo;
            this.celda = Celda;
            this.foto = fot;
            telefono = tel;
            contraseña = contra;


        }

        public static List<string> MostrarTurnos()
        {
            List<string> lista = new List<string>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("Select turno from turnos;");

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
        public static List<Empleado> MostrarEmpleados() { 
            List<Empleado> lista = new List<Empleado>();


            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();
               

                string c = String.Format("Select * from empleados;");

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

                        Empleado user = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8), reader.GetString(9), reader.GetInt32(10), foto, reader.GetInt32(10), reader.GetString(4));
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
        public static bool ComprobarRegistro(string nom, string con)
        {

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("SELECT nombre FROM empleados WHERE puesto='ADMINISTRACION' and NIF = '{0}' and contraseña = '{1}';", nom,con);

                MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);
                object res = com.ExecuteScalar();

               
                    ConexionBD.CerrarConexion();
                if (res!=null)
                {
                    return true;

                }
                else
                {
                    return false; 
                }

                }

                // devolvemos la lista cargada con los usuarios.
                ConexionBD.CerrarConexion();
            return false;
        }
        public static List<Empleado> MostrarEmpleadosPorNombre(string nom)
        {
            List<Empleado> lista = new List<Empleado>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("SELECT * FROM empleados WHERE nombre LIKE '%{0}%';", nom);

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

                        Empleado user = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8), reader.GetString(9), reader.GetInt32(10), foto, reader.GetInt32(10), reader.GetString(4));
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
        public int AgregarEmpleado()
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

                    string consulta = String.Format("INSERT INTO empleados (nif,nombre,apellidos,puesto,contraseña,sexo,turno,direccion,codigopostal,correo,celda,telefono,foto) VALUES " +
                        "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',@imagen)", this.nif, this.nombre, this.apellidos,puesto, contraseña, sexo, turno,direccion, codigoPostal, correo, celda, telefono);


                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    comando.Parameters.AddWithValue("imagen", aByte);
                    retorno = comando.ExecuteNonQuery();

                    ConexionBD.CerrarConexion();
                    MessageBox.Show("Empleado añadido correctamente");

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
        public static List<Empleado> MostrarEmpleadosPorPuesto(string pos)
        {
            List<Empleado> lista = new List<Empleado>();

            if (ConexionBD.Conexion != null)
            {

                ConexionBD.AbrirConexion();

                string c = String.Format("SELECT * FROM empleados WHERE puesto = '{0}';", pos);

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

                        Empleado user = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8), reader.GetString(9), reader.GetInt32(10), foto, reader.GetInt32(10), reader.GetString(4));
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

