using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayaShakir.Dominio
{
    public class Moto : Vehiculo
    {
        public string Color { get; set; }

        public Moto(string patente, int ruedas, int modelo, string color) : base(patente,ruedas, modelo)
        {
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString() + $" Color:" + Color;
        }
    }
}
