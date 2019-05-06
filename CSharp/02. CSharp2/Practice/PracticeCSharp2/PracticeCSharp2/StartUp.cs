namespace Defining_Classes_Main
{
    using System.Collections.Generic;

    public struct Point3D
    {
        /// <summary>
        /// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
        /// </summary>

        private decimal X;
        private decimal Y;
        private decimal Z;

        /// <summary>
        /// Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        /// </summary>
        static readonly List<decimal> O = new List<decimal> { 0, 0, 0 };

        public Point3D(decimal x, decimal y, decimal z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }


        /// <summary>
        /// Implement the ToString() to enable printing a 3D point.
        /// </summary>
        /// <returns> Printed 3D point </returns>
        /// 

        public static List<decimal> ReturnCoordinates
        { get
            {
                return O;
            }
        }

    }
  

}
