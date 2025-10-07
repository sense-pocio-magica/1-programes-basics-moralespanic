namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        // Demana la mida del costat del quadrat
        float midaCostat;
        while (true)
        {
            Console.Write("Entra la mida del costat del quadrat en centímetres: ");
            bool ok = float.TryParse(Console.ReadLine(), out midaCostat);
            if (!ok)
            {
                Console.WriteLine("\nLa mida que has introduït no és correcta. Torna-ho a intentar.\n");
            }
            else if (midaCostat < 0.0f)
            {
                Console.WriteLine("\nLa mida del costat d'un quadrat no pot ser negativa... Vols crear un forat negre o què?\n");
            }
            else
            {
                break;
            }
        }
        
        // Calcula el perímetre
        float midaPerimetre = midaCostat * 4;
        
        // Mostra el perímetre
        Console.WriteLine($"El perímetre del teu quadrat és de {midaPerimetre} cm");
    }
}
