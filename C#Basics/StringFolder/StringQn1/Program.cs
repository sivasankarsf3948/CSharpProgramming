using System;
namespace StringQn1
{
    class Program{
        public static void Main(string[] args)
        {
            int count=0;
            System.Console.WriteLine("Enter a string");
            string word=Console.ReadLine();
            char[] array=new char[100];
            array=word.ToCharArray();
            foreach(char i in array)
            {
                count++;
            }
            System.Console.WriteLine("The length of the string is "+count);
            System.Console.WriteLine(array.Length);
        }

    }
}