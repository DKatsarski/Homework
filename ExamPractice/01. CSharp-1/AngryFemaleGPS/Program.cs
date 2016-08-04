using System;


namespace AngryFemaleGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            long asdf = long.Parse(Console.ReadLine());
            string input = asdf.ToString();
            double resultEven = 0;
            double resultOdd = 0;
           
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '-')
                {
                    continue;
                }
                
                    if ((ch - '0') % 2 == 0)
                    {
                    ch -= '0';
                        resultEven += ch; 
                    }
                    else if (ch - '0' % 2 != 0)
                    {
                        ch -= '0';
                        resultOdd += ch;
                    }

                
                
            }
            if (resultOdd > resultEven)
            {
                Console.WriteLine("left {0}", resultOdd);
            }
            else if (resultEven > resultOdd)
            {
                Console.WriteLine("right {0}", resultEven);
            }
            else if (resultEven == resultOdd)
            {
                Console.WriteLine("straight {0}", resultEven);
            }


        }
    }
}
