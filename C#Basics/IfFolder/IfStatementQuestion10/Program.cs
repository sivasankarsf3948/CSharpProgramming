using System;
namespace IfStatementQuestion10
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter password");
            string pass=Console.ReadLine();
            string orgpassword="HiTeam";
            if(pass==orgpassword)
            {
                System.Console.WriteLine("Password is correct");
            }
            else{
                System.Console.WriteLine("Password is wrong");
            }
        }
    }
}
