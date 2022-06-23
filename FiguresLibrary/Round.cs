using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Round : IFigure
    {
        public double Radius { get; init; }

        public Round(double radius)
        {
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;
    }
}
