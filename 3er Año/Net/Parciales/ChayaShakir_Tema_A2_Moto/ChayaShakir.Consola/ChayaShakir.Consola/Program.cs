using ChayaShakir.Dominio;

namespace ChayaShakir.Consola
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            lista.Add(new Moto("123ABC", 2, 1999, "Amarillo"));
            lista.Add(new Moto("456DEF", 2, 2000, "Rojo"));
            lista.Add(new Moto("789GHI", 2, 2001, "Azul"));

            Vehiculo vehiculo1 = ListaVehiculo.BuscarPatenteLINQ(lista, "123ABC");
            Vehiculo vehiculo2 = ListaVehiculo.BuscarPatenteIterativa(lista, "123ABC");

            Console.WriteLine("El Vehiculo encontrado con LINQ es: ");
            Console.WriteLine(vehiculo1.ToString());

            Console.WriteLine("El Vehiculo encontrado con iteracion es: ");
            Console.WriteLine(vehiculo2.ToString());
        }
    }
}