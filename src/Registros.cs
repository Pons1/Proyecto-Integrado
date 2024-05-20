using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    internal class Registros
    {
        string tipo;
        int id;
        string nombre;
        string apellidos;
        string motivo;
        DateTime fecha= DateTime.Now;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Motivo { get => motivo; set => motivo = value; }


        public Registros(string tipo, string nombre, string motivo)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.motivo = motivo;
        }
    }
}
