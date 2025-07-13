


// I showed creativity by saving and loading the file in csv format.

using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Net;


class Program
{
    static void Main(string[] args)
    {
        // Instance or Object.
        Prompt myJournal = new Prompt();

        //string myJournal = new Journal();
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
            string _choice = Console.ReadLine();



            if (_choice == "1")
            {
                //vConsole.WriteLine("I love you!");
                //Console.WriteLine(selected);
                myJournal.writeEntry();
            }

            else if (_choice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (_choice == "3")
            {
                Console.Write("Enter the filename to Load: ");
                string _filename = Console.ReadLine();
                myJournal.LoadFromFile(_filename);
            }

            else if (_choice == "4")
            {
                Console.Write("Enter the file name: ");
                string _filename = Console.ReadLine();
                myJournal.SaveToFile(_filename);
            }


            else if (_choice == "5")
            {
                Console.Write("Thank you!");
                break;
            }

            else
            {
                Console.WriteLine("Please choose a correct option (i.e 1-5)!!!");
            }

        }

    }
}