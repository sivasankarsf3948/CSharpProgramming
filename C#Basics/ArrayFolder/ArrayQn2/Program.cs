using System;
namespace ArrayQn2
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
            
            //reverse printing

            System.Console.WriteLine("\nThe elements in the array in reverse order are");
            for(int i=numbers.Length-1;i>=0;i--)
            {
                System.Console.Write(numbers[i]+"\t");
            }
        }
    }
}
