using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTesting.Contracts;

namespace UnitTesting.Utils
{
    class GenerateId : IGenerateId
    {
        private int currentId;
        private int minimumValue;
        private int maximumValue;

        public GenerateId(int minimumValue, int maximumValue)
        {
            this.minimumValue = minimumValue;
            this.maximumValue = maximumValue;
            this.currentId = this.minimumValue - 1;
        }
        public int Generate()
        {
            Interlocked.Increment(ref currentId);

          
               return currentId;
        }
    }
}
