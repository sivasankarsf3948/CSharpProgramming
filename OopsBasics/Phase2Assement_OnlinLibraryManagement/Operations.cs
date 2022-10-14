using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public class Operations
    {
         private static string s_registerNumber="";
        public static void MainMenu()
        {
           
            
            string condition="yes";
            do{
                System.Console.WriteLine("Select Option \n1.User Registration\n2.User LogIn\n3.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        UserDetails.UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        Operations.UserLogIn();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Thank you!!!");
                        condition="no";
                        break;
                    }
                }
                

            }while(condition=="yes");
        }

        //Login method
        public static void UserLogIn()
        {
            System.Console.WriteLine("Enter Registration Number ");
            string regNumber=Console.ReadLine();
            int count=0;
            foreach(UserDetails user in UserDetails.userList)
            {
                if(regNumber==user.RegisterNumber)
                {
                    s_registerNumber=user.RegisterNumber;
                    count++;

                    SubMenu();
                    
                }
            }
            if(count==0)
            {
                System.Console.WriteLine("Invalid user Id please enter valid one");
            }

            

        }

        //submenu method
        public static void SubMenu()
        {
            string condition="yes";
            do{
                System.Console.WriteLine("Select Option \n1.Borrow book\n2.Return Book\n3.Show borrowed history\n4.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        BorrowBook();
                        break;
                    }
                    case 2:
                    {
                        ReturnBook();
                        break;
                    }
                    case 3:
                    {
                        BorrowedHistory();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Thank you!!!");
                        condition="no";
                        break;
                    }
                }
                

            }while(condition=="yes");

        }

        
        //Borrow Book method
        public static void BorrowBook()
        {
            int count=0;
            foreach(BookDetails books in BookDetails.bookList)
            {
                System.Console.WriteLine($"Book Id :{books.BookId}\tBook Name :{books.BookName}\tAuthorName :{books.AuthorName}\tBook Count :{books.BookCount}");
            }
            System.Console.WriteLine("Enter the Book Id to borrow");
            string bookID=Console.ReadLine();
            foreach(BookDetails books in BookDetails.bookList)
            {
                if(bookID==books.BookId)
                {
                    if(books.BookCount>=1)
                    {
                        //user count check
                        foreach(BorrowDetails user in BorrowDetails.borrowList)
                        {
                            if(user.RegistrationId==s_registerNumber && user.Status==Status.Issued)
                            {
                                count++;
                            }
                        }
                        if(count<3)
                        {
                            System.Console.WriteLine("You can Borrow book now");
                            books.BookCount--;
                            BorrowDetails.borrowList.Add(new BorrowDetails (books.BookId,s_registerNumber,DateTime.Now,Status.Issued));
                        }
                        else
                        {
                            System.Console.WriteLine("Your book limits are achieved. Try to return the book to get new");
                        }
                    }
                    else
                    {
                        foreach(BorrowDetails book in BorrowDetails.borrowList)
                        {
                            if(bookID==book.BookId)
                            {
                               DateTime day= book.BorrowedDate.AddDays(15);
                               System.Console.WriteLine($"Book{bookID} are not availabe The books will be available at{day}");
                            }
                        }
                        
                    }
                }
            }
        }

        //ReturnBook
        public static void ReturnBook()
        {
            System.Console.WriteLine("Enter the book id to return");
            string bookId=Console.ReadLine();
            
            double amount;
            foreach(BorrowDetails borrow in BorrowDetails.borrowList)
            {
                if(borrow.BookId==bookId)
                {
                    if(s_registerNumber==borrow.RegistrationId)
                    {
                        DateTime date=borrow.BorrowedDate.AddDays(15);
                        //string a=date.ToString();

                        System.Console.WriteLine($"Your Returned date for the book {borrow.BookId} is {date}");
                        TimeSpan span=DateTime.Now.Subtract(borrow.BorrowedDate);
                        double days=span.TotalDays;
                        if(days>15)
                        {
                            amount=(days-15)*1;
                            System.Console.WriteLine($"You have to pay the amount of RS:{amount} for the book {borrow.BookId} and then return book");
                        }
                        borrow.Status=Status.Returned;
                        foreach(BookDetails book in BookDetails.bookList)
                        {
                            if(borrow.BookId==book.BookId)
                            {
                            book.BookCount++;
                            }
                        }
                      // System.Console.WriteLine("Book successfully returned ");
                }   }
                    
            }
        }

        //Borrowed History

        public static void BorrowedHistory()
        {
            foreach(BorrowDetails borrow in BorrowDetails.borrowList)
            {
                if(s_registerNumber==borrow.RegistrationId)
                {
                    System.Console.WriteLine("Borrow ID       :"+borrow.BorrowId);
                    System.Console.WriteLine("Book ID         :"+borrow.BookId);
                    System.Console.WriteLine("Registration ID :"+borrow.RegistrationId);
                    System.Console.WriteLine("Borrow Date     :"+borrow.BorrowedDate);
                    System.Console.WriteLine("Borrow Status   :"+borrow.Status);
                }
            }
        }
    }
}