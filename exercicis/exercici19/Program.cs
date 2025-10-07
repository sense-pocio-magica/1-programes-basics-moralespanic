namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        string paraula = "macarrons";
        
        Console.WriteLine($"La paraula és: \"{paraula}\"");
        Console.WriteLine($"Nombre de caràcters: {paraula.Length}");
    }
}
