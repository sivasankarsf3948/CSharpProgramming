using System;
namespace StringQn8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string ");
            string word=Console.ReadLine();
            
            System.Console.WriteLine("Enter  a positin to start extraction ");
            int position=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter  a length of substring ");
            int length=int.Parse(Console.ReadLine());
            char[] array=new char[length+1];
              int j=0;
            for( int  i=position-1;i<position+(length-1);i++)
            {
                array[j]=word[i];
                j++;
            }
            string str = new string(array);
            
            System.Console.WriteLine("The substring is :"+str);
       
        }
    }
}
