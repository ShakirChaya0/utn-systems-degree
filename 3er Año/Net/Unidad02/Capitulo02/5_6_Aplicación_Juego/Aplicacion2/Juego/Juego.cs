using System;

namespace Clases
{
    public class Juego
    {
        private int record = 10000;

        public Juego()
        {
        }

        public void ComenzarJuego()
        {
            int numMax = PreguntarMaximo();
            JugadaConAyuda jugada = new JugadaConAyuda(numMax);

            while (!jugada.Adivino)
            {
                int intento = PreguntarNumero();
                jugada.Intentos += 1;

                if (jugada.Comparar(intento))
                {
                    Console.WriteLine("¡Adivinaste el número!");
                    Console.WriteLine($"Lo lograste en {jugada.Intentos} intento(s).");
                    CompararRecord(jugada.Intentos);
                    break;
                }
                else
                {
                    Console.WriteLine("No adivinaste. Intentá de nuevo.");
                }
            }

            if (Continuar())
            {
                ComenzarJuego();
            }
        }

        private void CompararRecord(int intentos)
        {
            if (intentos < record)
            {
                record = intentos;
                Console.WriteLine($"¡Nuevo récord! {record} intento(s).");
            }
            else
            {
                Console.WriteLine($"Tu récord sigue siendo {record} intento(s).");
            }
        }

        private bool Continuar()
        {
            Console.Write("¿Desea jugar de nuevo? Si/No: ");
            string eleccion = Console.ReadLine()?.Trim().ToLower();
            return eleccion == "si";
        }

        private int PreguntarMaximo()
        {
            while (true)
            {
                Console.Write("Ingrese el número máximo: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int resultado) && resultado > 0)
                {
                    return resultado;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero mayor que cero.");
                }
            }
        }

        private int PreguntarNumero()
        {
            while (true)
            {
                Console.Write("Adivine el número: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int resultado))
                {
                    return resultado;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                }
            }
        }
    }
}
