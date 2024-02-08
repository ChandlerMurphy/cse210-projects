public abstract class Goal 
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal (string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = int.Parse(points);
    }

    public abstract int RecordEvent();

    public abstract string IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[{IsComplete()}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public virtual string GetGoalName()
    {
        return _shortName;
    }
}