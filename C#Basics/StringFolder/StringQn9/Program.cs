using System;
namespace StringQn9
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string ");
            string word=Console.ReadLine();
            System.Console.WriteLine("Enter a substring to check");
            string check=Console.ReadLine();
            bool temp=word.Contains(check);
            System.Console.WriteLine(temp);
            if(temp==true)
            {
               System.Console.WriteLine("The given substring is exists in the main string");
            }
            else{
                 System.Console.WriteLine("The given substring is not exists in the main string");
            }
        }
    }
}
