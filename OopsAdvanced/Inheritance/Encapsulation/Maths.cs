using System;
namespace MathLib
{
    public class Maths
    {
        protected internal double Pi  =3.14;
        internal double g=9.8;

        void CalculateWeight()
        {
            System.Console.WriteLine("Enter the mass value");
            double mass=double.Parse(Console.ReadLine());
            double weight=mass*g;
        }
    }
}
