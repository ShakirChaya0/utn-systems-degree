List<Empleado> empleados = new List<Empleado>();

while (true)
{
    Empleado empleado = new Empleado();
    empleado.id = new Random().Next(); 
    Console.Write("Ingrese el nombre del empleado: ");
    empleado.nombre = Console.ReadLine();
    Console.Write("Ingrese el sueldo del empleado: ");
    empleado.sueldo = Decimal.Parse(Console.ReadLine());
    Console.Write("Desea seguir ingresando empleados?(Si/No) ");
    string decision = Console.ReadLine().ToLower();
    empleados.Add(empleado);
    if (decision == "no")
    {
        break;
    }
}

var ordenadosAscendente = from e in empleados orderby e.sueldo ascending select e;
var ordenadosDecendete = from e in empleados orderby e.sueldo descending select e;


Console.WriteLine("Empleados ordenados de forma ascendente: ");
foreach (var emp in ordenadosAscendente)
{
    Console.WriteLine($"El sueldo de {emp.nombre} es: {emp.sueldo}");
}

Console.WriteLine("Empleados ordenados de forma decendete: ");
foreach (var emp in ordenadosDecendete)
{
    Console.WriteLine($"El sueldo de {emp.nombre} es: {emp.sueldo}");
}
class Empleado()
{
    public int id;
    public string nombre;
    public decimal sueldo;
}
