using System;
namespace ArrayQn4
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of array");
            int size =int.Parse(Console.ReadLine());
            
            int[] numbers=new int[size];

            //getting user input

            System.Console.WriteLine("Enter array elements");
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i]=int.Parse(Console.ReadLine());
            }
            
            //printing elements

            System.Console.WriteLine("The elements in array are");
            foreach(int i in numbers)
            {
                System.Console.Write(i+"\t");
            }
            
            //max and min of array elements

            int temp=0;
            for(int i=0;i<numbers.Length;i++)
            {
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if(numbers[i]>numbers[j])
                    {
                      temp=numbers[i];
                      numbers[i]=numbers[j];
                      numbers[j]=temp;
                    }
                }
            }
            System.Console.WriteLine("\nThe maximum element is "+numbers[size-1]);
            System.Console.WriteLine("The minimum element is "+numbers[0]);
            
        }
    }
}
