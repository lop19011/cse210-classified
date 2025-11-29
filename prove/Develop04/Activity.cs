using System;

namespace Mindfulness
{
    public abstract class Activity
    {
        private string _name;
        private string _description;
        private int _duration;
        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        protected int Duration
        {
            get { return _duration; }
        }
        public void Run()
        {
            DisplayStartingMessage();
            PerformActivity();
            DisplayEndingMessage();
        }
        protected void DisplayStartingMessage()
        {
            Console.WriteLine($"Starting {_name} Activity");
            Console.WriteLine(_description);        
            Console.WriteLine($"How many seconds would you like to do this activity for?");
            _duration = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Get ready to begin...");
            Pause(3);


        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            Pause(3);

            Console.WriteLine();
            Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
            Pause(3);

        }

        protected void Pause(int seconds)
        {
            List<string> spinner = new List<string>() { "|", "/", "-", "\\" };

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;

            while (DateTime.Now < endTime)
            {
                
                Console.Write(spinner[i]);
                Thread.Sleep(300);
                Console.Write("\b \b");
                i++;
                if (i >= spinner.Count)
                {
                    i = 0;
                }
            }

        }

        protected void CountDown(int seconds)
        {

        for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }
        
        // added abstarct method to be overridden in parent classes
        protected abstract void PerformActivity();


        

    }


}