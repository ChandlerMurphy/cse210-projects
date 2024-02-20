public class Reception : Event
{
    private string _rsvpEmail;

    public Reception (string eventType, string eventTitle, string description, string date, string time, Address address, string rsvpEmail) : base(eventType, eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void GetFullDetails()
    {
        GenerateStandardDetails();
        Console.WriteLine($"Event Type: {_eventType}. Please RSVP to: {_rsvpEmail}");
    }
}