using System;
namespace MediumQn5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a end year ");
            int year=int.Parse(Console.ReadLine());
            
            for(int i=1;i<=year;i++)
            {
                if(i%100==0)
                {
                    if(i%4==0 && i%400==0)
                    {
                        System.Console.Write(i+"\t");
                    }
                    
                }
                else
                {
                    if(i%4==0)
                    {
                         System.Console.Write(i+"\t");
                    }
                }
            }
        }
    }
}