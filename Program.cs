using System;
using System.IO;

class Program
{
    static void Main()
    {
        string uscita = "";

        do
        {
        string filePath = ""; 
        int countline = 9;
        

        Console.Write("Inserisci il percorso del file: ");
        filePath = Console.ReadLine();
        

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 3; i < lines.Length; i += 4)
            {
                    string Riga = lines[countline];
                    if (Riga.Length >= 12)
                    {
                        string caratteri = Riga.Substring(0, 12);
                        countline = countline - 4;
                        string activeline = lines[countline];
                        activeline = activeline.Substring(0, activeline.Length - 12);

                        lines[countline] = activeline + caratteri;
                        Console.WriteLine($"Ho corretto la riga: {countline+1}");
                        File.WriteAllLines(filePath, lines);
                    }
                    else
                    Console.WriteLine($"Controlla! C'è un errore alla riga: {countline + 1}");

                countline = countline + 8;
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine("Errore apertura file oppure ho terminato le linee da correggere!");
        }

        Console.Write("Premi ''y'' e invio per ricominciare premi invio per uscire");
            uscita = Console.ReadLine();

        } while (uscita == "y") ;

    }
}