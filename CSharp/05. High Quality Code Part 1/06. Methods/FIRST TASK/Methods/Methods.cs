using System;

namespace Methods
{
    public class Methods
    {
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double semiperimeter = (a + b + c) / 2;

            // Using Heron's formula for extracting the area
            double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));

            return area;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "Invalid number!";
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Array is null or empty");
            }

            int maxNumber = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }
            return maxNumber;
        }

        static string PrintAsNumber(object number, string format)
        {
            string numberToPrint = string.Empty;

            if (format == "f")
            {
                numberToPrint = string.Format("{0:f2}", number);
            }
            if (format == "%")
            {
                numberToPrint = string.Format("{0:p0}", number);
            }
            if (format == "r")
            {
                numberToPrint = string.Format("{0,8}", number);
            }

            return numberToPrint;
        }


        static double CalculateDistance(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(PrintAsNumber(1.3, "f"));
            Console.WriteLine(PrintAsNumber(0.75, "%"));
            Console.WriteLine(PrintAsNumber(2.30, "r"));

            bool horizontal, vertical;
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov", DateOfBirth = "17.03.1992", HomeTown = "Sofia" };

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova", DateOfBirth = "03.11.1993", HomeTown = "Vidin", Hobby = "gamer", Score = "high results" };

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
