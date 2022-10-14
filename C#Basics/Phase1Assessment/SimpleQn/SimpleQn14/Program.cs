using System;
namespace SimpleQn15
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of rows");
            int row=int.Parse(Console.ReadLine());
            for(int i=1;i<row+1;i++)
            {
                for(int j=1;j<i+1;j++)
                {
                    System.Console.Write(i);
                }
                System.Console.WriteLine("");
            }
            
        }
    }
}