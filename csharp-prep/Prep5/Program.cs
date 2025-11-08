using System;
using System.Transactions;

class Program
{
    static void Main(string[] arguments)
    {
        DisplayWelcome();

        string name = userName();
        int number = userNumber();

        int birthYear;  
        userBirthDay(out birthYear);

        double mainRootSquare = squareNumber(number);

        results(name, mainRootSquare, birthYear);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to program!");
    }

    static string userName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

         return name;
    }
    
    static int userNumber()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static void userBirthDay(out int birthYear)
    {
        Console.Write("Enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());


    }
    static double squareNumber(int number)
    {
        double rootSquare = Math.Sqrt(number);

        return rootSquare;
    }

    static void results(string name, double mainRootSquare, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {mainRootSquare}");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} this year");
    }

}