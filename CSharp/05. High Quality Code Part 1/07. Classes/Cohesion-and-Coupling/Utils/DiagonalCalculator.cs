using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public static class DiagonalCalculator
    {
        public static double CalcDiagonalXYZ(double width, double height, double depth)
        {
            double distance = DistanceCalculator.CalcDistance3D(0, 0, 0, width, height, depth);

            return distance;
        }

        public static double CalcDiagonalXY(double width, double height)
        {
            double distance = DistanceCalculator.CalcDistance2D(0, 0, width, height);

            return distance;
        }

        public static double CalcDiagonalXZ(double width, double depth)
        {
            double distance = DistanceCalculator.CalcDistance2D(0, 0, width, depth);

            return distance;
        }

        public static double CalcDiagonalYZ(double height, double depth)
        {
            double distance = DistanceCalculator.CalcDistance2D(0, 0, height, depth);

            return distance;
        }
    }
}
