using System.Runtime.Serialization;

public class Reference {

    // Make all variables private so that only functions in our code can alter or access them.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for reference with only one verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    // Constructor for reference with more than one verse.
    public Reference(string book, int chapter, int startVerse, int endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // The Reference class has its own display method in case we ever need to change how the reference alone is displayed differently in the future.
    public string GetDisplayText() 
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}