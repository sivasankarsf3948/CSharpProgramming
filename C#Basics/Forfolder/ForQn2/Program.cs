using System;
namespace ForQuestion2
{
    class Program{
        public static void Main(string[] args)
        
        {
           double sum=0,average=0;
           System.Console.WriteLine("Enter 10 numbers");
           
           for(int i=0;i<10;i++) 
           {
            System.Console.WriteLine($"Enter the number {i+1}");
            int number=int.Parse(Console.ReadLine());
            sum=sum+number;
            
           }
           average=sum/10;
           System.Console.WriteLine("Sum of all number is "+sum);
            System.Console.WriteLine("Average  is "+average);

        }
    }
}
