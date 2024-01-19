using System.Security.Cryptography.X509Certificates;

public class Journal
{
    // Creates a list variable containing Entry class objects, we will use this list many time throughout the program.
    public List<Entry> _entries;

    // We created a class for adding new entries to a list here so we don't have to find all instances of this feature in the future if we change the code.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // This is an additional feature of this assignement that EXCEEDS REQUIREMENTS because it allows the ability to delete entries as not specified or mentioned in the assignment details.
    // We are creating a class here for deleting old entries from a list here so we don't have to edit the text anywhere else. 
    public void DeleteEntry(int deleteIndex)
    {
        _entries.RemoveAt(deleteIndex - 1);
    }

    // This references the DisplayEntry method from the Entry class so that if we ever need to change the display method it can be done once in one class. 
    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.DisplayEntry();
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        // The file passed to us is typed in from the user and worked with here.
        string fileName = file;

        // Using SteamWriter we can have it push what data we want to a file outside of this program.
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // This loop wll go through each Entry class object (called entry) in the _entries list, and format it before passing it along to the external file that the user gives us the filename for. 
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date~~{entry._date}~~Prompt~~{entry._promptText}~~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // The file passed to us is typed in from the user and worked with here.
        string fileName = file;

        // Using the Readline functions we can read all of the file given to us into an array of lines.
        string[] lines = System.IO.File.ReadAllLines(fileName);

        // For every line in the array of lines we will do the following:
        foreach (string line in lines)
        {
            // Split each string into parts so we can sort through the data we want.
            string[] parts = line.Split("~~");

            // Because we are referencing specific attributes and methods of other classes we need to create instances of them here. 
            Journal journal = new Journal();
            journal._entries = new List<Entry>(); 
            Entry entry = new Entry();

            // With instances made we can now go ahead and assign parts of our lines (from our array of lines) to the attributes of our entry class.
            entry._date = parts[1];
            entry._promptText = parts[3];
            entry._entryText = parts[4];

            // Now simply using a method borrowed from the Journal class we add the "entry" class object (which is really an Entry class with a name) to the list of Journal Entries open in the program.
            AddEntry(entry);
        }
    }
}