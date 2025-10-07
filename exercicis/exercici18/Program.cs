namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        // Demanar l'hora actual
        int horaActual;
        while (true)
        {
            Console.Write("Hora actual (en format 24h): ");
            bool ok = Int32.TryParse(Console.ReadLine(), out horaActual);

            if (!ok)
            {
                Console.WriteLine("\nSenyor rellotger, has introduït un valor invàlid. Torna-ho a intentar.\n");
            }  else if (horaActual < 0 || horaActual > 23)
            {
                Console.WriteLine("\nHas d'introduïr un valor entre 0 i 23.\n");
            }
            else
            {
                break;
            }
        }
        
        // Demanar el nombre d'hores a incrementar
        int horesAIncrementar;
        while (true)
        {
            Console.Write("Hores a incrementar: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out horesAIncrementar);

            if (!ok)
            {
                Console.WriteLine("\nSenyor rellotger, has introduït un valor invàlid. Torna-ho a intentar.\n");
            }   else if (horesAIncrementar > (Int32.MaxValue - horaActual))
            {
                Console.WriteLine("\nHas introduït un valor massa gran.\n");
            }
            else
            {
                break;
            }
        }
        
        // Preguntar si l'usuari vol l'hora en format 24h o 12h
        bool format12H;
        Console.Write("Vols el l'hora en format 24 hores (19h) o 12 hores (7 PM)? [24]/12: ");
        switch (Console.ReadLine())
        {
            case "12":
                format12H = true;
                break;
            default:
                format12H = false;
                break;
        }

        int horaCalculada;
        
        // No te sentit incrementar l'hora actual en 0...
        if (horesAIncrementar == 0)
        {
            Console.WriteLine("D'acord... et repeteixo l'hora que m'acabes de dir, ja que la vols augmentar en 0:");
            switch (format12H)
            {
                case false:
                    if (horaActual == 1)
                    {
                        Console.WriteLine("És la 1.");
                    }
                    else
                    {
                        Console.WriteLine($"Són les {horaActual}.");
                    }
                    return;
                
                case true:
                    string am_pm = (horaActual < 12) ? "AM" : "PM";
                    horaActual = horaActual % 12;
                    // Per evitar 0 AM i 0 PM
                    horaCalculada = (horaActual == 0) ? 12 : horaActual;
                    Console.WriteLine((horaActual == 1) ? $"És la 1 {am_pm}." : $"Són les {horaActual} {am_pm}.");
                    return;
            }
        }

        horaCalculada = horaActual + horesAIncrementar;
        // Per calcular mòdul, independentment de si és negatiu o positiu: ((a % n) + n) % n
        horaCalculada = ((horaCalculada % 24) + 24) % 24;
        
        switch (format12H)
        {
            // Format 24H
            case false:
                Console.WriteLine($"{MostrarHora(horesAIncrementar, horaCalculada)}.");
                break;
                
            // Format 12H
            case true:
                string am_pm = (horaCalculada < 12) ? "AM" : "PM";
                horaCalculada = horaCalculada % 12;
                // Per evitar 0 AM i 0 PM
                horaCalculada = (horaCalculada == 0) ? 12 : horaCalculada;
                Console.WriteLine($"{MostrarHora(horesAIncrementar, horaCalculada)} {am_pm}.");
                break;
        }
    }

    /* No sé... volia jugar amb mètodes
     A part que si no, hauria d'haver repetit aquest codi tant per format 24h com 12h */ 
    static string MostrarHora(int horesAIncrementar, int horaCalculada)
    {
        string output;
        
        // Construïr la primera part de l'string
        if (horesAIncrementar == 1)
        {
            output = $"D'aquí a {horesAIncrementar} hora ";
        } else if (horesAIncrementar == -1)
        {
            output = "Fa 1 hora ";
        } else if (horesAIncrementar < 0)
        {
            output = $"Fa {Math.Abs(horesAIncrementar)} hores ";
        }
        else
        {
            output = $"D'aquí a {horesAIncrementar} hores ";
        }
        
        // Construïr la segona part de l'string
        if (horesAIncrementar > 0 && horaCalculada == 1)
        {
            output += "serà la 1";
        } else if (horesAIncrementar < 0 && horaCalculada == 1)
        {
            output += "era la 1";
        }
        else if (horesAIncrementar < 0)
        {
            output += $"eren les {horaCalculada}";
        }
        else
        {
            output += $"seran les {horaCalculada}";
        }

        return output;
    }
}