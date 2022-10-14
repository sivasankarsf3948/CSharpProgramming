using System;
namespace ForQn7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of rows");
            int row=int.Parse(Console.ReadLine());
            int space=row;
            for(int i=0;i<row;i++)
            {
                for(int k=space;k>=1;k--){
                    System.Console.Write(" ");
                }
                for (int j=0;j<=i;j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine(" ");
                space--;
            }
            
        }
    }
}