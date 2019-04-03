using Bazik;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class PracticeCSharp2
    {
        static void Main()
        {
            Console.WriteLine(LengthOfLongestSubstring("abcb"));
        }

        public static int LengthOfLongestSubstring(string givenString)
        {
            int longestNumber = 1;
            int resultKeeper = 1;
            int counter = 1;
            int resterterToZero = 0;
            int restarterToOne = 1;

            if (givenString == string.Empty)
            {
                return 0;
            }
            else if (givenString.Length == 2 && givenString[0] != givenString[1])
            {
                return 2;
            }
            else if (givenString.Length == 3 && (givenString[0] == givenString[1] && givenString[0] == givenString[2]))
            {

                return 1;
            }
            else if (givenString.Length == 3 && (givenString[0] == givenString[1] || givenString[0] == givenString[2] || givenString[1] == givenString[2]))
            {
                return 2;
            }

          


            for (int i = 0; i < givenString.Length; i++)
            {
                counter = restarterToOne;

                for (int x = i + 1; x < givenString.Length; x++)
                {
                    if (x != givenString.Length - 1)
                    {
                        if (givenString[i] != givenString[x] && givenString[x] != givenString[x + 1])
                        {
                            counter += 1;
                        }
                        else if (givenString[i] == givenString[x])
                        {
                            resultKeeper = counter;
                            break;
                        }
                        else if (givenString[x] == givenString[x + 1])
                        {
                            resultKeeper = counter;
                            break;
                        }
                    }
                    else
                    {
                        if (givenString[i] != givenString[x])
                        {
                            counter += 1;
                            resultKeeper = counter;
                        }
                        else if (givenString[i] == givenString[x])
                        {
                            resultKeeper = counter;
                            break;
                        }
                        else if (givenString[x] != givenString[x + 1])
                        {
                            resultKeeper = counter;
                            break;
                        }
                    }

                }

                if (resultKeeper > longestNumber)
                {
                    longestNumber = resultKeeper;
                    resultKeeper = resterterToZero;
                }

            }


            return longestNumber;
        }
    }
}
