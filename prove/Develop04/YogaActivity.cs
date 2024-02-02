public class YogaActivity : Activity 
{
    private List<string> _activities;

    public YogaActivity()
    {
        _name = "Yoga Activity";
        _description = "This activity will prompt you with an invite to do a yoga pose for as long as the duration is set.";

        _activities = new List<string>();
        _activities.Add("Cat Pose");
        _activities.Add("Warrior 1");
        _activities.Add("Childs Pose");
        _activities.Add("Downward Facing Dog");
        _activities.Add("Hero Pose");
        _activities.Add("Chair Pose");
        _activities.Add("Legs up the Wall");
        _activities.Add("Bridge Pose");
        _activities.Add("Eagle Pose");
    }

    public void Run()
    {
        // Displays the starting message for the program.
        DisplayStartingMessage();

        // Call the Random Activity method to get a random activity and have the user perform that activity for the duration they gave.
        GetRandomActivity();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("\n");
        Console.Write("Posing...");

        // Run the spinner until the programming is done counting
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Make a while loop that will stop once the number of seconds passed to method have gone by.
        while (DateTime.Now < endTime)
        {
            ShowSpinner(_duration);
        }    

        // Displays the ending message for the program.
        Console.WriteLine("\n");
        DisplayEndingMessage();
    }

    public void GetRandomActivity()
    {
        Console.WriteLine($"You will perform the following yoga pose for {_duration} seconds: ");
        Random _rand = new Random();
        int _randomNumber = _rand.Next(0, _activities.Count());
        string _randomActivity = _activities[_randomNumber];
        Console.WriteLine($" --- {_randomActivity} --- ");
    }


}