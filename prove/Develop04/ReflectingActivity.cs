public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts = new List<string>();
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time recently where you overcame a difficult trial.");
        _prompts.Add("Think of a time you challenged yourself to learn something new.");
        _prompts.Add("Think of the last time you had to figure something out on your own.");
        _prompts.Add("Think of a time you achieved a challenging goal.");
        _prompts.Add("Remember a time where to accomplished something you thought wasn't possible for you before.");
        _prompts.Add("Think of a rewarding moment you had recently.");
        _prompts.Add("Think of a hobby that while being fun is still challenging.");
        _prompts.Add("Think of a skill you are really good at.");
        _prompts.Add("Think of a time when you felt like your best.");
        _prompts.Add("Think of a time when you made yourself proud.");
        _prompts.Add("Think of a time that you stood up for someone else.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What did you do differently this time than previously to make this happen? ");
        _questions.Add("What made this experience so memorable? ");
        _questions.Add("Why did you decide to do or participate in this event? ");
        _questions.Add("Why is this event special or important to you? ");
        _questions.Add("What are three things from this experience that you learned about yourself? ");
        _questions.Add("What strengths did you discover about yourself that you liked? ");
        _questions.Add("What is something new about yourself based on this memory that you did not know before?");
        _questions.Add("How did this time change the way you approach similar circumstances? ");
        _questions.Add("Does this thought remind you of somebody? Why? ");
        _questions.Add("What is something you would have done differently that you can apply to the future? ");
        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the future? ");
    }

    // Serves as the "main" program in this class that runs everything this specific activity should do. This isolates all bugs to how the class works within the class it is run by.
    public void Run()
    {
        // Display the starting message contained in the Activity class.
        DisplayStartingMessage();

        // Display the next messages and prompt to respond to using the DisplayPrompt() method in this class.
        DisplayPrompt();

        // Create a bit of text to fill in between the prompt page and starting up the list of questions for the user to respond to and clearing the console.
        Console.WriteLine("Now ponder on each of the following quesitons as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        // Now Display the Questions that the user can think about during the duration of the activity.
        DisplayQuestions();
        Console.Write("\n");

        // Display the ending messaged contained in the Activity class.
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random _rand = new Random();
        int _randomNumber = _rand.Next(0, _prompts.Count());
        string _randomPrompt = _prompts[_randomNumber];
        return _randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random _rand = new Random();
        int _randomNumber = _rand.Next(0, _questions.Count());
        string _randomQuestion = _questions[_randomNumber];
        return _randomQuestion;
    }

    public void DisplayPrompt()
    {
        // Give a starting message for the prompt before it is displayed.
        Console.WriteLine("Consider the following prompt: ");

        // Simplifying the process of getting a random prompt we call upon another class method
        string _randomPrompt = GetRandomPrompt();

        // Now pull from a random member of the prompt list and display it.
        Console.WriteLine($"\n --- {_randomPrompt} --- ");

        // Now give message to the user to think of the prompt and then select enter to continue
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        // Creat variables for us to make a while loop that list the questions while the timer is not up.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Make a while loop that will stop once the number of seconds passed to method have gone by.
        while (DateTime.Now < endTime)
        {
            // Displays to the user a random question for them to ponder on. 
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(10);
            Console.WriteLine("");
        }        
    }
}