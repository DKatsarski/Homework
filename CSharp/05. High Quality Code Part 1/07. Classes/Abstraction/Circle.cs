﻿using System;

namespace Abstraction
{
    public class Circle : Figure
    {
        public Circle(double radius)
            : base(radius)
        {
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }
    }
}
