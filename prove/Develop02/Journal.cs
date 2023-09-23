using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>()
    {
        
    };


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText} - {entry._entryText}");
            }
        }
    }

    public string[] LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines($"./{filename}");
 
            return lines;
    }

}