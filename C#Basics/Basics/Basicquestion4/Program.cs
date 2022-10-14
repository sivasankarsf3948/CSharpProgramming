using System;
namespace BasicQuestion4;
   class Program
   {
     public static void Main(string[] args)
     {
        Console.WriteLine("Enter the value of height");
        int height,radius;
        int.TryParse(Console.ReadLine(),out height);
        Console.WriteLine("Enter the value of radius");
        int.TryParse(Console.ReadLine(),out radius);
        double volume=3.14*radius*radius*height;
        Console.WriteLine(volume);

     }
   }
