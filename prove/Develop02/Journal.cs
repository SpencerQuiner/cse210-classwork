public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry i in _entries)
        {
            i.Display();
            Console.WriteLine("- - - - -");
        }
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outPutFile = new StreamWriter(fileName))
        {
            foreach (Entry i in _entries)
            {
                outPutFile.WriteLine($"{i._date},{i._promptText},\"{i._entryText}\"");
                Console.WriteLine("Saving Entry to file . . . .");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        Console.WriteLine("Reading file. . . .");
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split(",");
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);
        }
    }
}

