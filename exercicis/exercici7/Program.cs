namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        // Demanar la primera nota
        float nota1;
        while (true)
        {
            Console.Write("Entra la primera nota: ");
            bool ok = float.TryParse(Console.ReadLine(), out nota1);
            if (!ok)
            {
                Console.WriteLine("\nLa nota que has introduït no és correcta. Torna-ho a intentar.\n");
            }
            else if (nota1 < 0.0f)
            {
                Console.WriteLine("\nLa nota no pot ser negativa...\n");
            }
            else
            {
                break;
            }
        }
        
        // Demanar la segona nota
        float nota2;
        while (true)
        {
            Console.Write("Entra la segona nota: ");
            bool ok = float.TryParse(Console.ReadLine(), out nota2);
            if (!ok)
            {
                Console.WriteLine("\nLa nota que has introduït no és correcta. Torna-ho a intentar.\n");
            }
            else if (nota2 < 0.0f)
            {
                Console.WriteLine("\nLa nota no pot ser negativa...\n");
            }
            else
            {
                break;
            }
        }
        
        // Demanar la tercera nota
        float nota3;
        while (true)
        {
            Console.Write("Entra la tercera nota: ");
            bool ok = float.TryParse(Console.ReadLine(), out nota3);
            if (!ok)
            {
                Console.WriteLine("\nLa nota que has introduït no és correcta. Torna-ho a intentar.\n");
            }
            else if (nota3 < 0.0f)
            {
                Console.WriteLine("\nLa nota no pot ser negativa...\n");
            }
            else
            {
                break;
            }
        }
        
        // Calcula la mitjana
        float mitjana = (nota1 + nota2 + nota3) / 3;
        
        // Mostra-la
        Console.WriteLine($"\nLa mitjana és de {mitjana}.");
    }
}
