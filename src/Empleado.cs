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
    public class Empleado
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
        private int presente;
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
        public int Presente { get { return presente; } }

        public int Telefono { get { return telefono; } }

        public Image Foto { get { return foto; } }



        public Empleado(string Nif, string Nombre, string Apellidos, string puesto, string Sexo, string turno,  string dir,int CodigoPostal, string Correo,int pres, Image fot, int tel,string contra)
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
            this.foto = fot;
            presente = pres;
            telefono = tel;
            contraseña = contra;


        }


        public static bool EstaBorrado(string nif)
        {
            bool presente = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string consulta = String.Format("SELECT Borrado FROM empleados WHERE NIF = '{0}';", nif);

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



        public static bool EmpleadoRegistrado(string nif)
        {
            bool registrado = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string consulta = String.Format("SELECT COUNT(*) FROM empleados WHERE NIF = '{0}';", nif);

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


        public static bool VerificarPresencia(string nif)
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();

                string consulta = String.Format("SELECT presente FROM empleados WHERE nif = '{0}';", nif);

                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                object resultado = comando.ExecuteScalar();

                ConexionBD.CerrarConexion();

                return (resultado != null && Convert.ToInt32(resultado) == 1);
            }
            return false;
        }


        public static bool MarcarPresente(string nif)
        {
            bool exito = false;

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();


                    string consulta = String.Format("SELECT Presente FROM empleados WHERE NIF = '{0}';", nif);
                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        int presente = Convert.ToInt32(resultado);
                        int nuevoEstado = (presente == 1) ? 0 : 1;


                        string updateConsulta = String.Format("UPDATE empleados SET Presente = {1} WHERE NIF = '{0}';", nif, nuevoEstado);
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



        public static int EditarEmpleado(string ni, string nom, string ap, string puest,string sex, string tur,string dir, int cod, string corr, int tel)
        {
            int retorno = -1;
            if (ConexionBD.Conexion != null)
            {

                try
                {

                    ConexionBD.AbrirConexion();


                    string consulta = String.Format("UPDATE empleados SET nombre = '{1}',Apellidos = '{2}',puesto = '{3}',sexo = '{4}'," +
                        "turno = '{5}',direccion = '{6}',codigopostal = '{7}',correo = '{8}', telefono = '{9}' WHERE nif='{0}' ", ni, nom, ap, puest, sex,tur, dir, cod, corr, tel); ;


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

        public static int BorrarEmpleado(string ni)
        {
            int retorno = -1;
            if (ConexionBD.Conexion != null)
            {

                try
                {

                    ConexionBD.AbrirConexion();


                    string consulta = String.Format("Delete from empleados where nif='{0}'", ni); ;


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
                        reader.GetString(3), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(9), reader.GetString(10), reader.GetInt32(8),foto, reader.GetInt32(11), reader.GetString(4));
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
                       reader.GetString(3), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(9), reader.GetString(10), reader.GetInt32(8), foto, reader.GetInt32(11), reader.GetString(4));
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

                    string consulta = String.Format("INSERT INTO empleados (nif,nombre,apellidos,puesto,contraseña,sexo,turno,direccion,codigopostal,correo,telefono,foto,presente) VALUES " +
                        "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',@imagen,'{11}')", this.nif, this.nombre, this.apellidos,puesto, contraseña, sexo, turno,direccion, codigoPostal, correo, telefono,1);


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
                        reader.GetString(3), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(9), reader.GetString(10), reader.GetInt32(8), foto, reader.GetInt32(11), reader.GetString(4));
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
        public static Image ConsultarImagenEmpl(string ni)
        {
            Image foto = null;


            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();

                    string c = String.Format("Select foto from empleados where nif='{0}';", ni);

                    MySqlCommand com = new MySqlCommand(c, ConexionBD.Conexion);
                    object fot = com.ExecuteScalar();

                    byte[] img = (byte[])fot;
                    MemoryStream ms = new MemoryStream(img);
                    foto = Image.FromStream(ms);


                    ConexionBD.CerrarConexion();
                    ConexionBD.CerrarConexion();

                    return foto;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); return null;
                }

            }

            return foto;
        }
    }
    }

