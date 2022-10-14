using System;
namespace WhileloopQn3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number of terms ");
            int number=int.Parse(Console.ReadLine());
            int first=0;
            int second=1;
            int next,i=1;
            System.Console.Write(first+" " );
            System.Console.Write(second+" " );
            while(i<=number-2)
            {
                next=first+second;
                System.Console.Write(next+" ");
                first=second;
                second=next;
                i++;

            }
            
            
            
        }
    }
}
