using System;

class Program
{
  public static void Main (string[] args) 
  {
        while (true)
                    {
                        DisplayMenu();

                        string choice = Console.ReadLine().Trim();
                        if (choice == "1")
                        {
                            CalculateRevenue();
                        }
                        else if (choice == "2")
                        {
                            Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please select 1 or 2.");
                        }
                    }
                }

                static void DisplayMenu()
                {
                    Console.WriteLine("\n************************************");
                    Console.WriteLine("*  The stars shine in Greenville.  *");
                    Console.WriteLine("************************************");
                    Console.WriteLine("\nPlease Enter the following number below from the following menu:");
                    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
                    Console.WriteLine("2. Exit");
                }

                static void CalculateRevenue()
                {
                    // Get the number of contestants for last year and this year
                    int lastYearContestants = GetValidContestants("Enter the number of contestants last year: ");
                    int thisYearContestants = GetValidContestants("Enter the number of contestants this year: ");

                    // Calculate revenue based on this year's contestants
                    int revenue = thisYearContestants * 25;

                    // Display results
                    Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants");
                    Console.WriteLine($"Revenue expected this year is ${revenue}");

                    // Compare the number of contestants
                    if (thisYearContestants == lastYearContestants * 2)
                    {
                        Console.WriteLine("The competition is more than twice as big this year!");
                    }
                    else if (thisYearContestants > lastYearContestants)
                    {
                        Console.WriteLine("The competition is bigger than ever!");
                    }
                    else  
                    {
                        Console.WriteLine("A tighter race this year! Come out and cast your vote!");
                    }
                }

                static int GetValidContestants(string prompt)
                {
                    int contestants;
                    while (true)
                    {
                        Console.Write(prompt);
                        string input = Console.ReadLine().Trim();
                        if (int.TryParse(input, out contestants) && contestants >= 0 && contestants <= 30)
                        {
                            return contestants;
                        }
                        Console.WriteLine("Please enter a valid number between 0 and 30.");
                    }
                }
            }
    
       