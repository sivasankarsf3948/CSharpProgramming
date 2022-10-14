using System;
namespace ArrayQn9
{
    class Program
    {




        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the row size of array 1");
            int row1size =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the column size of array 1");
            int column1size =int.Parse(Console.ReadLine());
            int[,] array1=new int[row1size,column1size];

            System.Console.WriteLine("Enter the row size of array 2");
            int row2size =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the column size of array 2");
            int column2size =int.Parse(Console.ReadLine());
            int[,] array2=new int[row2size,column2size];

            int[,] product=new int[2,2]{{0,0},{0,0}};
            
            //getting user input

            System.Console.WriteLine("Enter array1 elements");
            for(int i=0;i<row1size;i++)
            {
                for(int j=0;j<column1size;j++)
                {
                    array1[i,j]=int.Parse(Console.ReadLine());
                    
                }
                
            }

            System.Console.WriteLine("Enter array2 elements");
            for(int i=0;i<row2size;i++)
            {
                for(int j=0;j<column2size;j++)
                {
                    array2[i,j]=int.Parse(Console.ReadLine());
                    
                }
                
            }
           
            //printing array elements
            System.Console.WriteLine("Elements of 1 st array");
            for(int i=0;i<row1size;i++)
            {
                for(int j=0;j<column1size;j++)
                {
                    System.Console.Write(array1[i,j]+"\t");
                }
                System.Console.WriteLine("");
            }


            System.Console.WriteLine("Elements of 2 nd array");
            for(int i=0;i<row2size;i++)
            {
                for(int j=0;j<column2size;j++)
                {
                    System.Console.Write(array2[i,j]+"\t");
                }
                System.Console.WriteLine("");
            }
            
            
            for(int i=0;i<column1size;i++)
            {
                
                for(int j=0;j<row2size;j++)
                {
                    
                    for(int k=0;k<row2size;k++)
                    product[i,j]=product[i,j]+array1[i,k]*array2[k,j];
                }
                
            }

            System.Console.WriteLine(" The Multiplicated array is");
            for(int i=0;i<column1size;i++)
            {
                for(int j=0;j<row2size;j++)
                {
                    System.Console.Write(product[i,j]+"\t");
                }
                System.Console.WriteLine("");
            }
             
            
        }
    }
}
