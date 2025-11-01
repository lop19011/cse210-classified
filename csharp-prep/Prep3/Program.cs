using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A random number has been generated between 1 - 100, can you guess it?");
        Random randomNumber = new Random();
        int magic = randomNumber.Next(1, 101);

        int guess = -1;

   

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            string newGuess = Console.ReadLine();
            guess = int.Parse(newGuess);


            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }

           

        }
        if (guess == magic)
        {
            Console.WriteLine("You guessed it!");
        }


    }
}