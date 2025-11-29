using System;

namespace Mindfulness
{
    

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {       
                    Console.Clear();
                    Console.WriteLine("Menu Options: ");
                    Console.WriteLine(" 1. Start Breathing Activity");
                    Console.WriteLine(" 2. Start Reflection Activity");
                    Console.WriteLine(" 3. Start Listing Activity");
                    Console.WriteLine(" 4. Exit");
                    Console.Write("Select an option from the menu: ");
                    string selection = Console.ReadLine();


                    // added null to avoid pointing to any objects yet
                    Activity selectedActivity = null;

                    switch (selection)
                    {
                        
                        case "1":
                            selectedActivity = new BreathingActivity();
                            break;
                        
                        case "2":
                            selectedActivity = new ReflectionActivity();
                            break;

                        case "3":
                            selectedActivity = new ListingActivity();
                            break;
                        
                        case "4":
                            Console.WriteLine("Exiting the program.");
                            return;
                    
                        default:
                            Console.WriteLine("Selection not valid. Please try again.");
                            System.Threading.Thread.Sleep(2000);
                            continue;
                            
                    }

                    if (selectedActivity != null)
                    {
                        selectedActivity.Run();
                    }
            }

        }
    }

}