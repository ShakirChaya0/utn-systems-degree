using ChayaShakir.Dominio;

List<Dispositivo> dispositivos = new List<Dispositivo>();

dispositivos.Add(new Celular("C12345NET", "Samsung", 2025, "Galaxy S25"));
dispositivos.Add(new Celular("C12347NET", "Xiaomi", 2025, "Mi 13 Pro"));
dispositivos.Add(new Celular("C12346NET", "Apple", 2025, "iPhone 16 Pro"));

Dispositivo dispositivo1 = ListaDispositivo.BuscarNroSerieLinq(dispositivos, "C12345NET");
Dispositivo dispositivo2 = ListaDispositivo.BuscarNroSerieIterativa(dispositivos, "C12345NET");


if (dispositivo1 != null) // Esto porque buscan el mismo NroSerie, si no se encuentra el dispositivo, ambos serán null. 
{
    Console.WriteLine("Dispositivo encontrado mediante LINQ: ");
    Console.WriteLine(dispositivo1.ToString());

    Console.WriteLine("\nDispositivo encontrado mediante iteraciones: ");
    Console.WriteLine(dispositivo2.ToString());
}
else
{
    Console.WriteLine("Dispositivo no encontrado.");
}

