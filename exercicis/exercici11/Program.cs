namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        // Demanar el nom d'usuari
        Console.Write("Introdueix el nom d'usuari: ");
        string? nomUsuari = Console.ReadLine();
        
        // Demanar el domini
        Console.Write("Introdueix el domini: ");
        string? domini = Console.ReadLine();
        
        // Mostrar l'adreça de correu
        Console.WriteLine($"La teva adreça de correu és: {nomUsuari}@{domini}");
    }
}
