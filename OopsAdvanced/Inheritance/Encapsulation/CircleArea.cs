using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathLib;

namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        protected double radius;
        public double Radius { get; set; }
        internal double Area { get; set; }

        public CircleArea(double radius,double area)
        {
            Radius=radius;
            Area=area;
        }

        public  void CalculateCircleArea()
        {
            Area=Pi*Radius*Radius;
        }
    }
}