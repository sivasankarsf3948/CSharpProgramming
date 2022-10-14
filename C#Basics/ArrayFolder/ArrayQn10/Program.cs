using System;
namespace ArrayQn10
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the row size of array ");
            int rowsize =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the column size of array ");
            int columnsize =int.Parse(Console.ReadLine());
            int[,] array=new int[rowsize,columnsize];

           
            
            //getting user input

            System.Console.WriteLine("Enter array elements");
            for(int i=0;i<rowsize;i++)
            {
                for(int j=0;j<columnsize;j++)
                {
                    array[i,j]=int.Parse(Console.ReadLine());
                    
                }
                
            }

            //printing array elements
            System.Console.WriteLine("Elements of  array");
            for(int i=0;i<rowsize;i++)
            {
                for(int j=0;j<columnsize;j++)
                {
                    System.Console.Write(array[i,j]+"\t");
                }
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("Transpose of an array");
            for(int i=0;i<rowsize;i++)
            {
                for(int j=0;j<columnsize;j++)
                {
                    System.Console.Write(array[j,i]+"\t");
                }
                System.Console.WriteLine("");
            }


            

            
        }
    }
}
