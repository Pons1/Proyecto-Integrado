using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public string Nif { get{ return nif; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }
        public int Crimen { get { return crimen; } }
        public string Sexo { get { return sexo; } }
        public string Direccion { get { return direccion; } }
        public int CodigoPostal { get { return codigoPostal; } }
        public string Correo { get { return correo; } }
        public int Celda { get { return celda; } }

        public Preso(string Nif, string Nombre, string Apellidos, int Crimen, string Sexo, string Direccion, int CodigoPostal, string Correo, int Celda)
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
                    
                        Preso user = new Preso(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8));
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
