using System;
namespace SwitchQuestion5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the country name\n1-India\n2-Pakistan\n3-Bangladesh");
            string country=Console.ReadLine().ToLower();
           
            switch(country)
            {
                case "india":
                {
                   System.Console.WriteLine("\n1.Gambir\n2.Ashwin\n3.Dhoni\n4.Jadeja");
                   break;
                }
                case "pakistan":
                {
                   System.Console.WriteLine("\n1.Azam\n2.Asif\n3.Ali\n4.Nawaz");
                   break;
                }
                case "bangladesh":
                {
                   System.Console.WriteLine("\n1.Das\n2.Rahman\n3.Anand\n4.Nabi");
                   break;
                }
                default:
                {
                    System.Console.WriteLine("\nInvalid input Enter a valid input");
                    break;
                }
            }
        }
    }
}
                 