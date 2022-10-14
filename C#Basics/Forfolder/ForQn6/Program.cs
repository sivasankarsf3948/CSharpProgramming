using System;
namespace ForQn6{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of rows");
            int row=int.Parse(Console.ReadLine());
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine("");
            }
            
        }
    }
}
