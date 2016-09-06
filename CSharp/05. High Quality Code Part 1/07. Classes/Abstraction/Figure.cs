using Abstraction.Contracts;
using System;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        public double Width { get; private set; }

        public double Height { get; private set; }

        public double Radius { get; private set; }
              
        protected Figure(double radius)
        {
            this.Radius = radius;
        }

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculatePerimeter();
        
        public abstract double CalculateSurface();
    }
}
