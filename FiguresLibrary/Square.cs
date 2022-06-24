using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Square
    {
        public double Side { get; }

        public Square(double side)
        {
            if (side < 0 )
                throw new ArgumentException("Длина сторон не может быть меньше нуля");

            Side = side;
        }

        public double Area => Math.Pow(Side, 2);
    }
}
