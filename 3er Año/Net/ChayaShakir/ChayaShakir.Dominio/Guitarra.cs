using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayaShakir.Dominio
{
    public class Guitarra : Instrumento
    {
        public string Tipo { get; set; }

        public Guitarra(string marca, int cuerdas, int año, string tipo) : base(marca, cuerdas, año)
        {
            Tipo = tipo;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Tipo: " + Tipo;
        }


    }
}
