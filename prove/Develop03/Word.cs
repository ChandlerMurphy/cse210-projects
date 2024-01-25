public class Word {
    private string _text;
    private bool _isHidden;

    // Constructor buils the default variables and attributes when called.
    public Word(string text)
    {
        _text = text;
        Show();
    }

    // This method holds most of the work for hiding a Word object. It will change the text of the object to "_"'s and the _isHidden attribute to true. 
    public string Hide()
    {
        // Set the value of the hidden feature of the string to true
        _isHidden = true;

        // Create a list of strings for which we can parse the characters of our word into to change to a "_"
        List<string> characters = new List<string>();
        foreach (char x in _text)
        {
            string y = "_";
            characters.Add(y);
        }

        // Now put together all of the strings ("_") together to make the hidden word.
        _text = string.Join("", characters);

        // Return the word back to the methods caller.
        return _text;
    }

    // This method is called as a default method to assign a text object as not hidden.
    public void Show()
    {
        _isHidden = false;
    }

    // Is a method that wehn called on a word object will tell if the object is hidden or not.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // A simple method to give outside access a view of the text currently in word object.
    public string GetDisplayText()
    {
        return _text;
    }
}