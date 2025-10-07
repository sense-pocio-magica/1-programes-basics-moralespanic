namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        // Demanar la distància en metres
        float distanciaMetres;
        while (true)
        {
            Console.Write("Entra la distància a convertir en metres: ");
            bool ok = float.TryParse(Console.ReadLine(), out distanciaMetres);
            if (!ok)
            {
                Console.WriteLine("\nEl valor que has introduït no és correcte. Torna-ho a intentar.\n");
            }
            else if (distanciaMetres < 0.0f)
            {
                Console.WriteLine("\nNo pots introduïr valors negatius.\n");
            }
            else
            {
                break;
            }
        }
        
        // Calcular i mostrar el resultat
        float distanciaPeus = distanciaMetres * 3.28084f;
        if (distanciaPeus == 1.0f)
        {
            Console.WriteLine("El resultat és 1 peu.");
        }
        else
        {
            Console.WriteLine($"El resultat són {distanciaPeus} peus.");
        }
    }
}
