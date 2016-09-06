using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Contracts
{
    public interface IFigure
    {
        double Width { get; set; }

        double Height { get; set; }

        double Radius { get; set; }

        double CalculatePerimeter();

        double CalculateSurface();
    }
}
