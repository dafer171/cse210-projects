using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _questions;
    private List<string> _prompts;

    public ReflectionActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex];

        Console.WriteLine("\nConsider the following prompt: ");

        Console.WriteLine($"\n Prompt:\n\n --- {selectedPrompt} --- ");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they realated to this experience.");

        Console.Write("You may begin in ...3");
        Thread.Sleep(1000);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                     \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("You may begin in ...2");
        Thread.Sleep(1000);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                     \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("You may begin in ...1");
        Thread.Sleep(1000);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                     \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");

        Console.Clear();

        while (DateTime.Now < futureTime)
        {
            int randomIndex1 = random.Next(_questions.Count);
            string selectedQuestion = _questions[randomIndex1];

            Console.WriteLine($"> {selectedQuestion}"); ShowSpinner(5);
            Thread.Sleep(4000);

        }
    }
}