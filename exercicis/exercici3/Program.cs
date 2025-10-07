namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string nomProducte = "Bossa de Patates Fregides";
        float preuProducte = 1.20f;
        string proveidorProducte = "Gros Mercat";
        bool estatEstocProducte = false;

        Console.WriteLine($"Heu escollit el producte '{nomProducte}', proporcionat pel proveïdor {proveidorProducte}.");
        Console.Write($"Aquest producte costa {preuProducte}€, i ");
        
        // Està en estoc?
        Console.ForegroundColor = ConsoleColor.Black;
        if (estatEstocProducte)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("està en estoc");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("no està en estoc");
        }
        
        // Reiniciar els colors de la consola
        Console.ResetColor();
        Console.WriteLine(".");
    }
}
