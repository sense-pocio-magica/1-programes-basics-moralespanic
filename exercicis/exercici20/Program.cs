namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        int numero;
        while (true)
        {
            Console.Write("Entra el número a invertir (ha de ser positiu, i de tres xifres): ");
            bool ok = Int32.TryParse(Console.ReadLine(), out numero);

            if (!ok || Convert.ToString(numero).Length != 3 || numero < 0)
            {
                Console.WriteLine("\nHas introduït un valor invàlid. Torna-ho a intentar.\n");
            }
            else {
                break;
            }
        }
        
        // unitats: 345 % 10
        // desenes: (345 % 100) / 10
        // centenes: 345 / 100

        int centenes = numero / 100;
        int desenes = (numero % 100) / 10;
        int unitats = numero % 10;
        
        
        Console.WriteLine($"El número invertit és: {unitats}{desenes}{centenes}");
    }
}
