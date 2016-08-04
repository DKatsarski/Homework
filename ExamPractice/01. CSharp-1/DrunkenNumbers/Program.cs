using System;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // chara ne tqrbwa da e rawen na 0 -- eto kak da go oprawqt tozi problem - prewryshtam chisloto w int i posle pak w strin. ili naprawo w chislo i posle w string. 
            // ako razdelq .lenght / 2 i ednowremenno e > i < 
            // ako pyk e nechetno - n / 2 + 1

            long n = long.Parse(Console.ReadLine());
            long resultM = 0;
            long resultV = 0;
            if (n < 0)
            {
                n *= -1;
            }
            
    
            for (int i = 0; i < n; i++)
            {
                long drunken = long.Parse(Console.ReadLine());
                if (drunken < 0)
                {
                    drunken *= -1;
                }
             
                string drunkenNumber = Convert.ToString(drunken);
               

                for (int j = 0; j < drunkenNumber.Length; j++)
                {
                    if (drunkenNumber.Length % 2 == 0 && j < drunkenNumber.Length / 2)
                    {
                        resultM += drunkenNumber[j] - '0';
                    }
                    else if (drunkenNumber.Length % 2 != 0 && j < drunkenNumber.Length / 2 + 1)
                    {
                        resultM += drunkenNumber[j] - '0';
                    }
                    else if (drunkenNumber.Length % 2 == 0 && j >= drunkenNumber.Length / 2)
                    {
                        resultV += drunkenNumber[j] - '0';
                    }
                    else if (drunkenNumber.Length % 2 != 0 && j > drunkenNumber.Length / 2)
                    {
                        if (j == drunkenNumber.Length -1 )
                        {
                            resultV += (drunkenNumber[j] - '0') + (drunkenNumber[drunkenNumber.Length / 2] - '0');
                        }
                        else
                        {
                            resultV += (drunkenNumber[j] - '0');
                        }
                        
                    }


                }
           
            }
            if (resultM > resultV)
            {
                Console.WriteLine("M {0}", resultM - resultV);
            }
            else if (resultV > resultM)
            {
                Console.WriteLine("V {0}", resultV - resultM);
            }
            else if (resultV == resultM)
            {
                Console.WriteLine("No {0}", resultM + resultV);
            }

        }
    }
}
