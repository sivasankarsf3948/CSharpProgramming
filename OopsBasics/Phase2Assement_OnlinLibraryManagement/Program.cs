using System;
namespace OnlineLibraryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserDetails.DefaultMethod();
            BookDetails.DefaultMethod();
            BorrowDetails.DefaultMethod();
            Operations.MainMenu();
        }
    }
}