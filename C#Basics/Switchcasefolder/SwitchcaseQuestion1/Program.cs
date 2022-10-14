using System;
namespace SwitchCaseQuestion1
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter choice:\nE-Excellent\nV-Very good\nG-Good\nA-Average\nF-Fail");
            char choice=char.Parse(Console.ReadLine().ToUpper());
            switch(choice)
            {
                case 'E':
                {
                    System.Console.WriteLine("Excellent");
                    break;
                }
                case 'V':
                {
                    System.Console.WriteLine("Very Good");
                    break;
                }
                case 'G':
                {
                    System.Console.WriteLine("Good");
                    break;
                }
                case 'A':
                {
                    System.Console.WriteLine("Average");
                    break;
                }
                case 'F':
                {
                    System.Console.WriteLine("Fail");
                    break;
                }
            }
            
        }
    }
}
