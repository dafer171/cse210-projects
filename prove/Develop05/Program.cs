using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> actions = new List<string>
        {
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };

        GoalManager goalManager = new GoalManager();

        int userAction = 0;

        Console.Clear();

        Console.Write($"\nYou currently have {goalManager.GetTotalPoints()} points\n");

        while (userAction != 6)
        {
            Console.WriteLine("\nMenu Options:");
            foreach (string action in actions)
            {
                Console.WriteLine(action);
            }
            Console.Write("Select a choice from the menu: ");
            userAction = int.Parse(Console.ReadLine());

            Console.Clear();

            if (userAction == 1)
            {
                goalManager.CreateGoal();
            }
            else if (userAction == 2)
            {
                goalManager.ListGoalDetails();
            }
            else if (userAction == 3)
            {
                goalManager.SaveGoals();
            }
            else if (userAction == 4)
            {
                goalManager.LoadGoals();
            }
            else if (userAction == 5)
            {
                goalManager.ListGoalNames();
                goalManager.RecordEvent();
            }

        }
    }
}