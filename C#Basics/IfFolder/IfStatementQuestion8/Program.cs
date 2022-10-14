using System;
namespace IfStatementQuestion8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your sugar level");
            int level=int.Parse(Console.ReadLine());
            if(level<90)
            {
                System.Console.WriteLine("You have low sugar level");
            }
            else if(level>=90 && level<130)
            {
                System.Console.WriteLine("You are low normal");
            }
             else if(level>=130 && level<140)
            {
                System.Console.WriteLine("You are have medium sugar level");
            }
             else if(level>=140 && level<170)
            {
                System.Console.WriteLine("High Sugar - Try to  reduce it from now");
            }
             else if(level>=170)
            {
                System.Console.WriteLine("You are a very high sugar patient");
            }
        }
    }
}
