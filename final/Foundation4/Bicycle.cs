public class Bicycle : Activity
{
    private int _speed;

    public Bicycle (string date, string length, string speed) : base (date, length)
    {
        _speed = int.Parse(speed);
    }

    public override double GetDistance()
    {
        return _speed * _length;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min): Distance {GetDistance()} miles, Speed: {_speed}, Pace: {GetPace()} min per mile";
    }
}