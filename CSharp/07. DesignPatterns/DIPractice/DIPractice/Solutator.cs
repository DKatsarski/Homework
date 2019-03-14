using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPractice
{
    public class Solutator 
    {
        private IWriter writer;

        public Solutator(IWriter givenWriter)
        {
            this.writer = givenWriter;
        }

        public void Exclaim()
        {
            this.writer.Write("OMG is it working");
        }
    }
}
