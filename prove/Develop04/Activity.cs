public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
 
    }

    // Contains all the repeating elements of the starting message in just one place because every activity starts the exact same way.
    public void DisplayStartingMessage()
    {
        // Clears the console for the start up of the new activity
        Console.Clear();

        // Gives a welcom message
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");

        // Asks the user for input regarding the duration of the session.
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);

        // Clear the console to run the actuall activity now that we have all the info we need from the user
        Console.Clear();

        // Now after a new screen we can tell the user to get ready and display the spinner for them.
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");
    }

    // This serves as the ending message for every activity because they all end the same way.
    public void DisplayEndingMessage()
    {
        // Tell the user well done as an outro for the program
        Console.WriteLine("Well done!!!");

        // Show the spinner to give the user a second to compose themself.
        ShowSpinner(5);
        Console.Write("\n");
        
        // And officially condlude the program by displaying the ending message and spinner.
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(6);
    }

    public void ShowSpinner(int seconds)
    {
        // |/-\|/-\ = will be our spinner characters that we are putting in a list. We will loop through this to make the spinner!
        List<string> _spinnerStrings = new List<string>();
        _spinnerStrings.Add("|");
        _spinnerStrings.Add("/");
        _spinnerStrings.Add("-");
        _spinnerStrings.Add("\\");
        _spinnerStrings.Add("|");
        _spinnerStrings.Add("/");
        _spinnerStrings.Add("-");
        _spinnerStrings.Add("\\");

        // This sets for the current time in a variable and then also creates a variable for a future time.
        // We will use these variables later to determine how long the spinner will show for based on the seconds that we want it to run.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        // Create a counting variable for us to use in part with our loop to go through our _spinnerStrings list.
        int i = 0;

        // Make a while loop that will stop once the number of seconds passed to method have gone by.
        while (DateTime.Now < endTime)
        {
            // It may not look like it, but now this works like a foreach loop that goes through each index in our spinner list and displays it. 
            string s = _spinnerStrings[i];
            Console.Write(s);

            // This lets the symbol displayed remain on screen for a second and then it clears it
            Thread.Sleep(500);
            Console.Write("\b \b");

            // Increase the counter variable for our spinner.
            i++;

            // Create contingency for the index counter to reset so that it will always loop through itself again until the while loop timer runs out (not the list index range).
            if (i >= _spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}