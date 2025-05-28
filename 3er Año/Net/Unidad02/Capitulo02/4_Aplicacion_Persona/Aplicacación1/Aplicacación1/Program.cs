using Clases1;

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona("Franco", "Sussi", 20, 45804817);

        Console.WriteLine($"Nombre: {persona.Nombre}");
        Console.WriteLine($"Apellido: {persona.Apellido}");
        Console.WriteLine($"Edad: {persona.Edad}");
        Console.WriteLine($"DNI: {persona.DNI}");

        persona.GetFullName();
        persona.GetAge();   
    }
}