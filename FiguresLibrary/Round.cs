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
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть меньше нуля");

            Radius = radius; 
        }

        public double Area => Math.PI * Radius * Radius;
    }
}
