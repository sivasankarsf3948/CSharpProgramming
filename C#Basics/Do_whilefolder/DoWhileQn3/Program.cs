using System;
namespace DoWhileQn3
{
    class Program{
        public static void Main(string[] args)
        {
            int first=0,second=1,next=0;
            System.Console.WriteLine("Enter a number of terms to print");
            int term=int.Parse(Console.ReadLine());
            int j=1;
            System.Console.Write("0\t1\t");
            do{
             next=first+second;
             first=second;
             second=next;
             j++;
             System.Console.Write(next+"\t");
            }while(j<=term-2);
          
            
        }
    }
}

