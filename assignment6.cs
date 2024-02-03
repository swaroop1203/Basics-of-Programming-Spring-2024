using System;

class Program
{
    static void Main()
    {
        string name = "Advait Sharma";
        int order = 22; 
        string completeName = $"{name} the {get_ordinal(order)}";

        Console.WriteLine("complete name: " + completeName);
    }

    static string get_ordinal(int number)
    {
        if (number <= 0)
            return number.ToString();

        if ((number % 100) >= 11 && (number % 100) <= 13)
            return number + "th";

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
