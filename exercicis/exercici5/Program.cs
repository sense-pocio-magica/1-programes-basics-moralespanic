namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        // Demanar el preu en euros
        string? nom;
        while (true)
        {
            Console.Write("Entra el teu nom: ");
            nom = Console.ReadLine();
            // Comprova que el nom no estigui buit
            if (!string.IsNullOrEmpty(nom) && !string.IsNullOrWhiteSpace(nom))
            {
                break;
            }
            
            Console.WriteLine("\nEl nom no pot estar buit!\n");
        }
        
        // Demanar l'edat
        int edat;
        while (true)
        {
            Console.Write("Entra la teva edat: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out edat);
            if (!ok)
            {
                Console.WriteLine("\nL'edat que has introduït és incorrecta.\n");
            } 
            else if (edat < 0)
            {
                Console.WriteLine("\nNo pots tenir una edat negativa; encara no has nascut o què?\n");
            }
            else
            {
                break;
            }
        }

        if (edat >= 100)
        {
            Console.WriteLine($"Hola {nom}! Ja tens {edat} anys! Estàs una mica gran ja... què fas jugant amb C#?");
        }
        else if (edat == 1)
        {
            Console.WriteLine($"Hola {nom}! Ja tens 1 any!");
        }
        else
        {
            Console.WriteLine($"Hola {nom}! Ja tens {edat} anys!");
        }
    }
}
