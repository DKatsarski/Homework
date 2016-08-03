using System;


namespace _4.PlayCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int boza = 0;
            if (input == "2")
            {
                boza = 2;   
            }
            if (input == "3")
            {
                boza = 3;
            }
            if (input == "4")
            {
                boza = 4;
            }
            if (input == "5")
            {
                boza = 5;
            }
            if (input == "6")
            {
                boza = 6;
            }
            if (input == "7")
            {
                boza = 7;
            }
            if (input == "8")
            {
                boza = 8;
            }
            if (input == "9")
            {
                boza = 9;
            }
            if (input == "10")
            {
                boza = 10;
            }
            if (input == "J")
            {
                boza = 11;
            }
            if (input == "Q")
            {
                boza = 12;
            }
            if (input == "K")
            {
                boza = 13;
            }
            if (input == "A")
            {
                boza = 14;
            }
            string[] cardDeck = new string[13];

            cardDeck[0] = "2";
            cardDeck[1] = "3";
            cardDeck[2] = "4";
            cardDeck[3] = "5";
            cardDeck[4] = "6";
            cardDeck[5] = "7";
            cardDeck[6] = "8";
            cardDeck[7] = "9";
            cardDeck[8] = "10";
            cardDeck[9] = "J";
            cardDeck[10] = "Q";
            cardDeck[11] = "K";
            cardDeck[12] = "A";
            for (int i = 0; i <= boza - 2; i++)
            {
                
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cardDeck[i]);
                
            }

        }
    }
}
