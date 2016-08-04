using System;

namespace MollyAndMolly
{
    class MollyAndMolly
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double r = 0;
            double condition = 0;

            if (b == 2)
            {
                r = a % c;
            }
            else if (b == 4)
            {
                r = a + c;
            }
            else if (b == 8)
            {
                r = a * c;
            }

            if (r % 4 == 0)
            {
                condition = r / 4;
            }
            else if (r % 4 != 0)
            {
                condition = r % 4;
            }
            Console.WriteLine(condition);
            Console.WriteLine(r);
        }
    }
}
