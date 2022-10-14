using System;
namespace SimpleQn6
{
    class Program{
        public static void Main(string[] args)
        {
            string password="s3cr3t!P@ssw0rd";
            System.Console.WriteLine("Enter your password");
            string userpassword=Console.ReadLine();
            
            if(password==userpassword)
            {
                System.Console.WriteLine("Welcome");
            }
            else{
                System.Console.WriteLine("Wrong Password");
            }
        }
    }
}