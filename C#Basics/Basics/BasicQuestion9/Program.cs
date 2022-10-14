using System;
namespace BasicQuestion9
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter speed in km/hr");
            double speed=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter seconds value");
            double seconds=double.Parse(Console.ReadLine());
            double distance=speed*seconds*5/18;
            System.Console.WriteLine("The distance is {0}",(Math.Round(distance,2,MidpointRounding.ToEven)));

            
        }
    }
}