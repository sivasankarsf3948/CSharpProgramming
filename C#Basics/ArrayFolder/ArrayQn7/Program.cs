using System;
namespace ArrayQn7
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the row size of array");
            int row_size =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the column size of array");
            int column_size =int.Parse(Console.ReadLine());
            
            int[,] numbers=new int[row_size,column_size];

            //getting user input

            System.Console.WriteLine("Enter array elements");
            for(int i=0;i<row_size;i++)
            {
                for(int j=0;j<column_size;j++)
                {
                    numbers[i,j]=int.Parse(Console.ReadLine());
                    
                }
                
            }
           
            //printing array elements
            for(int i=0;i<row_size;i++)
            {
                for(int j=0;j<column_size;j++)
                {
                    System.Console.Write(numbers[i,j]+"\t");
                }
                System.Console.WriteLine("");
            }
            
        }
    }
}

