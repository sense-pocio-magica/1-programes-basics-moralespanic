namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        // Obtenir el primer número
        int primerNumero;
        while (true)
        {
            Console.Write("Introdueix el primer número: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out primerNumero);

            if (ok)
            {
                break;
            }
            Console.WriteLine("\nEl valor que has introduït no és vàlid, torna-ho a intentar.\n");
        }
        
        // Obtenir el segon número
        int segonNumero;
        while (true)
        {
            Console.Write("Introdueix el segon número: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out segonNumero);

            if (ok)
            {
                break;
            }
            Console.WriteLine("\nEl valor que has introduït no és vàlid, torna-ho a intentar.\n");
        }
        
        // Imprimir els resultats
        // Suma
        Console.WriteLine($"{primerNumero} + {segonNumero} = {primerNumero + segonNumero}");
        // Resta
        Console.WriteLine($"{primerNumero} - {segonNumero} = {primerNumero - segonNumero}");
        // Multiplicació
        Console.WriteLine($"{primerNumero} * {segonNumero} = {primerNumero * segonNumero}");
        // Divisió
        Console.Write($"{primerNumero} * {segonNumero} = ");
        if (segonNumero != 0)
        {
            Console.WriteLine((float)(primerNumero * segonNumero));
        }
        else
        {
            Console.WriteLine("ERROR: No es pot dividir entre zero.");
        }
    }
}
