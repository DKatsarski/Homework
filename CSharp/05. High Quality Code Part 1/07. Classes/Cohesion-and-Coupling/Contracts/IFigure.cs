using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public interface IFigure
    {
        double Width { get; set; }

        double Height { get; set; }

        double Depth { get; set; }
    }
}
