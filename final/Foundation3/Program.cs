using System;

class Program
{
    static void Main(string[] args)

    {
        Address address1 = new Address("Paseo del Generalife 110", "Almeria", "Almeria", "Spain");

        Event e1 = new Event("Summer Party", "Summer Party in the church", "02-24-2024", "17:00", address1);
        Console.WriteLine(e1.GetStandardMessage());
        Console.WriteLine(e1.GetFullMessage());
        Console.WriteLine(e1.GetShortMessage());

        Lectures l1 = new Lectures("Lecture", "Harry Potter Lecture", "02-24-2024", "17:00", address1, "JK. Rowling", 50);
        Console.WriteLine(l1.GetStandardMessage());
        Console.WriteLine(l1.GetFullMessage());
        Console.WriteLine(l1.GetShortMessage());

        List<string> emails = new List<string>
        {
            "1. daf_171@hotmail.com",
            "2. david@ntestinc.com",
            "3. dafer171@gmail.com"
        };
        Receptions r1 = new Receptions("Reception David", "David's reception upon returning from his mission", "02-24-2024", "17:00", address1, emails);
        Console.WriteLine(r1.GetStandardMessage());
        Console.WriteLine(r1.GetFullMessage());
        Console.WriteLine(r1.GetShortMessage());

        OutdoorGatherings o1 = new OutdoorGatherings("Multi-ward colloquium talk", "Meeting outside to discuss issues concerning the use of the building and activities", "02-24-2024", "17:00", address1, "Mix of sun and clouds.");
        Console.WriteLine(o1.GetStandardMessage());
        Console.WriteLine(o1.GetFullMessage());
        Console.WriteLine(o1.GetShortMessage());
    }
}