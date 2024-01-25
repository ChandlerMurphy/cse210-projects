using System.Security.Cryptography.X509Certificates;

public class Scripture {

    // This variable is actually just a placeholder for the Reference class to be used in the Scripture class.
    private Reference _reference; 

    // This creates a list of Word class objects. This is what holds the scripture verse word by word. Each word is an object so we can tie propeties to each word if needed.
    private List<Word> _words;

    // This creats a counter that will help us skip over the first call to hide random scripture words.
    private int _loopCounter = 0;

    // This public constructor does most of the work for creating the scripture. It accepts the given reference object for the Reference class and the text for the scripture verse.
    public Scripture(Reference Reference, string text) 
    {
        // Set our Scripture class Reference class variable equal to the received referance object.
        _reference = Reference;

        // Create a new list of word objects called _words. 
        _words = new List<Word>();

        // Make an arrary to temporarily hold the scripture verse after we have split it by spaces.
        string [] _scriptureWords = text.Split(" ");

        // Using a loop we now go through each word in the temporary array we made.
        foreach (string word in _scriptureWords)
        {
            // Each word in the array is set to a new Word class object and then added to the end of the _words list of objects.
            _words.Add(new Word(word));
        }
    }

    // This method tells which Word objects in our list of object to hide by telling randomly assigning an index Word object the isHidden=true property.
    public void HideRandomWords(int numberToHide) 
    {
        if (_loopCounter <= 0)
        {
            _loopCounter ++;
        }
        else 
        {
            _loopCounter ++;

            Random _rand = new Random();
            int _randomIndex1 = _rand.Next(0, _words.Count());
            int _randomIndex2 = _rand.Next(0, _words.Count());
            int _randomIndex3 = _rand.Next(0, _words.Count());

            Word word1 = _words[_randomIndex1];
            word1.Hide();

            Word word2 = _words[_randomIndex2];
            word2.Hide();

            Word word3 = _words[_randomIndex3];
            word3.Hide();
        }
    }

    // We changed this method from the original design to organize the display of the text in the method rather than declared to in the main program. 
    public void GetDisplayText()
    {
        // Will write the scripture reference to the console when saved.
        Console.Write(_reference.GetDisplayText());

        // Now using a loop we can check each word object in our list of words and display them (checking visibility as we go).
        foreach (Word word in _words)
        {
            // If the word is hidden then call the Word class Hide() method to hid the word and display it.
            if (word.IsHidden())
            {
                Console.Write(word.Hide() + " ");
            }
            // If the word is not hidden then call the Word class GetDisplayText() method to display the word like normal.
            else 
            {
                Console.Write(word.GetDisplayText() + " ");
            }
        }
        // This just makes out display look nice and clean by adding whitespace to the console view.
        Console.WriteLine("\n");
    }

    // Is called to check if all the words are hidden in the program or not.
    public bool IsCommpletelyHidden()
    {
        // Create variable to hold the number of words not hidden, will check later.
        int _wordsNotHidden = 0;

        // Now go through every Word object in our list of objects and see if it is hidden or not.
        foreach (Word word in _words)
        {
            // If the word is not hidden then add it to the number of words not hidden.
            if (!word.IsHidden())
            {
                _wordsNotHidden = _wordsNotHidden + 1;
            }
        }

        // Now with a simple decision tree we can tell the program to return true if all the words are hidden or false if they are not. 
        if (_wordsNotHidden <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}