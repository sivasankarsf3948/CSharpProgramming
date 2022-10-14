using System;
namespace StringAassignment
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a long string");
            string word=Console.ReadLine();
            System.Console.WriteLine("Enter a substring to find occurences");
            string str=Console.ReadLine();
            string[] split=word.Split("la");
            int length=split.Length;
            System.Console.WriteLine("The Length is  "+(length-1));
            
        }
    }
}
