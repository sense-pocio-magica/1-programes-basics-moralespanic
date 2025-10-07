namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        // Demanar la nota de pràctiques
        float notaPractiques;
        while (true)
        {
            Console.Write("Nota de pràctiques: ");
            bool ok = float.TryParse(Console.ReadLine(), out notaPractiques);

            if (!ok)
            {
                Console.WriteLine("Has introduït un valor invàlid. Torna-ho a intentar.");
            } else if (notaPractiques < 0.0f)
            {
                Console.WriteLine("El valor no pot ser negatiu!");
            }
            else
            {
                break;
            }
        }
        
        // Demanar la nota de l'examen
        float notaExamen;
        while (true)
        {
            Console.Write("Nota de l'examen: ");
            bool ok = float.TryParse(Console.ReadLine(), out notaExamen);

            if (!ok)
            {
                Console.WriteLine("Has introduït un valor invàlid. Torna-ho a intentar.");
            } else if (notaPractiques < 0.0f)
            {
                Console.WriteLine("El valor no pot ser negatiu!");
            }
            else
            {
                break;
            }
        }
        
        // Calcular la nota final
        float notaFinal = ((notaPractiques + notaExamen) / 2);
        
        // Mostrar la nota final
        Console.WriteLine($"La nota final és {notaFinal} o sigui un {Math.Round(notaFinal)}");
    }
}
