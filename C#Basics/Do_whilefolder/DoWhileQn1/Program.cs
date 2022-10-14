using System;
namespace DoWhileQn1
{
    class Program{
        public static void Main(string[] args)
        {
            string choice=" ";
            do{
                System.Console.WriteLine("Enter a number");
               int number=int.Parse(Console.ReadLine());
               string result=number%2==0?"The number is even":"The number is odd";
               System.Console.WriteLine(result);
               System.Console.WriteLine("Do you want to continue with next number If need enter 'yes' other wise enter any key");
              choice=Console.ReadLine().ToLower();
               
            }while(choice == "yes");
        }
    }
}
