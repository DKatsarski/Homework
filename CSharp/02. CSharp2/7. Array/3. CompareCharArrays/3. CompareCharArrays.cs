using System;

namespace _3.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            char[] fistArray = firstString.ToCharArray();
            char[] secondArray = secondString.ToCharArray();
            bool equal = false;


            if (fistArray.Length > secondArray.Length)
            {
                Console.WriteLine(">");
            }
            else if (fistArray.Length < secondArray.Length)
            {
                Console.WriteLine("<");

            }
            else if (fistArray.Length == secondArray.Length)
            {
                for (int i = 0; i < fistArray.Length; i++)
                {
                    if (fistArray[i] != secondArray[i])
                    {
                        if (fistArray[i] < secondArray[i])
                        {
                            Console.WriteLine("<");
                        }
                        else if (fistArray[i] > secondArray[i])
                        {
                            Console.WriteLine(">");
                        }
                        equal = false;
                        break;
                    }
                    else if (fistArray[i] == secondArray[i])
                    {
                        equal = true;
                    }


                }
            
               
                
            }
            if (equal == true)
            {
                Console.WriteLine("=");
            }



        }
    }
}
