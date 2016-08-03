using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(n))
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }

    }
}

