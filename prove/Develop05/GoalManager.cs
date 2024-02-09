using System.Security.Cryptography.X509Certificates;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager ()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        string _userInput = "0";

        while (_userInput != "6")
        {
            Console.WriteLine("\n-----------------------------------------------------\n");
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                CreateGoal();
            }
            else if (_userInput == "2")
            {
                ListGoalDetails();
            }
            else if (_userInput == "3")
            {
                SaveGoals();
            }
            else if (_userInput == "4")
            {
                LoadGoals();
            }
            else if (_userInput == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        LevelBar levelBar = new LevelBar();
        levelBar.GetLevel(_score);
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetGoalName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string _goalType = Console.ReadLine();

        if (_goalType == "1")
        {
        Console.Write("What is the name of your goal? ");
        string _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string _points = Console.ReadLine();

        SimpleGoal simpleGoal = new SimpleGoal(_name, _description, _points);
        _goals.Add(simpleGoal);

        }
        else if (_goalType == "2")
        {
        Console.Write("What is the name of your goal? ");
        string _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string _points = Console.ReadLine();

        EternalGoal eternalGoal = new EternalGoal(_name, _description, _points);
        _goals.Add(eternalGoal);

        }
        else if (_goalType == "3")
        {
        Console.Write("What is the name of your goal? ");
        string _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string _points = Console.ReadLine();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string _target = Console.ReadLine();
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string _bonus = Console.ReadLine();

        ChecklistGoal checklistGoal = new ChecklistGoal(_name, _description, _points, _target, _bonus);
        _goals.Add(checklistGoal);

        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string _listNumber = Console.ReadLine();
        int i = int.Parse(_listNumber);
        int _index = i - 1;

        Goal x = _goals[_index];
        _score = _score + x.RecordEvent();
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string _goalFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_goalFile))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string _goalFile = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_goalFile);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3], parts[4]);
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]);
                _goals.Add(checklistGoal);
            }
            else
            {
                _score = int.Parse(parts[0]);
            }
        }       
    }
}