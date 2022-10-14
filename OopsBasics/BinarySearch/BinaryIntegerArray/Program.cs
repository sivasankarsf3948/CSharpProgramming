using System;
namespace BinaryIntegerArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array={12,44,78,19,22};
            //display original array
             foreach(int element in array)
            {
                System.Console.Write(element+"\t");
            }
            //sorting array
            Array.Sort(array);

           int start=0;
           int length =array.Length;
           int end=length-1;
           int middle=(start+end)/2;
           System.Console.WriteLine("\nEnter an element to search in array");
           int value=int.Parse(Console.ReadLine());
           int count=0;
           while(start<=end)
           {
           
           if(value==array[middle])
           {
            count++;
            System.Console.WriteLine($"Entered element is present in the array ");
            break;
           
           }
           else
           {
                if(value<array[middle])
                {
                    end=middle-1;
                    middle=(start+end)/2;
                }
                else
                {
                    start=middle+1;
                    middle=(start+end)/2;
                }
           }
           
           }
           if(count==0)
           {
            System.Console.WriteLine("Entered element is not present in the array");
           }
           
        
        
        }   
    }
}
