using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto: ");
            string inputTexto = Console.ReadLine();
            if (inputTexto == "") 
            {
                Console.WriteLine("El texto está vacio");
            }
            else
            {
                ConsoleKeyInfo opcion;
                do
                {
                    Console.WriteLine("1- Mostrar frase en mayúsculas");
                    Console.WriteLine("2- Mostrar frase en minúsculas");
                    Console.WriteLine("3- Mostrar cantidad de caracteres");
                    Console.WriteLine("4- Salir");
                    opcion = Console.ReadKey();
                    if (opcion.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine(inputTexto.ToUpper());
                    }
                    else if (opcion.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine(inputTexto.ToLower());
                    }
                    else if (opcion.Key == ConsoleKey.D3)
                    {
                        Console.WriteLine(inputTexto.Length);
                    }
                    else if (opcion.Key == ConsoleKey.D4)
                    { Console.WriteLine("Chau Shakira :(");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un numero correcto");
                    }
                } while (opcion.Key != ConsoleKey.D4);
            }
            Console.WriteLine("Ingrese un texto: ");
            string inputTexto2 = Console.ReadLine();

            if (inputTexto2 == "")
            {
                Console.WriteLine("El texto está vacío");
            }
            else
            {
                ConsoleKeyInfo opcion;
                do
                {
                    Console.WriteLine("\nSeleccione una opción:");
                    Console.WriteLine("1- Mostrar frase en mayúsculas");
                    Console.WriteLine("2- Mostrar frase en minúsculas");
                    Console.WriteLine("3- Mostrar cantidad de caracteres");
                    Console.WriteLine("4- Salir");

                    opcion = Console.ReadKey();
                    Console.WriteLine(); // Salto de línea después de leer la tecla

                    switch (opcion.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine(inputTexto2.ToUpper());
                            break;

                        case ConsoleKey.D2:
                            Console.WriteLine(inputTexto2.ToLower());
                            break;

                        case ConsoleKey.D3:
                            Console.WriteLine($"Cantidad de caracteres: {inputTexto2.Length}");
                            break;

                        case ConsoleKey.D4:
                            Console.WriteLine("Chau");
                            break;

                        default:
                            Console.WriteLine("Ingrese un número correcto");
                            break;
                    }

                } while (opcion.Key != ConsoleKey.D4);
            }

        }

    }
}
