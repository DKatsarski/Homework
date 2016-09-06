using Abstraction.Contracts;
using System;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double Radius { get; set; }
              
        public Figure(double radius)
        {
            this.Radius = radius;
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculatePerimeter();
        
        public abstract double CalculateSurface();
    }
}
