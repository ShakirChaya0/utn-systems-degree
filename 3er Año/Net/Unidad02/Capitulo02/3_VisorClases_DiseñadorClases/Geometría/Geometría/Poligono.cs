using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometría
{
    public class Poligono
    {
        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperficie()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Rectangulo : Poligono
    {
        private int Base;
        private int Altura;
    }

    public class Cuadrado : Rectangulo
    {
    }
}