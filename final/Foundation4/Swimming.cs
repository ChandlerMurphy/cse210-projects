public class Swimming : Activity
{
    private double _laps;
    private double _distance;

    public Swimming (string date, string length, string laps) : base (date, length)
    {
        _laps = int.Parse(laps);
    }

    public override double GetDistance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
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
        return $"{_date} Swimming ({_length} min): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}