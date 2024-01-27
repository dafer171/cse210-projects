using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Jhon", 3, 16);
        Scripture scripture = new Scripture(reference, "Mi madre me mima");
        //Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2);

        } while (!scripture.IsCompletelyHidden());
    }
}