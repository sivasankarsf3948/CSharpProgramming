using System;
namespace MediumQn7
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter starting number");
            int start=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter difference ");
            int difference=int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter number of terms ");
            int terms=int.Parse(Console.ReadLine());
            int sum=0,count=0;
            System.Console.WriteLine("The output series are ");
            for(int i=start;i<start+terms*difference;i+=2)
            {
                System.Console.Write(i+"\t");
                sum=sum+i;
                count++;
             }  
             System.Console.WriteLine("\nThe sum is "+sum);
            
        }       
    }
}
