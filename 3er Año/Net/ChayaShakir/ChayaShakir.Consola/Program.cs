using ChayaShakir.Dominio;

namespace ChayaShakir.Consola
{
    class Program
    {
        static void Main()
        {
            List<Instrumento> instrumentos = new List<Instrumento>();

            instrumentos.Add(new Guitarra("Fender", 6, 2010, "Electrica"));
            instrumentos.Add(new Guitarra("Yamaha", 12, 2005, "Acústica"));

            Instrumento ins1 = ListaInstrumento.BuscarPorMarcaLINQ(instrumentos, "Fender");
            Instrumento ins2 = ListaInstrumento.BuscarPorAño(instrumentos, 2005);

            Console.WriteLine("Lista de Instrumentos con LINQ: ");
            Console.WriteLine(ins1.ToString());

            Console.WriteLine("Lista de Instrumentos con iteraciones: ");
            Console.WriteLine(ins2.ToString());
        }

    }
}