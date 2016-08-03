using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

    
        Console.WriteLine(Factorial(n));
    }

    static BigInteger Factorial(BigInteger n)
    {

        for (BigInteger i = n - 1; i > 0; i--)
        {
            n *= i;
        }

        return n;
    }
}

