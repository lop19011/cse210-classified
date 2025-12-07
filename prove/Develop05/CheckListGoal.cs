using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _targetAmount;
        private int _bonusAmount;

        public ChecklistGoal(string shortName, string description, int points, int targetAmount, int bonusAmount) : base(shortName, description, points)
        {
            _amountCompleted = 0;
            _targetAmount = targetAmount;
            _bonusAmount = bonusAmount;
            
        }

        // For Loading:

        public ChecklistGoal(string shortName, string description, int points, int targetAmount, int bonusAmount, int amountCompleted) : base(shortName, description, points)
        {
            _amountCompleted = amountCompleted;
            _targetAmount = targetAmount;
            _bonusAmount = bonusAmount;
            
        }

        public override void RecordEvent()
        {
            _amountCompleted = _amountCompleted + 1;
        }

        public override bool IsComplete()
        {
            if (_amountCompleted >= _targetAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

          public override int GetPointsEarned()

        {
            int points = GetPoints();

            if (_amountCompleted >= _targetAmount) 
            {
                points = points + _bonusAmount;

            } 

            return points;

        }
        

         public override string GetDetailString()
        {
            string status;

            if (IsComplete())
            {
                status = "[X]";
            }

            else
            {
                status = "[ ]";
            }

            return $"{status} {GetName()} ({GetDescription()}) >> Completed: {_amountCompleted}/{_targetAmount}";

        }

        public override string GetStringRepresentation()
        {
            return "ChecklistGoal:" + GetName() + "," + GetDescription() + "," + GetPoints() + "," + _bonusAmount + "," + _targetAmount + "," + _amountCompleted;
        }
    }


}