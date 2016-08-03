using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int gettingThirdNumber = n / 100;
            int gettingLastNumber = gettingThirdNumber % 10;

            if (gettingLastNumber == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", gettingLastNumber);
            }
        }
    }
}
