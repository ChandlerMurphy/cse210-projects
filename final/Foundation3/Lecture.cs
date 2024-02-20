public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture (string eventType, string eventTitle, string description, string date, string time, Address address, string speaker, string capacity) : base(eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void GetFullDetails()
    {
        GenerateStandardDetails();
        Console.WriteLine($"Event Type: {_eventType}, Speaker Name: {_speaker}, Capacity: {_capacity}");
    }
}