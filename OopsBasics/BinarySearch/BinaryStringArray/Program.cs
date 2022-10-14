using System;
namespace BinaryStringArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] array={"SF3001","SF3002","SF3003","SF3004","SF3005","SF3005","SF3006","SF3007","SF3008"};
            //display original array
             foreach(string element in array)
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
           string word=Console.ReadLine().ToUpper();
           int count=0;
           while(start<=end)
           {
           
           if(word==array[middle])
           {
            count++;
            System.Console.WriteLine($"Entered element is present in the array and its position in sorted array is {middle}");
            break;
           
           }
           else
           {
                if(string.Compare(word,array[middle])<1)
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
