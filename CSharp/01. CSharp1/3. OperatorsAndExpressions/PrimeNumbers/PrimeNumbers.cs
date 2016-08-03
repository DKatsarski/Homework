using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int count = 0;
        for (int а = 1; а <= input; а++)
        {
            if (input % а == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            Console.WriteLine("true");

        }
        else
        {
            Console.WriteLine("false");
        }
    }
}