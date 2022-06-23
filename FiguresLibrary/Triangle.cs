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
            if (sideA < 0 || sideB < 0 || sideC < 0)
                throw new ArgumentException("Длина сторон не может быть меньше нуля");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area => GetArea();
        public bool IsRightTriange => GetIsRightTriange();

        private bool GetIsRightTriange()
        {
            return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)) == SideC ||
                   Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)) == SideB ||
                   Math.Sqrt(Math.Pow(SideC, 2) + Math.Pow(SideB, 2)) == SideA;
        }

        private double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            double s = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return s;
        }
    }
}
