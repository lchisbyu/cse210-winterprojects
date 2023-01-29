using System;
using System.Collections.Generic;
using System.IO;

class Journal  //Methods and properties specific to the JournalEntry class go here
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry journal)
    {
        entries.Add(journal);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry._date}: {entry._title}, Entry: {entry._index}");
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._entry);

        }
    }
    public void SaveJournalToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (Entry entry in entries)
            {
                string line = $"{entry._index}|{entry._date}|{entry._title}|{entry._prompt}|{entry._entry}";
                sw.WriteLine(line);
            }
        }
    }
    public void LoadJournalFromFile(string file)
    {
        try
        {
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    Entry entry = new Entry();
                    entry._index = parts[0];
                    entry._date = parts[1];
                    entry._title = parts[2];
                    entry._prompt = parts[3];
                    entry._entry = parts[4];
                    entries.Add(entry);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
