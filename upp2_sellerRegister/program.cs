// using System;

// class Program
// {
//     static void Main()
//     {
//         int choice;

//         do
//         {
//             Console.WriteLine("Menu:");
//             Console.WriteLine("1. Start registration of sellers");
//             Console.WriteLine("2. See the results");
//             Console.WriteLine("3. Close the program");
//             Console.Write("Enter your choice (1-3): ");

//             while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
//             {
//                 Console.WriteLine("Invalid input. Please enter a valid choice (1-3).");
//             }

//             switch (choice)
//             {
//                 case 1:
//                     StartRegistration();
//                     break;
//                 case 2:
//                     SeeResults();
//                     break;
//                 case 3:
//                     Console.WriteLine("Exiting the program. Goodbye!");
//                     break;
//             }

//         } while (choice != 3);
//     }

    // static void StartRegistration()
    // {
    //     Console.WriteLine("How many sellers do you want to register?");
    //     int numberOfSellers = int.Parse(Console.ReadLine());

    //     Seller[] sellers = new Seller[numberOfSellers];

    //     for (int i = 0; i < numberOfSellers; i++)
    //     {
    //         Console.WriteLine($"Seller {i + 1}");
    //         sellers[i] = ReadSellerInformation();
    //     }

    //     BubbleSort(sellers);
    //     Console.WriteLine("Registration complete!\n");
    // }

    static void SeeResults()
    {
        Console.WriteLine("Showing results...\n");

        // Assume that sellers array is already populated and sorted
        // Display results on the console
        PrintSortedResults(sellers);

        // Generate a file with the same results
        GenerateResultsFile(sellers);
    }

    static void GenerateResultsFile(Seller[] sellers)
    {
        string filePath = "results.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Results:");

                foreach (var seller in sellers)
                {
                    writer.WriteLine($"{seller.Name} {seller.PersonNumber} {seller.District} {seller.SoldArticles}");
                }
            }

            Console.WriteLine($"Results have been saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while saving results to file: {ex.Message}");
        }
    }

    // static Seller ReadSellerInformation()
    // {
    //     Console.Write("Namn: ");
    //     string name = Console.ReadLine();

    //     Console.Write("Personnummer: ");
    //     string personNumber = Console.ReadLine();

    //     Console.Write("Distrikt: ");
    //     string district = Console.ReadLine();

    //     Console.Write("Antal sålda artiklar: ");
    //     int articlesSold;
    // while (!int.TryParse(Console.ReadLine(), out articlesSold))
    // {
    //     Console.WriteLine("Invalid input. Please enter a valid integer for Antal artiklar såld: ");
    // }
    //     return new Seller(name, personNumber, district, soldArticles);
    // }

    // static void BubbleSort(Seller[] sellers)
    // {
    //     int n = sellers.Length;
    //     for (int i = 0; i < n - 1; i++)
    //     {
    //         for (int j = 0; j < n - i - 1; j++)
    //         {
    //             if (sellers[j].SoldArticles > sellers[j + 1].SoldArticles)
    //             {
    //                 Seller temp = sellers[j];
    //                 sellers[j] = sellers[j + 1];
    //                 sellers[j + 1] = temp;
    //             }
    //         }
    //     }
    // }

    static void PrintSortedResults(Seller[] sellers)
    {
        int level = 1;

        for (int i = 0; i < sellers.Length; i++)
        {
            Console.WriteLine($"{sellers[i].Name} {sellers[i].PersonNumber} {sellers[i].District} {sellers[i].SoldArticles}");

            if (i < sellers.Length - 1 && sellers[i].SoldArticles != sellers[i + 1].SoldArticles)
            {
                Console.WriteLine($"{i + 1} säljare har nått nivå {level}: {GetLevelRange(level)} artiklar");
                level++;
            }
        }
    }

//     static string GetLevelRange(int level)
//     {
//         switch (level)
//         {
//             case 1:
//                 return "under 50";
//             case 2:
//                 return "50-99";
//             case 3:
//                 return "100-199";
//             case 4:
//                 return "över 199";
//             default:
//                 return "Okänt";
//         }
//     }
// }

// class Seller
// {
//     public string Name { get; }
//     public string PersonNumber { get; }
//     public string District { get; }
//     public int SoldArticles { get; }

//     public Seller(string name, string personNumber, string district, int soldArticles)
//     {
//         Name = name;
//         PersonNumber = personNumber;
//         District = district;
//         SoldArticles = soldArticles;
//     }
// }