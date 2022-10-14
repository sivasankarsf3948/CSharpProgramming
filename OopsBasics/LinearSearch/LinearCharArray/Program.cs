using System;
namespace LinearCharArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] charArray={'s','i','v','a'};
            //Display char elements
            foreach(char character in charArray)
            {
                System.Console.Write(character+"\t");
            }
            //choose search element
            System.Console.WriteLine("\nEnter the element needed to search");
            char element=char.Parse(Console.ReadLine());
            int count=0;
            // search by linear method 
            for(int i=0;i<charArray.Length;i++)
            {
                if(element==charArray[i])
                {
                    System.Console.WriteLine($"The searched element {element} is at the index position {i}");
                    count++;
                }
            }
            //if no element in array
            if(count==0)
            {
                System.Console.WriteLine("Entered element is not available in the array");
            }
        }
    }
}
