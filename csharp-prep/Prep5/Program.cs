using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squaredUserNumber = userNumber * userNumber;
        return squaredUserNumber;
    }

    static void DisplayResult(string userName, int squaredUserNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredUserNumber}");
    }

    static void Main()
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredUserNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredUserNumber);
    }
}