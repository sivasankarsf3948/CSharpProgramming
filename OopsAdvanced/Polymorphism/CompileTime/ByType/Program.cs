using System;
namespace ByType
{
    class program 
    {
        static void Display(int number)
        {
            System.Console.WriteLine("integer type  :"+number);
        }
        //method with two parameter

         static void Display(string name)
        {
            System.Console.WriteLine("String type :"+name);
        }
        public static void Main(string[] args)
        {
            Display(100);
            Display("Program");
            Console.ReadLine();
            
        }
    }
}
