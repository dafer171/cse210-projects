using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> actions = new List<string>
        {
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"
        };

        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        Console.WriteLine("Please select one of the following choices:");
        foreach (string action in actions)
        {
            Console.WriteLine(action);
        }

        int userSelection = 0;
        string selection = "";

        while (userSelection != 5)
        {
            Console.Write("What would you like to do? ");
            selection = Console.ReadLine();
            userSelection = int.Parse(selection);

            if (userSelection == 1)
            {
                PromptGenerator PromptGenerator = new PromptGenerator();
                string randomPromt = PromptGenerator.GetRandomPromt();
                Console.WriteLine($"{randomPromt}");

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                newEntry._promptText = randomPromt;
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();
                Console.WriteLine("Describe how you feel today: ");
                Console.Write("> ");
                newEntry._feelings = Console.ReadLine();

                journal.AddEntry(newEntry);
            }

            else if (userSelection == 2)
            {
                journal.DisplayAll();
            }

            else if (userSelection == 3)
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }

            else if (userSelection == 4)
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }

            if (userSelection != 5)
            {
                Console.WriteLine("Please select one of the following choices:");
                foreach (string action in actions)
                {
                    Console.WriteLine(action);
                }
            }
            if (userSelection == 5)
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}