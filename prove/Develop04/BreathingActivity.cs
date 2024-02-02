public class BreathingActivity : Activity
{
    // Using the constructor we can set the name and description of the breathing activity directly for us to use later.
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Serves as the "main" program in this class that runs everything this specific activity should do. This isolates all bugs to how the class works within the class it is run by.
    public void Run()
    {
        // Call a method from our Super class to give the starting message. Note this method obtains user input and will pause at this step. 
        DisplayStartingMessage();

        // Make a loop that tells the user to breath in and out for the duration of the activity.
        // Begine by making the timer the loop will be set on.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Make a while loop that will stop once the number of seconds passed to method have gone by.
        while (DateTime.Now < endTime)
        {
            // Displays to the user to breathe in and displays a timer right after.
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Write("\n");

            // Displays to the user to breathe out followed by a timer.
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine("\n");
        }

        // And officially condlude the program by displaying the ending message and spinner
        DisplayEndingMessage();
    }
}