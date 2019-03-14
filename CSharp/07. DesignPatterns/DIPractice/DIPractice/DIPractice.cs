using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPractice
{
    public class DIPractice
    {
        static void Main()
        {
            IWriter writer = new ConsoleWriter();
            var salutation = new Solutator(writer);
            salutation.Exclaim();

        }
    }
}
