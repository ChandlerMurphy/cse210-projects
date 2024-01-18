public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt(List<string> _newList)
    {
        _newList.Add("What was the most memorable part of today? ");
        _newList.Add("Who did you talk to the most today? ");
        _newList.Add("How satisfied were you with the events of today? ");
        _newList.Add("Where did you spend most of your time today? ");
        _newList.Add("What is one accomplishment today that made you feel good about yourself? ");
        _newList.Add("Who was the biggest influence today on your mood and why? ");
        _newList.Add("What was your favorite meal today? ");
        _newList.Add("Who supported you the most during any challenges that you had today? ");

        Random rand = new Random();
        int randomNumber = rand.Next(0, _newList.Count() - 1);
        string randomString = _newList[randomNumber];

        return randomString;
    }
}