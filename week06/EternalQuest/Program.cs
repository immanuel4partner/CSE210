// Eternal Quest Program - W06 CSE210 
// Extra features added: Leveling system and goal streak tracking

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

[DebuggerDisplay($"{nameof(GetDebuggerDisplay)}(),nq")]
class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        string input = "";
        while (input != "6")
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program\n");
            Console.WriteLine($"Current Score: {score}\n");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
            }
        } // closes while
    } // closes Main

    static void CreateGoal()
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Name: "); string name = Console.ReadLine();
        Console.Write("Description: "); string desc = Console.ReadLine();
        Console.Write("Points: "); int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1": goals.Add(new SimpleGoal(name, desc, points)); break;
            case "2": goals.Add(new EternalGoal(name, desc, points)); break;
            case "3":
                Console.Write("Target Count: "); int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: "); int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} ({goals[i].Description})");
        }
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = goals[index].RecordEvent();
        score += earned;
        Console.WriteLine($"You earned {earned} points! Total: {score}");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (Goal g in goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    static void LoadGoals()
    {
        goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] vals = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    goals.Add(new SimpleGoal(vals[0], vals[1], int.Parse(vals[2])));
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(vals[0], vals[1], int.Parse(vals[2])));
                    break;
                case "ChecklistGoal":
                    goals.Add(new ChecklistGoal(
                        vals[0], // name
                        vals[1], // description
                        int.Parse(vals[2]), // points
                        int.Parse(vals[4]), // targetCount
                        int.Parse(vals[3]), // bonus
                        int.Parse(vals[5])  // currentCount
                    ));
                    break;
            }
        }
    } // closes LoadGoals

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
} // closes Program class
