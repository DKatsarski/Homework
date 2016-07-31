using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Exceptions;

namespace UnitTesting.Utils
{
    public static class IdGenerator
    {
        public static int GenerateUniqueIdInRange(IEnumerable<int> existingIds, int minimumValue, int maximumValue)
        {
            var output = minimumValue;

            foreach (var id in existingIds)
            {
                if (id == output)
                {
                    output++;
                }
                else
                {
                    return output;
                }
            }

            throw new ArgumentNotUniqueException();
        }
    }
}
