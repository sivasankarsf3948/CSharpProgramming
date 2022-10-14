using System;
namespace BasicQuestion3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of Celcius");
            float celcius;
            bool temp=float.TryParse(Console.ReadLine(),out celcius);
            Console.WriteLine($"Kelvin     ={celcius+273.15}");
            Console.WriteLine($"Fahreheit  ={(celcius*9/5)+32}");

        }
    }

}
