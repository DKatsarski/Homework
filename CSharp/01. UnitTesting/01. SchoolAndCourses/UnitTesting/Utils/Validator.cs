using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Utils
{
    public static class Validator
    {
        public static bool CheckIfStringIsNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }

            return false;
        }

        public static bool CheckIfNumberIsInRange(int value, int minimumValue, int maximumValue)
        {
            if (minimumValue <= value && value <= maximumValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckIfObjectIsNull(object obj)
        {
            if (obj == null)
            {
                return true;
            }

            return false;
        }
    }
}
