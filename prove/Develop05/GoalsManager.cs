using System;
using System.ComponentModel.DataAnnotations;

namespace EternalQuest
{
    public class GoalsManager
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
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Select an option from the menu: ");
            return Console.ReadLine();

        }

        private void ListGoalName()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
            }
            Console.WriteLine();
        }

        private void ListGoalsDetails()
        {
            Console.WriteLine();
            Console.WriteLine("The goals are:");
            ListGoalName();
            Console.WriteLine();
        }

        private void CreateGoal()
        {
            Console.WriteLine();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.WriteLine();
            Console.Write("Which type of goal would you like to create? ");
            string typeOfGoal = Console.ReadLine();

            Console.WriteLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();


            Console.WriteLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();


            Console.WriteLine();
            Console.Write("What is the amount of points associated with this goal? ");

            int points;
            while (!int.TryParse(Console.ReadLine(), out points))
            {
                Console.Write("Invalid number. Try again: ");
            }

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
                    Console.Write("How many times does this goal need to be completed for a bonus? ");
                    int targetAmount = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for completing this goal?");
                    int bonusAmount = int.Parse(Console.ReadLine());

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
            Console.WriteLine();
            Console.WriteLine("The goals are: ");
            ListGoalName();
            Console.WriteLine();
            Console.Write("Which goal did you complete? ");
            int goalNumber = int.Parse(Console.ReadLine()) - 1;

            if (goalNumber >= 0 && goalNumber < _goals.Count)
            {
                Goal goal = _goals[goalNumber];

                if (goal.IsComplete())
                {
                    Console.WriteLine("This goal is already complete. ");
                    Console.WriteLine();
                }

                else
                {
                    goal.RecordEvent();
                    int pointsEarned = goal.GetPointsEarned();

                    _score += pointsEarned;

                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points! ");
                    Console.WriteLine($"You now have {_score} points. ");

                    /*

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
                        pointsEarned = checklistGoal.GetPointsEarned();
                    }
                    
                    
                    */
                }
            }
        }

        private void SaveGoals()
        {
            Console.WriteLine();
            Console.Write("What name you want for the saved file goals? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);

                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }





        private void LoadGoals()
        {
            Console.WriteLine();
            Console.Write("What's the name of the file you want to load? ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found!");
                return;
            }

            string[] lines = File.ReadAllLines(filename);

            if (lines.Length == 0) 
            {
                Console.WriteLine("File is empty!");
                return;
            }

            _goals.Clear();

            
            _score = int.Parse(lines[0]);

           
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                int firstColon = line.IndexOf(':');
                if (firstColon == -1)          
                {
                    Console.WriteLine($"Skipping invalid line: {line}");
                    continue;
                }

                string type = line.Substring(0, firstColon);  
                string rest = line.Substring(firstColon + 1); 

                try
                {
                    if (type == "SimpleGoal")
                    {
                        string[] parts = rest.Split(new char[] { ':' }, 4); 

                        string name = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isComplete = bool.Parse(parts[3]);

                        _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    }
                    else if (type == "EternalGoal")
                    {
                        string[] parts = rest.Split(new char[] { ':' }, 3); 

                        string name = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);

                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        string[] parts = rest.Split(new char[] { ':' }, 6); 

                        string name = parts[0];          
                        string description = parts[1];  
                        int points = int.Parse(parts[2]); 
                        int targetAmount = int.Parse(parts[3]);
                        int bonusAmount = int.Parse(parts[4]);
                        int amountCompleted = int.Parse(parts[5]);

                        _goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonusAmount, amountCompleted));
                    }
                    else
                    {
                        Console.WriteLine($"Unknown goal type: {type}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading goal from line: {line}");
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Goals Loaded Successfully.");
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
