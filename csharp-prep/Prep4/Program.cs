using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int bigestNumber = 0;

        while (number != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            numbers.Add(number);
        }
        foreach (int numb in numbers)
        {
            sum += numb;
            if (bigestNumber < numb)
            {
                bigestNumber = numb;
            }
        }
        float average = ((float)sum) / (numbers.Count - 1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {bigestNumber}");
    }
}