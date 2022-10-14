using System;
namespace ComplexQn1
{
    class Program{
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
            int[,] matrix3=new int[row1,column2];

             for(int i=0;i<row1;i++)
             {
             
                for(int j=0;j<column2;j++)
                {
                     matrix3[i,j]=0;
                      for(int k=0;k<row2;k++)
                      {
                      matrix3[i,j]=matrix3[i,j]+matrix1[i,k]*matrix2[k,j];
                      }
                }
            }
            System.Console.WriteLine("The resultant matrix is :");
            for(int i=0;i<row2;i++)
            {
              for (int j=0;j<column2;j++)
              {
                System.Console.Write(matrix3[i,j]+"\t");
              }
              System.Console.WriteLine(" ");
            }
            
         /*  int[,] matrix1={{1,2,3},{4,5,6}};
          System.Console.WriteLine(matrix1.Length);
          int[,] matrix2={{7,8},{9,10},{11,12}};
          int[,] matrix3=new int[2,3];
        
          for(int i=0;i<2;i++)
          {
             
            for(int j=0;j<3;j++)
            {
                 matrix3[i,j]=0;
                for(int k=0;k<3;k++)
                {
                  matrix3[i,j]=matrix3[i,j]+matrix1[i,k]*matrix2[k,i];
                }
            }
          }
          foreach(int i in matrix3)
          {
            System.Console.WriteLine(i);
          }*/
          
        }
  
    }
}
