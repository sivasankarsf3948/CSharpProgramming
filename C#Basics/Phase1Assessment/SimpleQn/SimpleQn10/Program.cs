using System;
namespace SimpleQn10
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a letter");
            string str=Console.ReadLine();
            str=str.ToLower();
            char letter=Char.Parse(str);
            if(letter=='a'||letter=='e'||letter=='i'||letter=='o'||letter=='u')
            {
             System.Console.WriteLine("Entered letter is vowel");
            }
            else{
                 System.Console.WriteLine("Entered letter is not a vowel");
            }
        }
    }
}
