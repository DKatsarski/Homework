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
            var myArr = new int[] {73,  99, 49  };
            var resultArr = new int[myArr.Length];
            resultArr = GradingStudents(myArr);

            foreach (var number in resultArr)
            {
                Console.WriteLine(number);
            }
        }

        static int[] GradingStudents(int[] grades)
        {
            var roundedGrades = new int[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    if (grades[i] % 10 >= 3 && grades[i] % 10 <= 5)
                    {
                        roundedGrades[i] = ((grades[i] / 10)  * 10) + 5;
                    }
                    else if (grades[i] % 10 >= 8 && grades[i] % 10 <= 9)
                    {
                        roundedGrades[i] = ((grades[i] / 10) * 10) + 10;

                    }
                    else
                    {
                        roundedGrades[i] = grades[i];
                    }
                }
                else
                {
                    roundedGrades[i] = grades[i];
                }
            }


            return roundedGrades;
        }








    }
}