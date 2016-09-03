namespace _01.ClassSize
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angleOfTheFigure)
        {
            var sineOfFigureHeight = Math.Sin(angleOfTheFigure) * size.height;
            var sineOfFigureWidth = Math.Sin(angleOfTheFigure) * size.width;
            
            var cosineOfFigureHeight = Math.Cos(angleOfTheFigure) * size.height;
            var cosineOfFigureWidth = Math.Cos(angleOfTheFigure) * size.width;
            
            var findWidth = Math.Abs(cosineOfFigureWidth) + Math.Abs(sineOfFigureHeight);
            var findHeight = Math.Abs(sineOfFigureWidth) + Math.Abs(cosineOfFigureHeight);

            var figureWithRotaedAngle = new Size(findWidth, findHeight);

            return figureWithRotaedAngle;
        }
    }
}
