using System.Globalization;

namespace exercici4;

/* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
euros i li digui quin és el valor en les antigues pessetes
Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bon dia! Això és un conversor de pessetes a euros.\n");
        
        // Demanar el preu en euros
        float preuEuros;
        while (true)
        {
            Console.Write("Entra el preu del producte en euros: ");
            bool ok = float.TryParse(Console.ReadLine(), out preuEuros);
            if (ok && preuEuros >= 0.0f)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nEl preu que has introduït no és correcte. Torna-ho a intentar.\n");
                continue;
            }
        }
        
        // Convertir a pessetes
        float preuPessetes = preuEuros * 166.386f;
        
        // Mostrar el preu en pessetes
        Console.Write("El preu en pessetes és de ");
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write($"{preuPessetes} pessetes");
        Console.ResetColor();
        Console.WriteLine(".");
    }
}
