using System;

class Program
{
    static void Main()
    {
        string name = "Advait Sharma";
        int order = 3;
        string completeNname = $"{name} the {get_ordinal(order)}";

        Console.WriteLine("complete name: " + completeNname);
    }

    static string get_ordinal(int number)
    {
        if (number <= 0)
            return number.ToString();

        switch (number % 100)
        {
            case 11:
            case 12:
            case 13:
                return number + "th";
        }

        switch (number % 10)
        {
            case 1:
                return number + "st";
            case 2:
                return number + "nd";
            case 3:
                return number + "rd";
            default:
                return number + "th";
        }
    }
}
