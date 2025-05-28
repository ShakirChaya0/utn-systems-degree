Dictionary<string, int> ciudades = new Dictionary<string, int>
{
    { "Rosario", 2000 },
    { "Roldán", 2102 },
    { "Funes", 2132 },
    { "Gálvez", 2252 },
    { "Santa Fe", 3000 },
    { "Córdoba", 5000 },
    { "Mendoza", 5500 },
    { "San Miguel de Tucumán", 4000 },
    { "Salta", 4400 },
    { "Neuquén", 8300 }
};
Console.Write("Ingrese letras de la ciudad que busca: ");
string ciudad = Console.ReadLine();
var busquedaParcial = from c in ciudades where c.Key.Contains(ciudad) select c;

for (int i = 0; i < busquedaParcial.Count();i++)
{
    Console.WriteLine(busquedaParcial.ElementAt(i).Value);
}