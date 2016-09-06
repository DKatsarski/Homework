namespace Abstraction
{
    using Abstraction.Contracts;

    public class Rectangle : IFigure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        
        public double CalculateSurface()
        {
            double surface = this.width * this.height;

            return surface;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * (this.width + this.height);

            return perimeter;
        }
    }
}
