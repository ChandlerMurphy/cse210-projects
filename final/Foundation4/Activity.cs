public class Activity 
{
    protected string _date;
    protected float _length;

    public Activity (string date, string length)
    {
        _date = date;
        _length = int.Parse(length);
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}