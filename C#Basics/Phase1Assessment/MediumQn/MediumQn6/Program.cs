using System;
namespace MediumQn6
{
class Program
{
    public static void Main(string[] args)
    {
            System.Console.WriteLine("Enter row size of matrix1");
            int row1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter column size of matrix 1");
            int column1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter row size of matrix2");
            int row2=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter column size of matrix 2");
            int column2=int.Parse(Console.ReadLine());
            int[,] matrix1=new int[row1,column1];
            int[,] matrix2=new int[row2,column2];
            System.Console.WriteLine("Enter elements of matrix1");
            for(int i=0;i<row1;i++)
            {
                for(int j=0;j<column1;j++)
                {
                   matrix1[i,j]=int.Parse(Console.ReadLine());
                }
              
            }
             System.Console.WriteLine("Enter elements of matrix2");
            for(int i=0;i<row2;i++)
            {
                for(int j=0;j<column2;j++)
                {
                   matrix2[i,j]=int.Parse(Console.ReadLine());
                }
              
            }
            int[,] matrix3=new int[row1,column1];
            //Adding two  matrix
            for(int i=0;i<row1;i++)
            {
                for(int j=0;j<column1;j++)
                {
                 matrix3[i,j]=matrix1[i,j]+matrix2[i,j];
                }
            }
            for(int i=0;i<row1;i++)
            {
                for(int j=0;j<column1;j++)
                {
                System.Console.Write(matrix3[i,j]+" ");
                }
                System.Console.WriteLine(" ");
            }
    }
 }
}