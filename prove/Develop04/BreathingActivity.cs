public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in ...4");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b               \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Breathe in ...3");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b               \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Breathe in ...2");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b               \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Breathe in ...1");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b               \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Now breathe out ...6");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                    \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Now breathe out ...5");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                    \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Now breathe out ...4");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                    \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Now breathe out ...3");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                    \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Now breathe out ...2");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                    \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Now breathe out ...1");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                    \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }



    }


}