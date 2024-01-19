public class Entry
{
    // Blank Attributes for us to reference in the main program and other classes.
    public string _date;
    public string _promptText;
    public string _entryText;

    // This is a method belonging to this class that will be used a lot to actually display our entries. 
    public void DisplayEntry()
    {
        Console.Write($"\nDate: {_date} - Prompt: {_promptText}\n{_entryText}");
    }
}