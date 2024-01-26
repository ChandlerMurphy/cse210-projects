public class ScriptureGenerator 
{
    // We are declaring the whole variable list here because this does not need to change at it's current stage.
    private List<string> _scriptureList = new List<string>()
    {
        "And the church did meet together oft, to fast and to pray, and to speak one with another concerning the welfare of their souls. And they did meet together oft to partake of bread and wine, in remembrance of the Lord Jesus.",
        "And I saw that I must soon go down to my grave, having been wrought upon by the power of God that I must preach and prophesy unto this people, and declare the word according to the truth which is in Christ. And I have declared it in all my days, and have rejoiced in it above that of the world.",
        "Yea, I know that I am nothing; as to my strength I am weak; therefore I will not boast of myself, but I will boast of my God, for in his strength I can do all things; yea, behold, many mighty miracles we have wrought in this land, for which we will praise his name forever.",
        "Trust in the Lord with all thine heart and lean not on thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."
    };

    // We are declaring the whole variable list here because this does not need to change at it's current stage.
    private List<string> _referenceList = new List<string>()
    {
        "Moroni,6,5,6",
        "Enos,1,26",
        "Alma,26,12",
        "Proverbs,3,5,6",
    };

    private Reference _reference;

    // Takes a random number from the GetRandomNumber() method in this same class and uses it to return a string at that index.
    public string GetRandomScripture(int _randomIndex)
    {
        string _randomString = _scriptureList[_randomIndex];

        return _randomString;
    }

    // Takes a random number from the getRandomNumber() method in this same class and uses it to return a string at that index.
     public Reference GetRandomReference(int _randomIndex)
    {
        // Grab the reference from the _referenceList that we want to display.
        string _randomString = _referenceList[_randomIndex];

        // Split the text you have received into parts we can use to put through Reference class constructors based on their length.
        string[] _references = _randomString.Split(",");

        // Use if and else statements to determine the length of the reference we are splitting to use the right Reference Constructor.
        if (_references.Count() == 3)
        {
            string _book = _references[0];
            string _chap = _references[1];
            int _chapter = int.Parse(_chap);
            string _ver = _references[2];
            int _verse = int.Parse(_ver);
            _reference = new Reference(_book, _chapter, _verse);
        }
        else 
        {
            string _book = _references[0];
            string _chap = _references[1];
            int _chapter = int.Parse(_chap);
            string _ver = _references[2];
            int _verse = int.Parse(_ver);
            string _endVer = _references[3];
            int _endVerse = int.Parse(_endVer);
            _reference = new Reference(_book, _chapter, _verse, _endVerse);
        }
        // Return that Reference class object to the call method. 
        return _reference;
    }

    // This method gets a random number outside of the get random scripture and reference methods so that each list is random but still in sync with each other. 
    public int GetRandomNumber()
    {
        Random _rand = new Random();
        int _randomNumber = _rand.Next(0, _scriptureList.Count());
        int _randomNumber1 = _rand.Next(0, _referenceList.Count());
        return _randomNumber;
    }

}