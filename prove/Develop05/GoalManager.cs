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

            }
            else if (_userInput == "4")
            {

            }
            else if (_userInput == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
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

    }

    public void LoadGoals()
    {
        
    }
}