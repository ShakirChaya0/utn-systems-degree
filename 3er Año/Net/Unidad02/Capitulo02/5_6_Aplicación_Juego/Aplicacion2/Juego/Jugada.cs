using System;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clases
{
    public class Jugada
    {
        public int numero;
        public int Intentos { get; set; } = 0;
        public bool Adivino { get; protected set; } = false;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            numero = rnd.Next(1, maxNumero + 1); 
        }

        public virtual bool Comparar(int num)
        {
            Adivino = (num == numero);
            return Adivino;
        }
    }

    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int num) : base(num)
        {
            
        }
        public override bool Comparar(int num)
        {
            int diferencia = Math.Abs(numero - num);
            if (num < numero)
            {
                if (diferencia >= 100)
                    Console.WriteLine("El número ingresado es menor y está muy lejos");
                else if (diferencia <= 5)
                    Console.WriteLine("El número ingresado es menor y está muy cerca");
                else
                    Console.WriteLine("El número ingresado es menor");
            }
            else if (num > numero)
            {
                if (diferencia >= 100)
                    Console.WriteLine("El número ingresado es mayor y está muy lejos");
                else if (diferencia <= 5)
                    Console.WriteLine("El número ingresado es mayor y está muy cerca");
                else
                    Console.WriteLine("El número ingresado es mayor");
            }
            Adivino = (num == numero);
            return Adivino;
        }
    }
}
