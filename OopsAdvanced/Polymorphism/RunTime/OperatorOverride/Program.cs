using System;
namespace OperatorOverride
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Box box1=new Box(1.2,3.2,4.2);
            Box box2=new Box(11.2,32.2,4.2);
            Box box3;//memory no object
            double volume=0.0;

            //volume of box 1
            volume=box1.CalculateVolume();
            System.Console.WriteLine("Volume of box 1 is "+volume);

             //volume of box 2
            volume=box2.CalculateVolume();
            System.Console.WriteLine("Volume of box 2 is "+volume);

            //add 2 objects
            box3=box1+box2;

            //volume of box3
            volume=box3.CalculateVolume();
            System.Console.WriteLine("Volume of box 3 is "+volume);

           
        }
    }
}
