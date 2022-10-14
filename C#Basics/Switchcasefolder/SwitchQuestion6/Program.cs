using System;
namespace SwitchQuestion6
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter radius of a circle");
            double radius=double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Enter the operation number\n1-Area\n2-Perimeter\n3-Diameter");
            int choice=int.Parse(Console.ReadLine());
            double result=0;
            switch(choice)
            {
                case 1:
                {
                   result=3.14*radius*radius;
                   System.Console.WriteLine("Area = "+result);
                   break;
                }
                case 2:
                {
                    result=2*3.14*radius;
                   System.Console.WriteLine("Perimeter = "+result);
                   break;
                }
                case 3:
                {
                    result=2*radius;
                   System.Console.WriteLine("Diameter = "+result);
                   break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid input Enter a valid input");
                    break;
                }
            }
        }
    }
}