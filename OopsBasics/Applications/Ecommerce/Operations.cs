using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Operations
    {
        public static string s_currentUser=null;
        public static void  MainMenu()
       {
        //selecting main menu
        

            bool condition=true;
            System.Console.WriteLine("Welcome to Ecommerce Application");
            do
            {
                System.Console.WriteLine("Select options:\n1.Customer Registration\n2.Login and Purchase\n3.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                      CustomerDetails.Registration();
                        break;
                    }
                    case 2:
                    {
                        LoginAndPurchase();

                        break;
                    }
            
                    case 3:
                    {
                        System.Console.WriteLine("Thank you! Enjoy with new products!! Offer end soon");
                        condition=false;

                        break;
                    }
                }
                



            }while( condition==true);
       }




       //Login
       public static void LoginAndPurchase()
       {
        System.Console.WriteLine("Enter your customer Id");
        string customerId=Console.ReadLine();
        int count=0;
        foreach(CustomerDetails customer in CustomerDetails.customerList)
        {
            if(customerId==customer.CustomerId)
            {
                s_currentUser=customer.CustomerId;
                System.Console.WriteLine("Logged in successfully");
                SubMenu();
                count++;

            }
        }
        if(count==0)
        {
            System.Console.WriteLine("Invalid customer Id ");
        }
            
       }

       //SubMenu
        public static void  SubMenu()
       {
        //selecting main menu
        

            bool condition=true;
            
            do
            {
                System.Console.WriteLine("Select options:\n1.Purchase\n2.Order History\n3.CancelOrder\n4.WalletBalance\n5.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                      ProductClass.Purchase();
                        break;
                    }
                    case 2:
                    {
                       OrderDetails.OrderHistory();

                        break;
                    }
                    case 3:
                    {
                       ProductClass.CancelOrder();
                        break;
                    }
                    case 4:
                    {
                      // WalletBalance();
                      System.Console.WriteLine("Your wallet balance is   :"+CustomerDetails.WalletBalance );

                        break;
                    }
            
                    case 5:
                    {
                        System.Console.WriteLine("Thank you! Enjoy with new products!! Offer end soon");
                        condition=false;

                        break;
                    }
                }
                



            }while( condition==true);
       }

      



    }
}