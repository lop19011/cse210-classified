using System;
using System.Runtime.CompilerServices;

namespace Mindfulness
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectionActivity() : base("Reflection", "This activity will help you reflect on your thoughts and feelings. Take a moment to think ponder.")
        {
            _prompts = new List<string>()
            {
                "Think of a time when you forgave someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                
                // Took me a while figure out that I needed to put ";" at the end ...
            };
        }

        protected override void PerformActivity()
        {
            Console.WriteLine();
            Console.WriteLine("Consider the following: ");
            Console.WriteLine();
            Console.WriteLine($"{GetRandomPrompt()}");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.WriteLine("Starting in: ");
            CountDown(5);

            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine($"> {GetRandomQuestion()} ");
                Pause(10);
                Console.WriteLine();

            }

        }

        private string GetRandomPrompt()
            {
                Random random = new Random();
                int index = random.Next(_prompts.Count);
                return _prompts[index];
            }

        private string GetRandomQuestion()
        {
                Random random = new Random();
                int index = random.Next(_questions.Count);
                return _questions[index];
        }

           
    
    }

    

    
}