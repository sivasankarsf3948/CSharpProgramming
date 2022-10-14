using System;
namespace StringQn13
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string");
            int sum=0;
           // char c='1';
            //int n=(int)Char.GetNumericValue(c);
            string word=Console.ReadLine();
            for(int i=0;i<word.Length;i++)
            {
                if(Char.IsDigit(word[i]))
                {
                    int value=(int)Char.GetNumericValue(word[i]);
                    sum=sum+value;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}