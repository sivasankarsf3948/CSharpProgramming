using System;
namespace MethodQn4
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of terms");
            int term=int.Parse(Console.ReadLine());
            Fibbonacci(term);


            //Fibbonacci method
            void Fibbonacci(int limit)
            {
                int first=0, second=1,next,i=1;
                System.Console.Write("0   1   ");

                while(i<=limit-2)
                {
                    next=first+second;
                    first=second;
                    second=next;
                  System.Console.Write(next+"   ");
                  i++;
                }

            }
            
        }
    }
}
