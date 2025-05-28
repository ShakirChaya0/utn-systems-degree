using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiceDeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Romano();
        }
        static void Romano()
        {
            Console.Write("Ingrese un número (1 - 3999): ");
            int numero = Convert.ToInt32(Console.ReadLine());


            int[] valores = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romanos = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string numRomano = "";

            for (int i = 0; i < valores.Length; i++)
            {
                while (numero >= valores[i])
                {
                    numero -= valores[i];
                    numRomano += romanos[i];
                }
            }
            Console.WriteLine($"El número en romano es: {numRomano}");
        }

    }

}
