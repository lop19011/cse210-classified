using System;
using System.Xml.Schema;

namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction firstFraction = new Fraction();
            Fraction secondFraction = new Fraction(5);
            Fraction thirdFraction = new Fraction(3, 4);



            Console.WriteLine(firstFraction.GetFractionString());
            Console.WriteLine(firstFraction.GetDecimalValue());


            
            Console.WriteLine(secondFraction.GetFractionString());
            Console.WriteLine(secondFraction.GetDecimalValue());
            
            
            
            Console.WriteLine(thirdFraction.GetFractionString());
            Console.WriteLine(thirdFraction.GetDecimalValue());

        }
    }

}