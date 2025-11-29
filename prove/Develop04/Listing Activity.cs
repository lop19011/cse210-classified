using System;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private int _itemCount;

        
        public ListingActivity() : base("Listing", "This activity will help you relax by having you list as many responses as you can to a prompt in a certain amount of time.")
        {
            _prompts = new List<string>()
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "When have you felt the Holy Ghost this month?",
                "Who are some people you admire?"
            };
            _itemCount = 0;
        }

        protected override void PerformActivity()

        {       Console.WriteLine();
                Console.WriteLine("List as many responses as you can to the following question: ");
                Console.WriteLine($"{GetRandomPrompt()}");
                Console.WriteLine("Starting in: ");
                CountDown(5);
                Console.ReadLine();

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(Duration);

                _itemCount = 0;

                while (DateTime.Now < endTime)
                {
                    Console.Write("> ");
                    Console.ReadLine();
                    _itemCount++;

                }

                Console.WriteLine($"You listed {_itemCount} items!");

        }

        private string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];

        }
    }
    

    
}