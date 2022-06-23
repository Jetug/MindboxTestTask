using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Triangle : IFigure
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area => GetArea();

        public bool IsRightTriange => GetIsRightTriange();

        private bool GetIsRightTriange()
        {
            double hypotenuse = Math.Sqrt(SideA * SideA + SideB * SideB);
            return hypotenuse == SideC;
        }

        private double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            double s = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return s;
        }
    }
}
