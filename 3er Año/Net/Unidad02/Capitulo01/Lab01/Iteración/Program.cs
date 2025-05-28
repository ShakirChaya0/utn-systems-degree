using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteración
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] array = new string[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                array[i] = Console.ReadLine();
            }

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
