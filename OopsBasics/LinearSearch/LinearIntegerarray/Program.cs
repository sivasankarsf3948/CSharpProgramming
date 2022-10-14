using System;
namespace LinearIntegerArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Display array elements
            System.Console.WriteLine("The array elements are :");
            int[] array={12,33,44,82,70,58};
            foreach(int element in array)
            {
                System.Console.Write(element+"\t");
            }

            System.Console.WriteLine("\nChoose an element to search in an array");
            int value=int.Parse(Console.ReadLine());
            // search by linear method
            int count=0;
            for(int i=0;i<array.Length;i++)
            {
                if(value==array[i])
                {
                    System.Console.WriteLine($"The value {value} you searched is available in the index {i}");
                    count++;
                }
            }
            if(count==0)
            {
                System.Console.WriteLine("Entered element is not available in that array");
            }
            
        }
    }
    
}
