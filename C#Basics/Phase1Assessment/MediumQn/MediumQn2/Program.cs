using System;
namespace MediumQn2
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of terms in a fibbonocci series");
            int terms=int.Parse(Console.ReadLine());
            System.Console.WriteLine("The fibbonocci terms are ");
            System.Console.Write("0\t1\t");
            int first=0,second=1,next=0;
            
            for(int i=1;i<=terms-2;i++)
            {
              next=first+second;
              first=second;
              second=next;
              System.Console.Write(next+"\t");
            }
            
        }
    }
}