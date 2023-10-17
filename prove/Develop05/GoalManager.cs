using System;
using System.IO;




public class GoalManager
{
    //---Attributes---
    protected int _score;
    protected List<Goal> _goals;
    public int menuChoice = 0;
    public int goalChoice = 0;

    //---Constructors---
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    //---Methods---
    public void Start()
    {
        

        while (menuChoice != 6)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                CreateGoal();
            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("The goals are: ");
                for (int i = 0; i < _goals.Count; i++)
                {
                    string checkbox = (_goals[i] is EternalGoal) ? "[ ]" : _goals[i].IsComplete() ? "[X]" : "[ ]";
                    Console.WriteLine($"{i+1}. {checkbox} {_goals[i].GetShortName()} ({_goals[i].GetDescription()}) { _goals[i].GetDetailsString()}");
                }
            }
            else if (menuChoice == 3)
            {
                SaveGoals();
            }
            else if (menuChoice == 4)
            {
                LoadGoals();
            }
            else if (menuChoice == 5)
            {
                RecordEvent();
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine("Thank you for playing, goodbye.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid entry, please try again.");

            }
        }
    }

    public void DisplayPoints()
    {
    
    }

    public void ListGoalNames()
    {
        int gCount = 1;

        foreach (var goal in _goals)
        {
            if(goal is EternalGoal)
            {
                Console.WriteLine($"{gCount}. [ ] {goal.GetShortName()}");
            }
            else
            {
                string checkbox = goal.IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{gCount}. {checkbox} {goal.GetShortName()}");
                gCount++;
            }    
        }
    }

    public void ListGoalDetail()
    {
        int gCount = 1;

        foreach (var goal in _goals)
            {
                Console.WriteLine($"({goal.GetDescription()})");

                gCount++;
            }
    }

    public void CreateGoal()
    {

        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalChoice = int.Parse(Console.ReadLine());

        string name;
        string description;
        string points;

        Console.Write("What is the name of your Goal? ");
        name = Console.ReadLine();

        Console.Write("What is a short description of it?  ");
        description = Console.ReadLine();

        Console.Write("What is the point amount associated with this goal? ");
        points = Console.ReadLine();


        Goal newGoal = null;

        if (goalChoice == 1)
        {
            bool complete = false;
            newGoal = new SimpleGoal(name, description, points, complete);
        }
        else if (goalChoice == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (goalChoice == 3)
        {
            int target;
            int bonus;
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus amount for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine($"Goal {name} has been added.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");

        int goalIndex = int.Parse(Console.ReadLine()) - 1; 

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            

            if (selectedGoal is ChecklistGoal checklistGoal)
            {
                checklistGoal.RecordEvent();

                if(checklistGoal.IsComplete())
                {
                    string representation = checklistGoal.GetStringRepresentation();
                    string[] parts = representation.Split(',');

                    _score += int.Parse(parts[3]) + int.Parse(parts[5]);
                    Console.WriteLine($"Congratulations! You earned {int.Parse(parts[3])} points.");
                }
                else
                {
                    string representation = checklistGoal.GetStringRepresentation();
                    string[] parts = representation.Split(','); 

                    _score += int.Parse(parts[3]);
                    Console.WriteLine($"Congratulations! You earned {int.Parse(parts[3])} points.");
                }
                
            }
            else if (selectedGoal is EternalGoal eternalGoal)
            {
                eternalGoal.RecordEvent();

                if (eternalGoal.IsComplete())
                {
                    string representation = eternalGoal.GetStringRepresentation();
                    string[] parts = representation.Split(','); 

                    _score += int.Parse(parts[3]);
                    Console.WriteLine($"Congratulations! You earned {int.Parse(parts[3])} points.");
                }
            }
            else if (selectedGoal is SimpleGoal simpleGoal)
            {
                simpleGoal.RecordEvent();

                if (selectedGoal.IsComplete())
                {
                    string representation = simpleGoal.GetStringRepresentation();
                    string[] parts = representation.Split(',');

                    _score += int.Parse(parts[3]);
                    Console.WriteLine($"Congratulations! You earned {int.Parse(parts[3])} points.");
                }
            }
        }
    }
    
    public void SaveGoals()
    {
        Console.WriteLine("What would you like to name the file?");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");

            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        int.TryParse(lines[0], out int score);
            {
                _score = score;
            }
            

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(",");
            

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDesc = parts[2];
            string goalPoints = parts[3];


            Goal newGoal = null;
            if (goalType == "Simple Goal")
            {
                bool isComplete = bool.Parse(parts[4]);
                newGoal = new SimpleGoal(goalName, goalDesc, goalPoints, isComplete);

            }
            else if (goalType == "Eternal Goal")
            {
                newGoal = new EternalGoal(goalName, goalDesc, goalPoints);
            }
            else if (goalType == "Checklist Goal")
            {
                int target =  int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                newGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, target, bonus);
            }

            if (newGoal != null)
            {
                _goals.Add(newGoal);
            }
            
        }
        
    }
}