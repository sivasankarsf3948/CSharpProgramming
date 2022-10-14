using System;
namespace WhileloopQn4
{
    class Program{
        public static void Main(string[] args)
        {
            int number;
            
            System.Console.WriteLine("Enter a number");
            bool temp=int.TryParse(Console.ReadLine(),out number);
            while(number!=1 && number!=2 && number!=3 && number!=4 && number!=5)
            {
              System.Console.WriteLine("Your input is invalid");
              System.Console.WriteLine("Enter a valid number");
              temp=int.TryParse(Console.ReadLine(),out number);  
            }
            System.Console.WriteLine("Congrats!! you entered a correct range number");
            
            
        }
    }
}
