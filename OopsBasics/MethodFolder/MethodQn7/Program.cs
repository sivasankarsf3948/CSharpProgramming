using System;
namespace MethodQn7
{
    class Program{
        public static void Main(string[] args)
        {

          System.Console.WriteLine("Enter a string ");
          string word=Console.ReadLine();
          //System.Console.WriteLine(word.Substring(1,3));
          
          String result=Recursion(word);
          //System.Console.WriteLine(result);
          if(result==word)
          {
            System.Console.WriteLine("Entered word is palindrome");
          }
          else{
            System.Console.WriteLine("The Word is not palindrome");
          }
           
           string Recursion(string letter)
           {
             //string value=letter;
            if(letter.Length==1)
            {
               return letter;
            }
            //string result=value.Substring(0);

            return Recursion(letter.Substring(1))+letter[0];

           }

          









           /* System.Console.WriteLine("Enter a string ");
            string word=Console.ReadLine();
            string temp="";
            for(int i=word.Length-1;i>=0;i--)
            {
                temp=temp+word[i];

            }
            if(temp==word)
            {
                System.Console.WriteLine("Entered string is Palindrome");
            }
            else{
                System.Console.WriteLine("Entered string is not a palindrome");
            }*/

        }
    }
}
