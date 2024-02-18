/* Växel Beräknaren 1.0 - Konsolapp
 * 
 * En windows console application som beräknar hur myckey växel kunden får tillbaka eftera att föra in pris på varan och det belopp de fick.
 * Växeln visas i ett Kvitto Format och ska visa hur  mycket/många sedlar eller myntt som ska betalas.
 * 
 * BEgränsningar:
 * Om betalt belopp är mindre än pris ska varning/error skrivas på skärmen
 * Om växeln är nott ska error upkomma
 * Kan gör beräkningar på bara siffror 
 * 
 * Av: Hassan Hussain
 * Kurs : L002b
 * LULEÅ TEKNISKA UNIVERSITET
 * 
 * /*/

using System;
using System.Reflection.Metadata;
using System.Threading.Channels;

class CalculateChange
{   
    static void DisplayHeader()
    {
        Console.WriteLine("");
        Console.WriteLine("Växelberäknaren 1.0");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("LULEÅ TEKNINSKA UNIVERSITET");
        Console.WriteLine("Av: Hassan Hussain");
        Console.WriteLine("hashus-9");
        Console.WriteLine("Kurs: L0002B ");
        Console.WriteLine("-----------------------------");
    }

    static void DisplayFooter() 
    {
        Console.WriteLine("-----------------------------");
    }

    static void Main()
    {
        string userResponse;
        do 
        {
            Console.Clear();    
            DisplayHeader();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Ange Priset: ");
            decimal krprice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nAnge betalt Belopp: ");
            decimal krpaid = decimal.Parse(Console.ReadLine());

            decimal krchange = krpaid - krprice;

            if (krchange <= 0)
            {
                Console.WriteLine("\n !!!Varning !!!\n");
                Console.WriteLine("Felaktigt Belopp. Ange ett större belopp.");
            }
            else
            {
                Console.WriteLine($"Växel: {krchange:C}");

                CalculateChangeKr(krchange);

            }

            DisplayFooter();

            Console.WriteLine("\n");

            Console.WriteLine("\n");

            Console.WriteLine("Vill du göra en till beräkning? (ja/nej): ");
            userResponse = Console.ReadLine().ToLower();

        } while (userResponse == "ja");

        if (userResponse == "nej")
        {
            Console.WriteLine("Tack för att du har valt att använda Växel-Beräknare 1.0");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
    static void CalculateChangeKr (decimal krchange) 
    {
        int[] notes = { 500, 200, 100, 50, 20 };
        int[] coins = { 10, 5, 1 };

        Console.WriteLine("\n -----Växel Kvitto-----");
        Console.WriteLine("Växel i Sedlar och mynt:");

        foreach (int denomination in notes)
        {
            int count = (int)(krchange / denomination);
            if (count > 0)
            {
                Console.WriteLine($"{denomination}-kronor (Sedlar): {count}");
                krchange -= count * denomination;
            }
        }
        foreach (int denomination in coins)
        {
            int count = (int)(krchange / denomination);
            if (count > 0)
            {
                Console.WriteLine($"{denomination}-kronor (Myntt): {count}");
                krchange -= count * denomination;
            }
        }
    
    }
}