using System;
using System.Threading;
using System.Globalization;

class PointInCircleOutRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        double x1 = 1;            // circle (01{x1,y1}, r)
        double y1 = 1;
        double r = 1.5;

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        // using Pythagorean theorem
        bool insideCircle = (x - x1) * (x - x1) + (y - y1) * (y - y1) <= r * r;

        // rectangle's parameters
        double top = 1;
        double left = -1;
        double width = 6;
        double height = 2;

        bool insideRectangle = (x >= left) && (x <= (left + width)) && (y >= (top - height)) && (y <= top);

        Console.Write(insideCircle ? "inside circle " : "outside circle ");
        Console.WriteLine(insideRectangle ? "inside rectangle" : "outside rectangle");

   
    }
}