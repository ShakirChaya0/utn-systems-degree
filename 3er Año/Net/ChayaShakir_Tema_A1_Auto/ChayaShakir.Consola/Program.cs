using System;
using System.Collections.Generic;
using ChayaShakir.Dominio;

namespace ChayaShakir.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Auto("ABC111", 4, 1999, "Azul"),
                new Auto("XYZ123", 4, 2010, "Rojo"),
                new Auto("DEF456", 4, 2005, "Negro")
            };

            Vehiculo encontradoLinq = ListaVehiculo.BuscarPatenteLinq(vehiculos, "ABC111");
            Vehiculo encontradoIterativo = ListaVehiculo.BuscarPatenteIterativa(vehiculos, "ABC111");

            Console.WriteLine("Resultado con LINQ:");
            Console.WriteLine(encontradoLinq.ToString());

            Console.WriteLine("\nResultado con búsqueda iterativa:");
            Console.WriteLine(encontradoIterativo.ToString());
        }
    }
}
