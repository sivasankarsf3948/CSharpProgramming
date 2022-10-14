using System;
namespace ArrayQn3
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
            
            //sum of array elements

            int sum=0;
            for(int i=0;i<numbers.Length;i++)
            {
               sum=sum+numbers[i];
            }
            System.Console.WriteLine("\nsum of elements stored in the array are "+sum);
        }
    }
}

