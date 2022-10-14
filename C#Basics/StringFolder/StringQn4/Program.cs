using System;
namespace StringQn4
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string ");
            string word=Console.ReadLine();
            string[] array=new string[100];
            array=word.Split(" ");
            System.Console.WriteLine("The number of words in a string is "+array.Length);
        }
    }
}