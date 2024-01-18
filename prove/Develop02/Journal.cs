using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

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

    }

    public void LoadFromFile(string file)
    {
        
    }
}