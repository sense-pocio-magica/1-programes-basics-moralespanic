namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        // Demanar el nombre de minuts
        float entradaMinuts;
        while (true)
        {
            Console.Write("Entra el nombre de minuts: ");
            bool ok = float.TryParse(Console.ReadLine(), out entradaMinuts);
            if (!ok)
            {
                Console.WriteLine("\nEl valor que has introduït no és correcte. Torna-ho a intentar.\n");
            } else if (entradaMinuts < 0.0f)
            {
                Console.WriteLine("\nNo pots introduïr un valor negatiu!\n");
            // Per evitar que després llençi excepció per overflow al convertir a hores
            } else if (entradaMinuts > Int32.MaxValue)
            {
                Console.WriteLine("\nHas introduït un valor massa gran!\n");
            }
            else
            {
                break;
            }
        }
        
        /* Calcular el nombre d'hores
         (aquí podria llençar excepció per overflow, en cas de 
         no haver limitat el nombre de minuts d'entrada previament) */
        int nombreHores = Convert.ToInt32(Math.Truncate(entradaMinuts / 60));
        
        // Calcular el nombre de minuts
        int nombreMinuts = Convert.ToInt32(entradaMinuts % 60);
        
        // Mostrar el nombre d'hores
        if (nombreHores == 1)
        {
            Console.Write("Això equival a 1 hora i ");
        }
        else
        {
            Console.Write($"Això equival a {nombreHores} hores i ");
        }
        
        // Mostrar el nombre de minuts
        if (nombreMinuts == 1)
        {
            Console.WriteLine("1 minut.");
        }
        else
        {
            Console.WriteLine($"{nombreMinuts} minuts.");
        }
    }
}
