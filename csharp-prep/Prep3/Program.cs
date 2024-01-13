using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.Write("What is the magic number? ");
        string answer = Console.ReadLine();
        int magicNumber = int.Parse(answer);
        */

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 20);

        Console.Write("What is yout guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        while (magicNumber != userGuess)
        {
            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is yout guess? ");
            guess = Console.ReadLine();
            userGuess = int.Parse(guess);
        }
        if (magicNumber == userGuess)
        {
            Console.WriteLine("You guessed it!");
        }
    }
}