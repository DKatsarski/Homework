using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class StartUp
    {
        static void Main()
        {
            
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var aPoints = 0;
            var bPoints = 0;
            var score = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aPoints++;
                }
                else if (a[i] < b[i])
                {
                    bPoints++;
                }
            }

            score.Add(aPoints);
            score.Add(bPoints);

            return score;

        }







    }
}