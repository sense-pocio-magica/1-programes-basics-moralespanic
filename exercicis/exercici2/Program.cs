namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bon dia!!! Avui endevinaré on vius!\n");
        
        // Demana el carrer
        Console.Write("Entra el carrer: ");
        string? carrer = Console.ReadLine();
        
        // Demana el número
        int numero;
        while (true)
        {
            Console.Write("Entra el numero: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out numero);
            if (ok && numero > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nEl número que has introduït no és correcte. Torna-ho a intentar.\n");
                continue;
            }
        }
        
        // Demana el codi postal
        int codiPostal;
        while (true)
        {
            Console.Write("Entra el codi postal: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out codiPostal);
            if (ok)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nEl codi postal que has introduït no és correcte. Torna-ho a intentar.\n");
                continue;
            }
        }
        
        // Demana la població
        Console.Write("Entra la població: ");
        string? poblacio = Console.ReadLine();
        
        Console.WriteLine($"\nHola, ja sé on vius! Vius al carrer {carrer}, número {numero}, a {poblacio}, {codiPostal}");
    }
}
