using System;

class BitSwap
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());


        // checks
        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("Out of range.");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("Overlapping.");
        }
        else
        {
            uint[] pArray = new uint[k];
            uint[] qArray = new uint[k];
            uint result;

            for (int position = p; position < p + k; position++)
            {
                uint numberRightP = ((uint)number) >> position;
                pArray[position - p] = numberRightP & 1;
            }

            for (int position = q; position < q + k; position++)
            {
                uint numberRightP = ((uint)number) >> position;
                qArray[position - q] = numberRightP & 1;
            }

            for (int position = p; position < p + k; position++)
            {
                if (qArray[position - p] == 0)                  // to 0
                {
                    uint mask = (uint)(~(1 << position));
                    result = ((uint)number) & mask;
                }
                else                                           // to 1
                {
                    uint mask = (uint)(1 << position);
                    result = ((uint)number) | mask;
                }
                number = result;
            }

            for (int position = q; position < q + k; position++)
            {
                if (pArray[position - q] == 0)                   // to 0
                {
                    uint mask = (uint)(~(1 << position));
                    result = ((uint)number) & mask;
                }
                else                                              // to 1
                {
                    uint mask = (uint)(1 << position);
                    result = ((uint)number) | mask;
                }
                number = result;
            }


            Console.WriteLine(number);
        }
    }
}