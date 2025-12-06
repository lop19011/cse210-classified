using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }

        protected string GetName()
        {
            return _shortName;
        }

        protected string GetDescription()
        {
            return _description;
        }

        protected int GetPoints()
        {
            return _points;
        }

        public abstract bool IsComplete();
        public abstract void RecordEvent();
        public abstract string GetDetailString();
        public abstract string GetStringRepresentation();


    }





}

    



