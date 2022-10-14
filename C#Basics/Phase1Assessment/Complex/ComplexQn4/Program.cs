using System;
namespace ComplexQn4
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string ");
            string word=Console.ReadLine();
            string data="";
            {
                for(int i=0;i<word.Length;i++)
                {
                  if(!data.Contains(word[i]))
                  {
                    data=data+word[i];
                  }
                }
            }
            System.Console.WriteLine("The resultant string is :");
            System.Console.WriteLine(data);
        }
    }
}
