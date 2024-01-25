using System.Runtime.Serialization;

public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    Reference(string book, int chapter, int verse)
    {

    }

    Reference(string book, int chapter, int startVerse, int endVerse) 
    {

    }

    public string GetDisplayText() 
    {
        return "";
    }
}