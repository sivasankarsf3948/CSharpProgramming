using System;
namespace ArrayQn1
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of array");
            int size =int.Parse(Console.ReadLine());
            
            int[] numbers=new int[size];
            System.Console.WriteLine("Enter array elements");
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i]=int.Parse(Console.ReadLine());
                
            
            }
            System.Console.WriteLine("The elements in array are");
            foreach(int i in numbers)
            {
                System.Console.Write(i+"\t");
            }
        }
    }
}