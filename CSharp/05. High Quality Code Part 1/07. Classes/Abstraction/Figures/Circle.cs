namespace Abstraction
{
    using System;

    using Abstraction.Contracts;

    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        public double CalculateSurface()
        {
            double surface = Math.PI * this.radius * this.radius;

            return surface;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.radius;

            return perimeter;
        }
    }
}
