using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    internal class Registros
    {

        int codigoRegistro;
        string tipo;
        string nifPreso;
        string motivo;
        DateTime fechaRegistro= DateTime.Now;


        public Registros(string tipo, string nifPreso,string motivo, DateTime fechaRegistro)
        {
            this.tipo = tipo;
            this.nifPreso = nifPreso;
            this.motivo = motivo;
            this.fechaRegistro = fechaRegistro;
        }

    }
}
