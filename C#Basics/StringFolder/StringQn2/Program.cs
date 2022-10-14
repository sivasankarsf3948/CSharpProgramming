using System;
namespace StringQn2
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string ");
            string word=Console.ReadLine();
           System.Console.WriteLine("The string characters are :");
            foreach(char i in word)
            {
                System.Console.Write(i+"  ");
            }

        }
    }
}