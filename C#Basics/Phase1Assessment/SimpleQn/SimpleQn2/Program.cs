using System;
namespace SimpleQn2
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a radius value ");
            int radius=int.Parse(Console.ReadLine());

            //calculating area and perimeter
            double area=3.14*radius*radius;
            double perimeter=2*3.14*radius;

            System.Console.WriteLine("Area value is      : "+area);
            System.Console.WriteLine("Perimeter value is : "+perimeter);
            
        }
    }
}
