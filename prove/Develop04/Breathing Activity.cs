using System;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        //I needed to use the same method with different beheavior, I found overriding and abstract commands are useful here
        protected override void PerformActivity()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(Duration);

            
            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in...");
                CountDown(4);
                Console.WriteLine();
                Console.Write("Breathe out...");
                CountDown(6);
                Console.WriteLine();

            }


        }

    }
}