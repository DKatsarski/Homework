using System;

class BitExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());


        uint[] pArray = new uint[3];
        uint[] qArray = new uint[3];
        uint result;

        for (int position = 3; position < 6; position++)
        {
            uint numberRightP = number >> position;
            pArray[position - 3] = numberRightP & 1;
        }

        for (int position = 24; position < 27; position++)
        {
            uint numberRightP = number >> position;
            qArray[position - 24] = numberRightP & 1;
        }

        for (int position = 3; position < 6; position++)
        {
            if (qArray[position - 3] == 0)                  // to 0
            {
                uint mask = (uint)(~(1 << position));
                result = number & mask;
            }
            else                                           // to 1
            {
                uint mask = (uint)(1 << position);
                result = number | mask;
            }
            number = result;
        }

        for (int position = 24; position < 27; position++)
        {
            if (pArray[position - 24] == 0)                  
            {
                uint mask = (uint)(~(1 << position));
                result = number & mask;
            }
            else                                              
            {
                uint mask = (uint)(1 << position);
                result = number | mask;
            }
            number = result;
        }


        Console.WriteLine(number);
    }
}