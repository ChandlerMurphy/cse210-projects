public class Event 
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event (string eventType, string eventTitle, string description, string date, string time, Address address) 
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void GenerateStandardDetails()
    {
        Console.WriteLine($"{_eventTitle}, {_description}");
        Console.WriteLine($"Date: {_date}, Time: {_time}, Address: {_address.GetAddress()}");
    }

    public void GenerateShortDescription()
    {
        Console.WriteLine($"{_eventType} : {_eventTitle}");
        Console.WriteLine($"Date: {_date}");
    }


}