using System;
namespace StringQn10
{
    class Program{
        public static void Main(string[] args)
        {
            string defaultuser="user";
            string defaultpass="pass";
            System.Console.WriteLine("Enter a user name");
            string username=Console.ReadLine();
            System.Console.WriteLine("Enter password");
            string password=Console.ReadLine();
            if(defaultuser==username && defaultpass==password)
            {
                System.Console.WriteLine("Password entered successfully");
            }
            else if(defaultuser!=username){
                System.Console.WriteLine("username  is incorrect");
            }
            else{
                System.Console.WriteLine("Password is incorrect");
            }
            
            
        }
    }
}
