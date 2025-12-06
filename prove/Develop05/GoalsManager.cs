using System;
using System.ComponentModel.DataAnnotations;

namespace EternalQuest
{
    public abstract class GoalsManager : Goal
    {
        private List<Goal> _goals;
        private int _score;

        public GoalsManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        private void DisplayUserInfo()
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
        }

        private string DisplayMenu()
        {
            Console.WriteLine("Menu Options; ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option from the menu: ");
            return Console.ReadLine();

        }

        private void ListGoalNAme()
        {
            for (int i = 0; i< _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
            }
        }

        private void ListGoalsDetails()
        {
            Console.WriteLine("The goals are:");
            ListGoalNAme();
            Console.WriteLine();
        }

        private void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Siomple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to generate?");
            string typeOfGoal = Console.ReadLine();

            Console.Write("What is the name of your goal?");
            string name = Console.ReadLine();

            Console.Write("What is a short description of your goal?");
            string description = Console.ReadLine();

            Console.Write("What is the amoubnt of points associated with this goal?");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = null;

            switch (typeOfGoal)
            {
                case "1":
                    newGoal = new SimpleGoal(name, description, points, false);
                    break;
                case "2":
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be completed for a bonus?");
                    int targetAmount = int.Parse(ConsoleReadLine());

                    Console.Write("What is the bonus for completing this goal?");
                    int bonusAmount = int.Parse(ConsoleReadLine());

                    newGoal = new ChecklistGoal(name, description, points, targetAmount, bonusAmount);
                    break;
            }

            if (newGoal != null)
            {
                _goals.Add(newGoal);
            }

        }

        private void RecordEvent()
        {
            Console.WriteLine("The goals are:");
            ListGoalNAme();
            Console.WriteLine();
            Console.Write("Which goal did you complete?");
            int goalNumber = int.Parse(Console.ReadLine());

            if (goalNumber >= 0 && goalNumber < _goals.Count)
            {
                Goal goal = _goals[goalNumber];

                if (goal.IsComplete())
                {
                    Console.WriteLine("This goal is already complete.");
                }

                else
                {
                    goal.RecordEvent();
                    int pointsEarned = 0;

                    if (goal is SimpleGoal)
                    {
                        SimpleGoal simpleGoal = (SimpleGoal)goal;
                        pointsEarned = simpleGoal.GetPoints();

                    }

                    else if (goal is EternalGoal)
                    {
                        EternalGoal eternalGoal = (EternalGoal)goal;
                        pointsEarned = eternalGoal.GetPoints();
                    }

                    else if (goal is ChecklistGoal)
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        pointsEarned = checklistGoal.GetPointsForGoal();
                    }
                    _score += pointsEarned;
                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                    Console.WriteLine($"You now have {_score} points.");
                }
            }
        }


























        public void Run()
        {
            string choice = "";
            while (choice != "6")
            {
                DisplayUserInfo();
                choice = DisplayMenu();

                switch (choice)
                {
                    case "1": 
                        CreateGoal();     
                        break;
                    case "2": 
                        ListGoalsDetails();
                        break;
                    case "3": 
                        SaveGoals();
                        break;
                    case "4": 
                        LoadGoals();
                        break;
                    case "5": 
                        RecordEvent();
                        break;
                    case "6": 
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default: 
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }


    }
}