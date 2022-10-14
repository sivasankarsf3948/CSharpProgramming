using System;
namespace StrinQn5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter 1 st string");
            string word1=Console.ReadLine();
             System.Console.WriteLine("Enter 2 nd  string");
            string word2=Console.ReadLine();
            int length1=word1.Length;
            int length2=word2.Length;
            int count=0;
            if(length1==length2)
            {
             for(int i=0;i<length1;i++)
             {
                if(word1[i]==word2[i])
                {
                    count++;
                }
             }
              if(count==length1 && count==length2)
               {
                System.Console.WriteLine("Length of both strings are equal, also both string characters  also equal");
               }
                else
                {
                System.Console.WriteLine("Length of both strings are equal but string characters are not equal");
                }
            }
            else
            {
                System.Console.WriteLine("Length  of the strings are not equal so both strings must be not equal");
            }
            

           
        }
    }
}
