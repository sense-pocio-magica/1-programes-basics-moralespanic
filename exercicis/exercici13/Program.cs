namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */

class Program
{
    static void Main(string[] args)
    {
        // Demanar la data sense formatar
        Console.Write("Introdueix la data sense formatar (ex 01011999): ");
        string? dataNoFormatada = Console.ReadLine();
        
        // Formatar la data
        string dataFormatada = dataNoFormatada.Insert(2, "/");
        dataFormatada = dataFormatada.Insert(5, "/");
        
        // Mostrar la data
        Console.WriteLine($"La data és {dataFormatada}");
    }
}
