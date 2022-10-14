using System;
namespace BasicQuestion8
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter meter value");
            double meter=double.Parse(Console.ReadLine());
            double centimeter=meter*100;
            double millimeter=centimeter*10;
            double inch=39.3*meter;
            double foot=12*meter;
            double mile=0.0006213715277778*meter;
            System.Console.WriteLine("\nThe values in different metrics are\n");
            System.Console.WriteLine($"Centimeter = {centimeter}\nMillimeter = {millimeter}\nInch       = {inch}\nFoot       = {foot}\nMile       = {mile}\n");
            
        }
    }
}
