using System;


namespace CalculatorApp
{
    public class CylinderVolume:CircleArea
    {
        private double height;
        public double Height { get; set; }
        internal double Volume { get; set; }

        public CylinderVolume(double height,double volume)
        {
            Height=height;
            Volume=volume;
            
        }
        void CalculateVolume()
        {
            Volume=Pi*radius*radius*height;
        }

    }
}