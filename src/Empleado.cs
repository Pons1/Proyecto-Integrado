using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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




    }
    }

