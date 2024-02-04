public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        List<string> answers = new List<string>();

        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex];

        Console.WriteLine("List as many responses you can to the following prompt:");

        Console.WriteLine($"\n Prompt:\n\n --- {selectedPrompt} --- ");

        Console.Write("You may begin in ...3");
        Thread.Sleep(1000);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                     \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("You may begin in ...2");
        Thread.Sleep(1000);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                     \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("You may begin in ...1");
        Thread.Sleep(1000);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                     \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            answers.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {answers.Count} items");
        Console.ReadLine();

    }

}