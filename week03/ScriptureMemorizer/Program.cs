
// I showed creativity by adding a counter to track the amount of words the user has cleared.

using System.Data;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string[] text = "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.".Split(' ');
        int words = text.Count();


        Scripture scripture = new Scripture(reference, string.Join(" ", text));

        //Initialize the counter to zero;
        int count = 0;
        // Set amount of random words to clear at a time.
        int numToHide = 3;

        

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            Console.WriteLine($"You have cleared {count} of {words} words.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine($"All words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            scripture.HideRandomWords(numToHide); // or any number you want
            count += numToHide;

        }
    }
}
