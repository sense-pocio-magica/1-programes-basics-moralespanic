namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        string nom = "pAU";
        string cognom = "MorALes";
        
        Console.Write("Hola, ");
        // Escriure el nom
        Console.Write(nom.ToUpper()[0] + nom.ToLower()[1..] + " ");
        
        // Escriure el cognom (substring per variar)
        Console.WriteLine(cognom.ToUpper()[0] + cognom.ToLower().Substring(1) + "!");
    }
}
