List<int> lista = new List<int>();
while (true)
{
    Console.Write("Ingrese un número:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Desea seguir ingresando números?(Si/No)");
    string decision = Console.ReadLine().ToLower();
    lista.Add(num);
    if (decision == "no")
    {
        break;
    }
}

var mayoresDeVeinte = from l in lista where l > 20 select l;


foreach (int l in mayoresDeVeinte)
{
    Console.WriteLine(l);
}