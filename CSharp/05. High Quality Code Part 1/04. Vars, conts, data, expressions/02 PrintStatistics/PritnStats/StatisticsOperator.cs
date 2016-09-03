using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PritnStats
{
    public class StatisticsOperator
    {
        public void PrintStatistics(double[] array, int indexInArray)
        {
            // StringBuilder is created so that the printing option could be changed easily. 
            // Instead of Console it could be changed to Printer, File, etc. 
            StringBuilder dataToPrint = new StringBuilder();

            dataToPrint.AppendLine(PrintMax(array, indexInArray));
            dataToPrint.AppendLine(PrintMin(array, indexInArray));
            dataToPrint.AppendLine(PrintAvg(array, indexInArray));

            Console.WriteLine(dataToPrint);            
        }

        private static string PrintMax(double[] array, int indexInArray)
        {
            double greatestNumber = double.MinValue;

            for (int i = 0; i < indexInArray; i++)
            {
                if (array[i] > greatestNumber)
                {
                    greatestNumber = array[i];
                }
            }

            return greatestNumber.ToString();
        }

        private static string PrintMin(double[] array, int indexInArray)
        {
            double lowestNumber = double.MaxValue;

            for (int i = 0; i < indexInArray; i++)
            {
                if (array[i] < lowestNumber)
                {
                    lowestNumber = array[i];
                }
            }

            return lowestNumber.ToString();
        }

        private static string PrintAvg(double[] array, int indexInArray)
        {
            double sumOfNumbers = 0;

            for (int i = 0; i < indexInArray; i++)
            {
                sumOfNumbers += array[i];
            }

            double averageValueInArray = sumOfNumbers / indexInArray;

            return averageValueInArray.ToString();
        }
    }
}
