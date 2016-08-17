using School.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Exceptions
{
    public static class Validator
    {
        public static void CheckIfItIsNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("Incorrect name input!");
            }
        }

        public static void CheckIfItIsOutOfRange(int number)
        {
            if (number < 10000 || number > 99999)
            {
                throw new ArgumentOutOfRangeException("Number is out of range!");
            }
        }

        public static void CheckTheCourseCapacity(ICollection<IStudent> collection)
        {
            if (collection.Count < 0 || collection.Count > 30)
            {
                throw new ArgumentOutOfRangeException("Course full or empty!");
            }
        }

    }
}
