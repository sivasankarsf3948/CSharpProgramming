using System;
namespace StringQn3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string");
            string word=Console.ReadLine();
            System.Console.WriteLine("The reversed string is :");
            for(int i=word.Length-1;i>=0;i--)
            {
                System.Console.Write(word[i]+"  ");
                
            }
        }
    }
}
