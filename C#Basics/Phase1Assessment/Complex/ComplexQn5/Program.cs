using System;
namespace ComplexQn5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string ");
            string str=Console.ReadLine();
            string data="";
            for(int i=str.Length-1;i>=0;i--)
            {
                data=data+str[i];
            }
            if(data==str)
            {
                System.Console.WriteLine(str+"  is a palindrome");
            }
            else{
                System.Console.WriteLine(str+"  is not a palindrome");
            }
        }
    }
}
