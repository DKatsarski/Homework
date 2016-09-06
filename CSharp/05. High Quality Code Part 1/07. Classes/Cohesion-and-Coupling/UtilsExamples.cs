using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            //The comments below are because I think that it's better if there is not extension on the file to throw errors. So the comments are so that the app can run. 

            //Console.WriteLine(FileNameManipulator.GetFileExtension("example"));
            Console.WriteLine(FileNameManipulator.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameManipulator.GetFileExtension("example.new.pdf"));

            //Console.WriteLine(FileNameManipulator.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameManipulator.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameManipulator.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                DistanceCalculator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                DistanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            IFigure figure = new Figure() { Width = 3, Height = 4, Depth = 5 };

            Console.WriteLine("Volume = {0:f2}", VolumeCalculator.CalcVolume(figure.Width, figure.Height, figure.Depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", DiagonalCalculator.CalcDiagonalXYZ(
                figure.Width, figure.Height, figure.Depth));
            Console.WriteLine("Diagonal XY = {0:f2}", DiagonalCalculator.CalcDiagonalXY(
                figure.Width, figure.Height));
            Console.WriteLine("Diagonal XZ = {0:f2}", DiagonalCalculator.CalcDiagonalXZ(
                figure.Width, figure.Depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", DiagonalCalculator.CalcDiagonalYZ(
                figure.Height, figure.Depth));
        }
    }
}
