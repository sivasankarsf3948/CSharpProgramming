using System;
namespace MethodQn5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number=int.Parse(Console.ReadLine());
            System.Console.WriteLine("The number is "+Prime(number));



            String Prime(int value)
            {
                int count=0;
                for(int i=2;i<value-1;i++)
                {
                    if(value%i==0)
                    {
                        count++;
                    }
                }
                String result=count==0 ?"Prime" :"Not a Prime";
                return result;
            }
            
        }
    }
}
