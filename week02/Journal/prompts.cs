
#pragma warning disable CA1050 // Declare types in namespaces
using System.IO.Enumeration;
using System.Text;
using JournalEntryNamespace;

public class Prompt
{
    public List<string> _prompt = new List<string>()
    {
        "What did I learn today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me unhappy today?",
        "What was the most important thing I accomplished today?",
        "What did I do today that increased my faith in Jesus Christ?",
        "What did I do today to imporve myself?"
    };
    //List Instance or List Object.
    public List<JournalEntry> _response = new List<JournalEntry>();

    //Write Method.
    public void writeEntry()
    {
        Random _randomGenerator = new Random();
        int _randPrompt = _randomGenerator.Next(_prompt.Count);
        string _selected = _prompt[_randPrompt];


        Console.WriteLine();
        Console.Write("Journal prompt: ");
        Console.WriteLine(_selected);
        Console.Write("Response: ");
        string _responses = Console.ReadLine();

        //Instance Or Object.
        JournalEntry _entry = new JournalEntry(_selected, _responses);
        _response.Add(_entry);
    }

    public void DisplayAll()
    {
        foreach (JournalEntry line in _response)
        {
            line.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date, Prompt, Response");

            foreach (JournalEntry entry in _response)
            {
                string _escapePrompt = entry.Prompt.Replace("\"", "\"\"");
                string _escapeResponse = entry.Response.Replace("\"", "\"\"");
                writer.WriteLine($"\"{entry.Date}\", \"{_escapePrompt}\", \"{_escapeResponse}\"");

                //writer.WriteLine($"{entry.Date} Prompt: {entry.Prompt}");
                //writer.WriteLine($"Response: {entry.Response}");
            }
        }
        Console.WriteLine($"Entries saved to {filename}");

        // You can add text to the file with the WriteLine method

        // You can use the $ and include variables just like with Console.WriteLine


    }

    public void LoadFromFile(string filename)
    {

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _response.Clear(); // Optional: clear previous entries

        string[] _lines = File.ReadAllLines(filename);

        // Skip header (first line)
        for (int i = 1; i < _lines.Length; i++)
        {
            string line = _lines[i];

            // Split by comma, handling quoted values
            string[] parts = ParseCsvLine(line);

            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string userResponse = parts[2];

                JournalEntry _entry = new JournalEntry(prompt, userResponse);
                _entry.Date = date; // override default with loaded date
                _response.Add(_entry);
            }
        }

        Console.WriteLine($"Loaded {_response.Count} entries from {filename}");
    }

    private string[] ParseCsvLine(string line)
    {
        List<string> _result = new List<string>();
        bool inQuotes = false;
        StringBuilder current = new StringBuilder();

        foreach (char c in line)
        {
            if (c == '"' && !inQuotes)
            {
                inQuotes = true;
            }
            else if (c == '"' && inQuotes)
            {
                inQuotes = false;
            }
            else if (c == ',' && !inQuotes)
            {
                _result.Add(current.ToString().Trim());
                current.Clear();
            }
            else
            {
                current.Append(c);
            }
        }

        _result.Add(current.ToString().Trim()); // last value
        return _result.ToArray();
    }


}














