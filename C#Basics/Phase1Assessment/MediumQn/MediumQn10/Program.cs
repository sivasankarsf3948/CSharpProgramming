using System;
namespace MediumQn10
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of rows");
            int row=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number of column");
            int column=int.Parse(Console.ReadLine());
            for(int i=1;i<=row;i++)
            {
                for(int j=1;j<=column;j++)
                {
                    if(i==1||i==row||j==1||j==column)
                    {
                        System.Console.Write("*");
                    }
                    else{
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine(" ");
            }
            
        }
    }
}
