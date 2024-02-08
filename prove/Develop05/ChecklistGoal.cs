using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, string points, string target, string bonus) : base (name, description, points)
    {
        _target = int.Parse(target);
        _bonus = int.Parse(bonus);
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted < _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");  
            return _points;
        }
        else if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points plus a bonus of {_bonus} points for finishing your goal!");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine("You have already completed this goal, no extra points will be granted.");
            return 0;
        }
    }

    public override string IsComplete()
    {
        if (_amountCompleted >= _target)
        {

            return "X";
        }
        else 
        {
            return " ";
        }
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}