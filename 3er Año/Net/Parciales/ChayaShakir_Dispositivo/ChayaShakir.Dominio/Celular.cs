using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayaShakir.Dominio
{
    public class Celular : Dispositivo
    {
        public string Modelo { get; set; }

        public Celular(string nroSerie, string marca, int anioFabricacion, string modelo) : base(nroSerie, marca, anioFabricacion)
        {
            this.Modelo = modelo;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Modelo: {Modelo}";
        }
    }
}
