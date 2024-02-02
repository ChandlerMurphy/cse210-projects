public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>();
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("What are activities that made you happy recently? ");
        _prompts.Add("What are some of your most memorable moments this week? ");
        _prompts.Add("Who has been your biggest supporter this month and why? ");
        _prompts.Add("What were some of the new places you ate out at this month that you enjoyed? ");
        _prompts.Add("Which family members did you get to visit this season? ");
        _prompts.Add("When are moments this week where you felt accomplished? ");
        _prompts.Add("Write about your silliest moments from this past week.");
        _prompts.Add("What colors do you remember seeing from today and what object or item was it? ");
        _prompts.Add("When have you tried practicing a new hobby this month? ");
        _prompts.Add("What are some new hobbies you have tried practicing this month? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are some of your personal heroes? ");
        _prompts.Add("Who are people that you have helped this week? ");
        _prompts.Add("Who are people you appreciate? ");
    }

    // Serves as the "main" program in this class that runs everything this specific activity should do. This isolates all bugs to how the class works within the class it is run by.
    public void Run()
    {
        // Display the starting message contained in the Activity class.
        DisplayStartingMessage();

        // Call upon the GetRandomPrompt() method in this class to execute the next steps of the program.
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        // Call the GetListFromUser() method to ask the user for responses and then count it.
        GetListFromUser();     

        // Now display to the user how many responses they just entered in.
        Console.WriteLine($"You listed {_count} items.");
        Console.WriteLine("");

        // Display the ending messaged contained in the Activity class.
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Random _rand = new Random();
        int _randomNumber = _rand.Next(0, _prompts.Count());
        string _randomPrompt = _prompts[_randomNumber];
        Console.WriteLine($" --- {_randomPrompt} --- ");
    }

    public void GetListFromUser()
    {
        // Now allow the user to enter data into the console to answer the question until the timer runs out.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _count = 0;

        // Make a while loop that will stop once the number of seconds passed to method have gone by.
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }     
    }
}