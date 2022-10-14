using System;
namespace ForQn3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the end limit");
            int limit=int.Parse(Console.ReadLine());
            for (int i=1;i<=limit;i++)
            {
                System.Console.WriteLine($"Number is {i} and cube of {i} is :{i*i*i}");
            }
            
        }
    }
}
