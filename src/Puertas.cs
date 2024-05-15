using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROYECTO
{
    internal class Puertas
    {
        bool estado;

        public Puertas()
        {
        }

        public bool Estado { get { return estado; } }

        public int AbrirPuerta(int codigo, MySqlConnection conexion)
        {
            int retorno;
            string consulta = $"UPDATE estado = 0 FROM puertas WHERE CodigoPuerta = '{codigo}'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            estado = true;
            return retorno;
            
        }

        public int CerrarPuerta(int codigo, MySqlConnection conexion)
        {
            int retorno;
            string consulta = $"UPDATE estado = 1 FROM puertas WHERE CodigoPuerta = '{codigo}'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            estado = false;
            return retorno;
        }

        public bool ComprobarPuerta( int codigo, MySqlConnection conexion)
        {
            string consulta = $"SELECT estado FROM puertas WHERE CodigoPuerta = '{codigo}' AND estado = 0";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            int res = comando.ExecuteNonQuery();
            if (res!=-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }









    }

    
}
