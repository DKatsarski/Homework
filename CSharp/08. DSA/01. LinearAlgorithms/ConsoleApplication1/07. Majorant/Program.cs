using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Majorant
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputValues = new List<int>();
            while (true)
            {
                var nextLine = Console.ReadLine();
                if (string.IsNullOrEmpty(nextLine))
                {
                    break;
                }

                int nextValue;
                var isParsed = int.TryParse(nextLine, out nextValue);
                if (isParsed)
                {
                    inputValues.Add(nextValue);
                }
            }

            var occurancesCounters = new Dictionary<int, int>();
            foreach (var value in inputValues)
            {
                var keyExists = occurancesCounters.ContainsKey(value);
                if (keyExists)
                {
                    occurancesCounters[value]++;
                }
                else
                {
                    occurancesCounters.Add(value, 1);
                }
            }


            int? maxKey = null;
            var maxKeyCount = 0;
            var inputCount = inputValues.Count;
            foreach (var item in occurancesCounters)
            {
                var isEligibleMajorant = ((inputCount / 2) + 1) <= item.Value;
                if (isEligibleMajorant && maxKeyCount < item.Value)
                {
                    maxKey = item.Key;
                    maxKeyCount = item.Value;
                }
            }

            if (maxKey != null)
            {
                Console.WriteLine($"Majorant is: {maxKey}, occurances: {maxKeyCount}.");
            }
            else
            {
                Console.WriteLine("Majorant does not exists.");
            }
        }
    }
}

