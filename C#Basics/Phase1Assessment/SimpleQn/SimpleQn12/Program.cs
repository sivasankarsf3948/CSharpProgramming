using System;
namespace StringQn13
{
    class Program{
        public static void Main(string[] args)
        {
            int sum=0;
            for(int i=1;i<=99;i++)
            {
                if(i%2!=0)
                {
                    sum=sum+(i*i);
                }
            }
          //  System.Console.WriteLine(" ");
            System.Console.WriteLine("The sum of odd number in the range 1-99 is  : "+sum);
        }
    }
}
