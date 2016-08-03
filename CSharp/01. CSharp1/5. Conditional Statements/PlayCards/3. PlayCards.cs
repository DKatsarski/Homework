using System;

namespace PlayCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
           

            string two = "2";
            string tree = "3";
            string four = "4";
            string five = "5";
            string six = "6";
            string seven = "7";
            string eight = "8";
            string nine = "9";
            string ten = "10";
            string jack = "J";
            string queen = "Q";
            string king = "K";
            string ace = "A";
            if (a == two || a == tree || a == four || a == five || a == six || a == seven || a == eight || a == nine || a == ten || a == jack || a == queen || a == king || a == ace)
            {
                Console.WriteLine("yes {0}", a);
            }
            else
            {
                Console.WriteLine("no {0}", a);
            }

        }
    }
}
