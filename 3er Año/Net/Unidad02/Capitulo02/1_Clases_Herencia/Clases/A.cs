using System;

namespace Clases
{
    public class A
    {
        protected string nombreInstancia { get; }
        
        public A()
        {
            nombreInstancia = "Instancia sin nombre";
        }

        public A(string nombre)
        {
            nombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine("Nombre de la instancia: " + nombreInstancia);
        }
        public void M1()
        {
            Console.WriteLine("Método M1 fue invocado.");
        }

        public void M2()
        {
            Console.WriteLine("Método M2 fue invocado.");
        }

        public void M3()
        {
            Console.WriteLine("Método M3 fue invocado.");
        }
    }
}
