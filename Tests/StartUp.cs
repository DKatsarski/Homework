using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class StartUp
    {
        static void Main()
        {
            var arrayStrings2 = new string[] { "ababa",
                                               "bacab",
                                               "ababd",
                                               "babab",
                                               "ababa" };

            var arrayString3 = new string[] {"yyxyxy",
                                             "yxyxyx",
                                             "xyxyxy",
                                             "yxyxyx",
                                             "xyxyxy",
                                             "yxyxyx"

                                             
 };

            var arraySTRING = new string[] { "aba", "dey", "hwz" };

            var lastArray = new string[] { "aaaaa", "aaaaa", "aaaaa", "aaaaa", "aaaaa" };

            var yetAnotherOne = new string[] { "aaaa", "bbbb", "cccc", "dddd" };


            Console.WriteLine(solve(arraySTRING));

        }






        static int solve(string[] input)
        {



            int counterMinTimes = 0;
            int mostEfficientNumber = 0;

            //find the most common symbols 

            //TODO: i would have to find the check for the case where there is only one symbol -> probably if just devid the hole lenght by 2

            StringBuilder appendElements = new StringBuilder();
            int max = 0;
            Char firstMostRepeated = Char.MinValue;
            Char secondMostRepeated = Char.MinValue;


            for (int i = 0; i < input.Length; i++)
            {
                appendElements.Append(input[i]);
            }

            int[] count = new int[256];

            Array.Clear(count, 0, count.Length - 1);

            foreach (Char c in appendElements.ToString())
            {
                if (++count[c] > max)
                {
                    max = count[c];
                    firstMostRepeated = c;
                }
            }

            foreach (Char c in appendElements.ToString())
            {
                if (c != firstMostRepeated && ++count[c] > max)
                {
                    max = count[c];
                    secondMostRepeated = c;
                }
            }

            if (secondMostRepeated == '\0' && appendElements.ToString().Count(x => x == firstMostRepeated) != appendElements.ToString().Length)
            {
                secondMostRepeated = appendElements.ToString().First(x => x != firstMostRepeated);
            }
            else if (secondMostRepeated == '\0')
            {
                secondMostRepeated = "asdf".First(x => x != firstMostRepeated);
            }



            string toBeChecked = appendElements.ToString();

            //affter the two most common are known - search the string for the two possibilities -> odd and even (start from the first element, then from the other and compare

            //odd
            if (input.Length % 2 != 0)
            {
                //first case
                for (int i = 0; i < toBeChecked.Length; i++)
                {


                    if (toBeChecked[i] != firstMostRepeated && i % 2 == 0)
                    {
                        counterMinTimes += 1;
                    }

                    if (toBeChecked[i] != secondMostRepeated && i % 2 != 0)
                    {
                        counterMinTimes += 1;
                    }
                }

                mostEfficientNumber = counterMinTimes;
                counterMinTimes = 0;

                // second case (starts with the second element)

                for (int i = 0; i < toBeChecked.Length; i++)
                {
                    if (toBeChecked[i] != firstMostRepeated && i % 2 != 0)
                    {
                        counterMinTimes += 1;
                    }

                    if (toBeChecked[i] != secondMostRepeated && i % 2 == 0)
                    {
                        counterMinTimes += 1;
                    }

                }

                if (mostEfficientNumber > counterMinTimes)
                {
                    mostEfficientNumber = counterMinTimes;
                }

                return mostEfficientNumber;
                //returnt mostEfficientNumber

                //secon case 




            }
            //even
            else
            {

              

                //even element 


                for (int i = 0; i < input.Length; i++)
                {

                    // FIRST CASE 
                    if (i % 2 == 0)
                    {
                        for (int x = 0; x < input[i].Length; x++)
                        {
                            if (input[i][x] != firstMostRepeated && x % 2 == 0)
                            {
                                counterMinTimes += 1;
                            }

                            if (input[i][x] != secondMostRepeated && x % 2 != 0)
                            {
                                counterMinTimes += 1;
                            }

                        }

                    }
                    else
                    {
                        // have to start with the other letter 
                        for (int x = 0; x < input[i].Length; x++)
                        {
                            if (input[i][x] != firstMostRepeated && x % 2 != 0)
                            {
                                counterMinTimes += 1;
                            }

                            if (input[i][x] != secondMostRepeated && x % 2 == 0)
                            {
                                counterMinTimes += 1;
                            }

                        }

                    }

                }

                mostEfficientNumber = counterMinTimes;
                counterMinTimes = 0;


                for (int i = 0; i < input.Length; i++)
                {
                    //SECOND CASE

                    if (i % 2 != 0)
                    {
                        for (int x = 0; x < input[i].Length; x++)
                        {
                            if (input[i][x] != firstMostRepeated && x % 2 == 0)
                            {
                                counterMinTimes += 1;
                            }

                            if (input[i][x] != secondMostRepeated && x % 2 != 0)
                            {
                                counterMinTimes += 1;
                            }

                        }

                    }
                    else
                    {
                        // have to start with the other letter 
                        for (int x = 0; x < input[i].Length; x++)
                        {
                            if (input[i][x] != firstMostRepeated && x % 2 != 0)
                            {
                                counterMinTimes += 1;
                            }

                            if (input[i][x] != secondMostRepeated && x % 2 == 0)
                            {
                                counterMinTimes += 1;
                            }

                        }

                    }
                }


                if (mostEfficientNumber > counterMinTimes)
                {
                    mostEfficientNumber = counterMinTimes;
                }


                return mostEfficientNumber;





            }
        }


    }
}
