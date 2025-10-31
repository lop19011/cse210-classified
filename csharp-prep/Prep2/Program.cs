using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int userInput = int.Parse(response);

        string grade = "";

        if (userInput >= 90)
        {
            grade = "A";

            Console.WriteLine($"You got an {grade}!");
        }
        else if (userInput >= 80)
        {
            grade = "B";
            Console.WriteLine($"You got a {grade}!");
        }
        else if (userInput >= 70)
        {
            grade = "C";
            Console.WriteLine($"You got a {grade}!");
        }
        else if (userInput >= 60)
        {
            grade = "D";
            Console.WriteLine($"Oh oh, you got a {grade}");
        }
        else
        {
            grade = "F";
            Console.WriteLine($"Oh no! you got an {grade}");
        }

        if (grade == "A" || grade == "B" ||grade == "C")
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass");
        }

        


    }
}