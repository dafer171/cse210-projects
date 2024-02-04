using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> actions = new List<string>
        {
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit"
        };
        //Console.WriteLine("Menu Options: ");
        //foreach (string action in actions)
        //{
        //    Console.WriteLine(action);
        //}

        int userAction = 0;
        int duration = 0;

        Console.Clear();

        while (userAction != 4)
        {
            Console.WriteLine("\nMenu Options: ");
            foreach (string action in actions)
            {
                Console.WriteLine(action);
            }

            Console.Write("Select a choice from the menu: ");
            userAction = int.Parse(Console.ReadLine());

            Console.Clear();

            if (userAction == 1)
            {
                string name = "Breathing";
                string description = "Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n";

                Activity a1 = new Activity(name, description);
                a1.DisplayStartingMessage();

                Console.Write("How long, in seconds, would you like for your session? ");
                duration = int.Parse(Console.ReadLine());
                a1 = new Activity(name, description, duration);

                Console.Clear();
                Console.WriteLine("Get Ready...");

                a1.ShowSpinner(5);

                BreathingActivity b1 = new BreathingActivity(name, description, duration);
                b1.Run();

                Console.Clear();
                a1.ShowSpinner(5);

                a1.DisplayEndingMessage();
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (userAction == 2)
            {
                string name = "Reflecting";
                string description = "Welcome to the Reflecting Activity.\n\nThis activity will help you reflect on times in your life when you have strength and resilience. This will help you recognize the power you have and how you can use it in other aspects oy your life.\n ";
                List<string> prompts = new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless.",
                };

                List<string> questions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };

                Activity a2 = new Activity(name, description);
                a2.DisplayStartingMessage();

                Console.Write("How long, in seconds, would you like for your session? ");
                duration = int.Parse(Console.ReadLine());
                a2 = new Activity(name, description, duration);

                Console.Clear();
                Console.WriteLine("Get Ready...");

                a2.ShowSpinner(5);

                ReflectionActivity r2 = new ReflectionActivity(name, description, duration, prompts, questions);
                r2.Run();

                a2.ShowSpinner(5);

                a2.DisplayEndingMessage();
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (userAction == 3)
            {
                string name = "Listing";
                string description = "Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area\n";
                List<string> prompts = new List<string>
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };
                int count = 0;

                Activity a3 = new Activity(name, description);
                a3.DisplayStartingMessage();

                Console.Write("How long, in seconds, would you like for your session? ");
                duration = int.Parse(Console.ReadLine());
                a3 = new Activity(name, description, duration);

                Console.Clear();
                Console.WriteLine("Get Ready...");

                a3.ShowSpinner(5);

                ListingActivity l3 = new ListingActivity(name, description, duration, count, prompts);
                l3.Run();

                a3.DisplayEndingMessage();
                Thread.Sleep(2000);
                Console.Clear();
            }

        }
    }
}