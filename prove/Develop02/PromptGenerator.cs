public class PromptGenerator
{
    // Create an empty list of strings attached to this variable name. The list will not be initialized here but in the actual program.
    public List<string> _prompts;

    // The list being passed to this method is the list from above, but it was done in the main program.
    public string GetRandomPrompt(List<string> _newList)
    {
        // You can add any number of prompts for journal entries here, code later will accomodate for any length.
        _newList.Add("What was the most memorable part of today?");
        _newList.Add("Who did you talk to the most today?");
        _newList.Add("How satisfied were you with the events of today?");
        _newList.Add("Where did you spend most of your time today?");
        _newList.Add("What is one accomplishment today that made you feel good about yourself?");
        _newList.Add("Who was the biggest influence today on your mood and why?");
        _newList.Add("What was your favorite meal today?");
        _newList.Add("Who supported you the most during any challenges that you had today?");

        // Utilize the in house Random class to help us pick a random number
        Random _rand = new Random();
        int randomNumber = _rand.Next(0, _newList.Count() - 1);

        // Using that random number we now use it to find the index of a string in our prompt list and give it back to the main program to display.
        string _randomString = _newList[randomNumber];

        return _randomString;
    }
}