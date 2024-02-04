using System;
using System.Reflection.Metadata;

class ChangeCalculator
{
    static void DisplayHeader()
    {
        CenteredWriteLine("");
        CenteredWriteLine("Växelberäknare");
        CenteredWriteLine("-------------------------------");
        CenteredWriteLine("LULEÅ TEKINSKA UNIVERSITET");
        CenteredWriteLine("Utvecklaren: Hassan Hussain");
        CenteredWriteLine("Kurs: L0002B");
        CenteredWriteLine("-------------------------------");
    }
    static void Main()
    {
        string userResponse;
        do // Loop för att programmet ska startas om, om användaren vill göra beräkning från början
        {
            DisplayHeader();

            Console.Write("Ange priset: ");     //Priset efterfrågad
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Ange betalt belopp: ");     // belopp efterfrågad
            decimal moneyGiven = decimal.Parse(Console.ReadLine());

            decimal change = moneyGiven - price;        // Beräkning av växel

            
            Console.WriteLine($"Växel: {change:C}"); // vis växel på skärmen/console

            
            CalculatedChange(change); // Växel kalkylering

            DisplayFooter();

            Console.WriteLine("\n");

            Console.Write("Vill du göra en till beräkning? (ja/nej): ");
            userResponse = Console.ReadLine().ToLower();
        } while (userResponse == "ja");

        if (userResponse == "nej")
        {
            Console.WriteLine("Tack för att du har valt att använda Växel Beräknaren");
            Console.ReadLine();
            Environment.Exit(0);

        }
    }

    static void DisplayFooter()
    {

        CenteredWriteLine("----------------------------------------");
    }

    static void CalculatedChange(decimal change)
    {
        int[] noteDenominations = { 500, 200, 100, 50, 20 };
        int[] coinDenominations = { 10, 5, 1 };

        CenteredWriteLine("--------Växel Kvitto---------");
        CenteredWriteLine("Växel i sedlar och mynt:");

        foreach (int denomination in noteDenominations)
        {
            int count = (int)(change / denomination);
            if (count > 0)
            {
                CenteredWriteLine($"{denomination}-kronor (sedel): {count}");
                change -= count * denomination;
            }
        }

        foreach (int denomination in coinDenominations)
        {
            int count = (int)(change / denomination);
            if (count > 0)
            {
                CenteredWriteLine($"{denomination}-kronor (mynt): {count}");
                change -= count * denomination;
            }
        }
        if (change < 0)
        {
            CenteredWriteLine("");
            CenteredWriteLine(" !!! VARNING !!!");
            CenteredWriteLine("");
            CenteredWriteLine("Felaktigt belopp. Ange ett större betalt belopp.");
        }
    }

    static void CenteredWriteLine(string text)
    {
        int width = Console.WindowWidth;
        int spaces = (width - text.Length) / 2;
        Console.WriteLine(new string(' ', spaces) + text);
    }
}
