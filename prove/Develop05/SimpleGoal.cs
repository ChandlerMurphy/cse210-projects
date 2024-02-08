public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");  
        return _points;
        }
        else
        {
        Console.WriteLine($"You have already completed this goal, no extra points will be granted.");
        return 0;
        }
    }

    public override string IsComplete()
    {
        if (_isComplete == true)
        {
            return "X";
        }
        else 
        {
            return " ";
        }
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}