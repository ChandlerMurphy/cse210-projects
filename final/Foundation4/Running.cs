public class Running : Activity
{
    private int _distance;

    public Running (string date, string length, string distance) : base (date, length)
    {
        _distance = int.Parse(distance);
    }   

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min): Distance {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}