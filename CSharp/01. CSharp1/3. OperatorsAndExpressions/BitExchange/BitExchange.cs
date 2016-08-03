using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            // 1110 0110 0101
            // 0000 0000 1000

            ulong mask1 = 1 << 3;
            ulong thirdBitVariable = n & mask1;
            ulong thirdBit = thirdBitVariable >> 3;
            ulong bit24Echange = thirdBit << 24;
            if (thirdBit == 0)
            {
                ulong umask = thirdBit 
            }

            ulong mask2 = 1 << 4;
            ulong fourthBitVariable = n & mask2;
            ulong fourthBit = fourthBitVariable >> 4;
            ulong bit25Echagne = fourthBit << 25;
            
            ulong mask3 = 1 << 5;
            ulong fifthBitVariable = n & mask3;
            ulong fifthBit = fifthBitVariable >> 5;
            ulong bit26Echange = fifthBit << 26;
            
              
                                     
        }
    }
}
