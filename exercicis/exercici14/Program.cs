namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        string paraula = "pamtomata";
        
        Console.WriteLine($"Paraula: \"{paraula}\"");
        Console.WriteLine($"Primera lletra: {paraula[0]}");
        Console.WriteLine($"Lletra del mig: {paraula[(paraula.Length - 1) / 2]}");
        Console.WriteLine($"Última lletra: {paraula[paraula.Length - 1]}");
    }
}
