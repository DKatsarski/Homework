using System;

namespace _12.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
           
            int counter = 0;


            while (input != 0)
            {
                counter++;
                string[] kofa = new string[counter];

                if (input % 2 == 0)
                {
                    kofa[counter - 1] = "0";
                    //Console.Write(kofa[counter - 1]);
                }
                else
                {
                    kofa[counter - 1] = "1";
                    //Console.Write(kofa[counter - 1]);x
                }

                input = input / 2;
                if (input == 0)
                {
                    for (int i = 0; i < kofa.Length; i++)
                    {
                        Console.Write(kofa[i]);
                    }
                    
                }

            }


         
              
        }
    }
}
