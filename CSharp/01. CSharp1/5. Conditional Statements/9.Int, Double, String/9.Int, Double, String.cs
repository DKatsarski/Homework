using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        string choice = Console.ReadLine();
        string value = Console.ReadLine();

        switch (choice)
        {
            case "integer":
                int a = int.Parse(value);
                Console.WriteLine("{0}",(a + 1));
                break;
            case "real":
                double b = double.Parse(value);
                Console.WriteLine("{0:F2}",(b + 1));
                break;
            case "text":
                Console.WriteLine("{0}", value + "*");
                break;

            default:
                break;
        }
    }
}