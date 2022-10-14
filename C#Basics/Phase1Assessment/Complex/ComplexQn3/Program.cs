using System;
namespace ComplexQn3
{
    class Program{
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter first string ");
            string word1=Console.ReadLine();
             System.Console.WriteLine("Enter second string ");
            string word2=Console.ReadLine();
            string empty="";
            for(int i=0;i<word1.Length;i++)
            {
                for(int j=0;j<word2.Length;j++)
                {
                    if(word1[i]==word2[j])
                    {
                        word2=word2.Remove(j,1);
                    }
                }
            }
            if(word2==empty)
            {
                System.Console.WriteLine("Word1 and word2  are anagrams");
            }
            else{
                System.Console.WriteLine("Word1 and word2 are not anagrams");
            }

        }
    }
}
