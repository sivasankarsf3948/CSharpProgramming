using System;
namespace ForQn5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of terms");
            int number=int.Parse(Console.ReadLine());
            int sum=0;
            System.Console.WriteLine("The odd numbers are");
            for (int i=1;i<=number*2;i+=2)
            {
             System.Console.Write(i+"\t");
             sum=sum+i;
            }
            System.Console.WriteLine("\nThe sum of odd numbers are :{0}",sum);
            
        }
    }
}
