using System.IO.Compression;

public class Outdoor : Event 
{
    public string _weather;

    public Outdoor (string eventType, string eventTitle, string description, string date, string time, Address address, string weather) : base(eventType, eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public void GetFullDetails()
    {
        GenerateStandardDetails();
        Console.WriteLine($"Event Type: {_eventType}, Weather: {_weather}");
    }
}