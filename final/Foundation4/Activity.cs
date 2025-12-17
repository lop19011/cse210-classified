using System;

namespace Foundation4
{
    public class Activity
    {
        private string _date;
        private int _minutes;

        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public string GetDate()
        {
            return _date;
        }

        public int GetMinutes()
        {
            return _minutes;
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return (GetDistance() / _minutes) * 60;
        }
        public virtual string GetActivityType()
        {
            return "Activity";
        }

        public virtual string GetSummary()
        {
            return $"{_date} {GetActivityType()} ({_minutes} min) - Distance: {GetDistance():F1} mph, Pace: {GetSpeed():F1} min per mile";
        }
        


    }
}