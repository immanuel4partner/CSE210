



using System.Dynamic;
using System.Net;
using System.Collections.Generic;
namespace JournalEntryNamespace
{
    public class JournalEntry
    {
        public string Prompt;
        public string Response;
        public string Date;

        public JournalEntry(string prompt, string response)
        {
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now.ToString("MM-dd-yyy");
        }

        public void Display()
        {
            Console.WriteLine("");
            Console.WriteLine($"{Date} Prompt: {Prompt}");
            Console.WriteLine($"Rresponse: {Response}");
            Console.Write("");
        }
    }
}
