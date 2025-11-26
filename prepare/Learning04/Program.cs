using System;

namespace Homework
{
    

    class Program
    {
        static void Main(string[] args)
        {

            Assignment assignment1 = new Assignment("Matthew", "English");
            Console.WriteLine(assignment1.GetSummary());



            
            MathAssignment mathAssignment1 = new MathAssignment ("Enoch", "Math", "7.3", "8-19");

            Console.WriteLine(mathAssignment1.GetSummary());
            Console.WriteLine(mathAssignment1.GetHomeworkList());


            WritingAssignment writingAssignment1 = new WritingAssignment("Eve", "Spanish", "Nouns and Pronouns");
            Console.WriteLine(writingAssignment1.GetSummary());
            Console.WriteLine(writingAssignment1.GetWritingInformation());
        }
    }

    
}