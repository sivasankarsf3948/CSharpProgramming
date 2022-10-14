using System;
namespace IfStatementQuestion1
{
    class Program
    {
      public static void Main(string[] args)
      {
        int number;
        System.Console.WriteLine("Enter a number");
        bool temp=int.TryParse(Console.ReadLine(),out number);

        //checking odd or even
        string result= number%2==0 ?$"{number} is an even integer":$"{number} is an odd integer";
        System.Console.WriteLine(result);
      }
    }
}
