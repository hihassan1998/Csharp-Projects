/*
* Ett windows Console Applikation som läser in uppgifter för ett antal säljare i en säljkår.
* Användaren registrerar data om säljaren (såsom namn.personnummer,distrikt,antal sålda artiklar)
* Appen använder sig av bubble sort algoritm for att sortera indata som förs in av användaren och sedan berörende på antal sålda artiklar
*läggs säljaren i olika nivå av säljare
*
*
* Begränsingar:
* Inga user konta kan registereas
* Användaren mste välja själv att visa resultat från menyn
* användaren kan bara föra in siffor som indata till antal sålda aritklar för varje säljare
* Måste välja själv att spara resultat som en .txt fil.
*
* 
* Av : Hassan Hussain
* LULEÅ TEKNISKA UNIVERSITET
* 
*/


using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.IO;

class Program
{
    private static Seller[] sellers; // Array för lagring av säljare objekt
        
    // Huvud meny/ programms start
       static void Main()
    {
        Console.WriteLine("||       Välkomen till Säljare-Regi 0.1 App       ||");
        Console.WriteLine("");
        Console.WriteLine("═════════════════════════════");
        Console.WriteLine("LULEÅ TEKNISKA UNIVERSITET");
        Console.WriteLine("Av: Hassan Hussain");
        Console.WriteLine("hashus-9");
        Console.WriteLine("Kurs: L0002B");
        Console.WriteLine("═════════════════════════════");

        int choice;
    do
    {
        Console.WriteLine("");
        Console.WriteLine("---------------------");
        Console.WriteLine("|        Meny         |");
        Console.WriteLine("---------------------");
        Console.WriteLine("");
        Console.WriteLine("Välj vad do vill göra:\n");
        Console.WriteLine("1. Börja registerera säljare");
        Console.WriteLine("2. Se resultat eller spara resultat");
        Console.WriteLine("3. Gör en ny registrering");
        Console.WriteLine("4. Avsluta Appen");
        Console.WriteLine("");
       
        Console.Write("| Välja mellan (1-4) | \n");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        // få och validera användare indata
        while (!int.TryParse(Console.ReadLine(), out choice) || choice< 1 || choice> 4)
        {
            Console.WriteLine("Ogiltig Val. Vänligen skriv ett valbar val");
        }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("");
                    Registration();
                    break;
                case 2:
                    Console.WriteLine("");
                    ViewResult();
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Gör en ny registrering");
                    Registration();
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Avslutar Appen. Hejdå");
                    Environment.Exit(0);
                    break;

            }
        } while (choice != 4);
    }

    // Ta hand om säljare registrering
    static void Registration()
    {
        Console.WriteLine("Hur många säljare vill du registerera?");
        int numSellers = int.Parse(Console.ReadLine());

        sellers = new Seller[numSellers];

        for (int i = 0; i < numSellers; i++)
        {
            Console.WriteLine($"Säljare {i + 1}");
            sellers[i] = GetSellerInfo();   // Få info av varje säljare
        }
        BubbleSort(sellers);    // sorterar säljare pga såld artiklar

        Console.WriteLine("\nRegistration Klar !\n\nTryck 2 för att visa resultat eller spara som .txt filen");
    }

    // få info till enskild säljare
    static Seller GetSellerInfo()
    {
        Console.WriteLine("Namn: ");
        string name = Console.ReadLine();

        Console.WriteLine("Personnummer: ");
        string pnr = Console.ReadLine();

        Console.WriteLine("Distrikt: ");
        string district = Console.ReadLine();

        Console.WriteLine("Antal artiklar såld: ");
        int articlesSold;
        while (!int.TryParse(Console.ReadLine(), out articlesSold))
        {
            Console.WriteLine("Ej giltigt input. Vänligen skriv in EndOfStreamException integer till 'Antal artiklar Såld'. ");
        }

        return new Seller(name, pnr, district, articlesSold);
    }

    // Implementation av Bubble Sort algorithm för att sortera säljaren i array baserad på såld artiklar
    static void BubbleSort(Seller[] sellers)
    {
        int n = sellers.Length;
        for(int i = 0; i <n -1; i++)
        {
            for (int j = 0; j < n -1; j++)
            {
                if (sellers[j].ArticlesSold > sellers[j + 1].ArticlesSold)
                {
                    Seller temp = sellers[j];
                    sellers[j] = sellers[j + 1];
                    sellers[j + 1] = temp;  
                }
            }
        }
    }

    // Visar säljaren info/indata
    class Seller
    {
        public string Name { get; }
        public string Pnr { get; }
        public string District { get; }
        public int ArticlesSold { get; }

        public Seller(string name, string pnr, string district, int articlesSold)
        {
            Name = name;
            Pnr = pnr;
            District = district;
            ArticlesSold = articlesSold;
        }
    }

    // Nivå beskriving pga såld artiklar
    static string GetLevels(int level)
    {
        if (level < 50)
        {
            return "nivå 1: under 50";
        }
        else if (level >= 50 && level <= 99)
        {
            return "nivå 2: 50-99";
        }
        else if (level >= 100 && level <= 199)
        {
            return "nivå 3: 100-199";
        }
        else if (level >= 200)
        {
            return "nivå 4: över 199";
        }
        else
        {
            return "nivå: Okänt";
        }

    }

    // visar resultat, inklusive säljare info och nivå nått av säljaren
    static void ViewResult()
    {
        Console.WriteLine("\nVisar resultat...\n");
        if (sellers == null || sellers.Length == 0)
        {
            Console.WriteLine("Inga registreringar gjorda än.\n Gör registrering först");
            return;
        }

        PrintResultsSorted(sellers, true);

        Console.WriteLine("\nVill du spara registreringar som .txt fil? (ja/nej)");
        string saveTheFile = Console.ReadLine();

        if (saveTheFile.Trim().ToLower() == "ja")
        {
            FileOfResults(sellers, true);
        }
        // else tilbaka till menyn
        
    }

    // Skriverout sorterat resultat och nivå nått av säljaren
    static void PrintResultsSorted(Seller[] sellers, bool printInfoLevel)
    {
        Console.WriteLine("Namn Persnr Distrikt Antal");

        int countLevel = 0;

        for (int i = 0; i < sellers.Length; i++)
        {
            Console.WriteLine($"{sellers[i].Name} {sellers[i].Pnr} {sellers[i].District} {sellers[i].ArticlesSold}");

            if (printInfoLevel && i < sellers.Length -1 && GetLevels(sellers[i].ArticlesSold) != GetLevels(sellers[i + 1].ArticlesSold))
            {
                countLevel++;
                Console.WriteLine($"{countLevel} säljare har nått {GetLevels(sellers[i].ArticlesSold)}");
                countLevel = 0;
            }
            else if (i == sellers.Length -1)
            {
                countLevel++;
                Console.WriteLine($"{countLevel} säljare har nått {GetLevels(sellers[i].ArticlesSold)}");
            }
            else
            {
                countLevel++;
            }
        }
    }

    // Skriverut en fil som sparas till app direktory och skriverut PATH till fil
    static void FileOfResults(Seller[] sellers, bool printInfoLevel)
    {
        string nameFile = "regiSäljare.txt";
        string pathFile = Path.Combine(Environment.CurrentDirectory, nameFile);
        try
        {
            // initial conole data sparas
            TextWriter consoleOutputOriginal = Console.Out;

            using(StreamWriter writer = new StreamWriter(pathFile))
            {
                using (StringWriter OutputConsole = new StringWriter())
                {
                    Console.SetOut(OutputConsole);

                    PrintResultsSorted(sellers, printInfoLevel);

                    string stringResult = OutputConsole.ToString();

                    writer.WriteLine(stringResult); 

                }
            }

            Console.SetOut(consoleOutputOriginal);

            Console.WriteLine($"Resultat har sparats till {pathFile}");
            Console.WriteLine("");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error förkom när filen skulle sparas till filen: {ex.Message}");
        }
    }
}