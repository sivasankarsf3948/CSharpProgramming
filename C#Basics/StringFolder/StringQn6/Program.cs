using System;
namespace StringQn6
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string");
            string word=Console.ReadLine();
            int alphabet=0,digit=0,special=0;
            
            for(int i=0;i<word.Length;i++)
            {
                int value=(int)word[i];
                //System.Console.WriteLine(value);
                if(value>=48 && value<=57)
                {
                  digit++;
                }
                else if(value>=65 && value<=90 ||value>=97 && value<=122)
                {
                  alphabet++;
                }
                else{
                    special++;
                }
                
            }
            System.Console.WriteLine("The digit count is "+digit);
            System.Console.WriteLine("The alphabet count is "+alphabet);
            System.Console.WriteLine("The special character  count is "+special);
        }
    }
}
