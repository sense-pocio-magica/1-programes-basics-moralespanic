namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        // Donar la benvinguda
        Console.WriteLine("Benvingut al generador de contrasenyes supersegures d'última generació!!!\n");
        
        // Demanar el nom
        Console.Write("Introdueix el teu nom: ");
        string? nom = Console.ReadLine();
        
        // Demanar l'any de naixement
        int anyNaixement;
        while (true)
        {
            Console.Write("Entra el teu any de naixement: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out anyNaixement);
            if (ok)
            {
                break;
            }
            Console.WriteLine("\nHas introduït un valor incorrecte. Torna-ho a intentar.\n");
        }
        
        // Mostrar la contrasenya
        Console.WriteLine($"La teva contrasenya supersegura és: {nom}{anyNaixement}");
    }
}