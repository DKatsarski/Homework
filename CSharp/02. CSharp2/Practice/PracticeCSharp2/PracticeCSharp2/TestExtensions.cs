using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public static class TestExtensions
    {
        private const string NumberFormat = "F2";

        public static string ToPrice(this decimal priceText)
        {
            return $"${priceText.ToString(NumberFormat)}";
        }

        public static int AlittleMoreInt(this int myINt)
        {
            return myINt + 12;
        }
    }
}
