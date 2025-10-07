namespace exercici17;

/* Hi ha una secta d’adoradors dels decimals que volen que els hi feu un programa que a partir d’un nombre real, 
ex. 4.56, només ens retorni els decimals, 0,56. Als números que només tenen decimals els anomenen “nombres meravellosos”

Número lleig: 23,45
Nombre meravellós: 0,45


Número lleig: 8,5
Nombre meravellós: 0,5
*/

class Program
{
    static void Main(string[] args)
    {
        /*
            En aquest cas, treballaré amb el tipus "decimal", degut a que són més precisos que el float i double
            Ara, demanem el nombre lleig (🤮)
         */
        decimal nombreLleig;
        while (true)
        {
            Console.Write("Número lleig: ");
            bool ok = decimal.TryParse(Console.ReadLine(), out nombreLleig);

            if (ok)
            {
                break;
            }
            Console.WriteLine("\nHeu introduït un nombre lleig invàlid. Torneu-ho a intentar.\n");
        }

        // Calcular el nombre meravellós (❤️)
        decimal nombreMeravellos = nombreLleig - Convert.ToDecimal(Math.Truncate(nombreLleig));
        
        Console.WriteLine($"Nombre meravellós: {nombreMeravellos}");
    }
}
