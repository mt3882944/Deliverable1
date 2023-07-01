using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer value between 1 and 100: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.Write("Enter 'Even' or 'Odd' to specify the series: ");
            string seriesType = Console.ReadLine().ToLower();

            Console.WriteLine($"You have selected the {seriesType} series. The numbers between 0 and {userInput} are:");

            int i = 0;
            while (i <= userInput)
            {
                if ((seriesType == "even" && i % 2 == 0) || (seriesType == "odd" && i % 2 != 0))
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred.");
        }
    }
}
