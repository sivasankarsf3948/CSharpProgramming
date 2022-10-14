using System;
namespace LinearStringArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] stringArray={"Sync","Fusion","is","a","product","company"};
            //display string array
            System.Console.WriteLine("The elements of the strings are");
            foreach (string element in stringArray)
            {
                System.Console.Write(element+"\t");
            }
            
            //pick one element
            System.Console.WriteLine("\nChoose an element to search its position in the array");
            string value =Console.ReadLine();
            int count=0;
            //search by linear
            for(int i=0;i<stringArray.Length;i++)
            {
                if(value==stringArray[i])
                {
                    System.Console.WriteLine($"Entered element '{value}' is in  the index position  of {i} ");
                    count++;
                }
                
            }
            if(count==0)
            {
                System.Console.WriteLine("Entered element is not available in the array");
            }
        }
    }
}
