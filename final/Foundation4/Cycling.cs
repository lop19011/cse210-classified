using System;

namespace Foundation4
{
    public class Cycling : Activity
    {
        private double _speed;
    

        //Constructor

        public Cycling(string date, int minutes, double speed) : base (date, minutes)
        {
            _speed = speed;
        }

        //Polymorphism
        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetDistance()
        {
            return (_speed * GetMinutes()) / 60;
        }

        public override string GetActivityType()
        {
            return "Cycling";
        }        
    }          

}


