using System;
namespace MediumQn9
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of rows");
            int row=int.Parse(Console.ReadLine());
            
            int space=row;
            for(int i=0;i<row;i++)
            {
                for(int k=space;k>0;k--)
                {
                    System.Console.Write(" ");
                }
                for(int j=1;j<i+2;j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine(" ");
                space--;
            }
        }
    }
}
