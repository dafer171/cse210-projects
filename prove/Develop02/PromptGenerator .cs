public class PromptGenerator
{
    public List<PromptGenerator> _prompts = new List<PromptGenerator>();

    public PromptGenerator()
    {

    }

    public string GetRandomPromt()
    {
        List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the biggest challenge you overcame?",
            "Have you done something good to someone?"
        };

        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        return prompt;
    }
}

