using System;
namespace ArrayQn8
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the row size of array 1");
            int row1_size =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the column size of array 1");
            int column1_size =int.Parse(Console.ReadLine());
            int[,] array1=new int[row1_size,column1_size];

            System.Console.WriteLine("Enter the row size of array 2");
            int row2_size =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the column size of array 2");
            int column2_size =int.Parse(Console.ReadLine());
            int[,] array2=new int[row2_size,column2_size];

            int[,] sum=new int[row2_size,column2_size];
            
            //getting user input

            System.Console.WriteLine("Enter array1 elements");
            for(int i=0;i<row1_size;i++)
            {
                for(int j=0;j<column1_size;j++)
                {
                    array1[i,j]=int.Parse(Console.ReadLine());
                    
                }
                
            }

            System.Console.WriteLine("Enter array2 elements");
            for(int i=0;i<row2_size;i++)
            {
                for(int j=0;j<column2_size;j++)
                {
                    array2[i,j]=int.Parse(Console.ReadLine());
                    
                }
                
            }
           
            //printing array elements
            System.Console.WriteLine("Elements of 1 st array");
            for(int i=0;i<row1_size;i++)
            {
                for(int j=0;j<column1_size;j++)
                {
                    System.Console.Write(array1[i,j]+"\t");
                }
                System.Console.WriteLine("");
            }


            System.Console.WriteLine("Elements of 2 nd array");
            for(int i=0;i<row2_size;i++)
            {
                for(int j=0;j<column2_size;j++)
                {
                    System.Console.Write(array2[i,j]+"\t");
                }
                System.Console.WriteLine("");
            }

            for(int i=0;i<row2_size;i++)
            {
                for(int j=0;j<column2_size;j++)
                {
                    sum[i,j]=array1[i,j]+array2[i,j];
                }
                
            }

            System.Console.WriteLine(" The added array is");
            for(int i=0;i<row2_size;i++)
            {
                for(int j=0;j<column2_size;j++)
                {
                    System.Console.Write(sum[i,j]+"\t");
                }
                System.Console.WriteLine("");
            }

            
        }
    }
}
