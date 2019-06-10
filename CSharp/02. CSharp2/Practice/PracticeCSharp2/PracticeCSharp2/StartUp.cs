namespace PracticeCSharp2
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var arr = new int[] { 2, 3, 4, 5};
            
            var experiment = arr
                .Select(x => new int[]
                { 
                })
                .ToList();

            foreach (var num in experiment)
            {

                Console.WriteLine(num);
            }
        }

        public static int MyWrtier(int[] arr)
        {
            var lagergestNumber = 0;
            var temp = string.Empty;
            var tempInt = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i; j < i + 3; j++)
                {
                    temp += arr[j];
                }

                tempInt = int.Parse(temp);

                if (lagergestNumber < tempInt)
                {
                    lagergestNumber = tempInt;
                }

                tempInt = 0;
                temp = string.Empty;
            }

            return lagergestNumber;
        }
    }
}

