using System;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();


        int input = -1;

        while (input != 0)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            input = int.Parse(userInput);
            numbers.Add(input);
        }

        int totalSum = 0;

        foreach (int sum in numbers)
        {
            totalSum += sum;
        }

         Console.WriteLine($"The total sum of your numbers is: {totalSum}");







    }
}