using System;
namespace IfStatementQuestion4
{
    class Program{
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter 1st number");
           int number1=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter 2nd number");
           int number2=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter 3rd number");
           int number3=int.Parse(Console.ReadLine());

           //checking between 1 and 3

           if(number1>number2)
           {
            if(number1>number3)
            {
                System.Console.WriteLine("The 1st number is greatest among three");
            }
            else
            {
                System.Console.WriteLine("The 3rd number is greatest among three");
            }
           }

           //check between 2 nd and 3rd
           
           else if(number2>number3)
           {
             System.Console.WriteLine("The 2nd number is greatest among three");
           }
           else{
             System.Console.WriteLine("The 3rd number is greatest among three");
           }

        }
    }
}