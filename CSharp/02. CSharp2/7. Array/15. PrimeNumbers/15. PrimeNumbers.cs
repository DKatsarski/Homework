using System;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long theNumber = 2;
            long count = 0;


            while ( theNumber <= n)
            {
                if (n == 2)
                {
                    break;
                }
                
                if ((theNumber % 2 != 0 && theNumber % 3 != 0 && theNumber % 5 != 0 && theNumber % 7 != 0 && theNumber % 11 != 0 && theNumber % 13 != 0 && theNumber % 17 != 0 && theNumber % 19 != 0 && theNumber % 23 != 0) || (theNumber == 3 || theNumber == 5 || theNumber == 7 || theNumber == 11 || theNumber == 13 || theNumber == 17 || theNumber == 19 ||  theNumber == 23) )
                {
                    count = theNumber;
                }
                theNumber++;
            }
            if (n == 2)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(count);
            }
         
        }
    }
}
