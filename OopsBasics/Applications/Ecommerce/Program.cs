using System;
namespace Ecommerce
{
   class Program
   {
    public static void Main(string[] args)
    {
        Files.CreateFiles();
        Files.ReadFiles();
        CustomerDetails.DefaultMethod();
        // ProductClass.DefaultMethod();
        // OrderDetails.DefaultMethod();
        Files.WriteFiles();
        Operations.MainMenu();
        Files.WriteFiles();
    }
   }

}