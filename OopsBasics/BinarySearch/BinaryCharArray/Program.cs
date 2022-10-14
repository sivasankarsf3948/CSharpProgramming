using System;
namespace BinaryCharArray
{
      class Program
    {
        public static void Main(string[] args)
        {
            char[] array={'S','Y','N','C','F','U','S','I','O','N'};
            //display original array
             foreach(char element in array)
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
           char character=char.Parse(Console.ReadLine().ToUpper());
           int count=0;
           while(start<=end)
           {
           
           if(character==array[middle])
           {
            count++;
            System.Console.WriteLine($"Entered element is present in the array ");
            break;
           
           }
           else
           {
                if(character<array[middle])
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
