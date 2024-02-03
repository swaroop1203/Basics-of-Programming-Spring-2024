using System;

class Program
{
    static void Main()
    {
        string name = "Sulav";

        Console.WriteLine("name before adding last name: " + name);

        string last_name = "Sharma";
        name += " " + last_name;

        Console.WriteLine("name after adding last name: " + name);
    }
}

