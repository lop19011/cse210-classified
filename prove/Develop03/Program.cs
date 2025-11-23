using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // This feeds in the ScriptureReference object to the Scripture object
            ScriptureReference reference = new ScriptureReference("John", 3 , 16);
            
                Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            
            while (true)
            {
                Console.Clear();
                scripture.RenderDisplay();
                Console.WriteLine();

                if (scripture.IsCompleteHidden())
                    {
                        Console.WriteLine("All words are now hidden. Great job!");
                        break;
                    }

                    
                    
                    Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
                    string input = Console.ReadLine();


                    if (input.ToLower() == "quit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    // Had to investigate investigate where to place this line

                    scripture.HideRandomWords(4);
        
                
            }   
        
        }
    }
}
