using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountCreation
{
  
    public  static class Operations
    {
          static AccountOpening currentCustomer=null;
        static List<AccountOpening> customerList=new List<AccountOpening>() ;
        public static void MainMenu()
        {
           
            string condition ="yes";
            do
            {
              System.Console.WriteLine("Select Option :\n1.Account opening\n2.Login to NetBanking\n3.Exit the Application");
              int option=int.Parse(Console.ReadLine());
              switch(option)
              {
                case 1:
                {
                    Registration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                  System.Console.WriteLine("Thank you");
                    condition="no";
                    break;
                }
                default:
                {

                    break;
                }
              }
              
            }while(condition=="yes");
            
        }


        //SubMenu
        public static void SubMenu()
        {
          string condition="yes";
          do
          {
            System.Console.WriteLine("Select Options :\n1.Show my account Details\n2.Deposit\n3.Withdrawl\n4.Show Balance\n5.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
              case 1:
              {
                ShowDetails();
                break;
              }
              case 2:
              {
                Deposit();

                break;
              }
              case 3:
              {
               Withdrawl();

                break;
              }
              case 4:
              {
               ShowBalance();
                break;
              }
              case 5:
              {
                condition="no";
                break;
              }

            }

          }while(condition=="yes");
       

        }

        //Registration
        public static void Registration()
        {

            System.Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
           
            System.Console.WriteLine("Enter your Father name");
            string fathername=Console.ReadLine();
          
            System.Console.WriteLine("Enter your date of birth as dd/mm/yyyy");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            
            System.Console.WriteLine("Enter your gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            
           
            System.Console.WriteLine("Enter your mode of account");
            AccountMode accountType=Enum.Parse<AccountMode>(Console.ReadLine(),true);
           
           AccountOpening customer =new AccountOpening(name,fathername,dob,gender,accountType);
           customerList.Add(customer);
           System.Console.WriteLine("AccountNumber ="+customer.AccountNumber);
           


        }

        //Login
        public static void Login()
        {
         System.Console.WriteLine("Enter your account number");
          string number=Console.ReadLine().ToUpper();
         foreach(AccountOpening customer1 in customerList)
         {
           if(number==customer1.AccountNumber)
          {
            System.Console.WriteLine("-----Logged in-----");
            currentCustomer=customer1;
            SubMenu();
          }
         }
         
          
          

        }

        //ShowDetails

        public static void ShowDetails()
        {
             foreach(AccountOpening customer1 in customerList)
            {
                 System.Console.WriteLine("Your name is             :"+customer1.Name);
                 System.Console.WriteLine("Your father name is      :"+customer1.FatherName);
                 System.Console.WriteLine("Your gender is           :"+customer1.Gender);
                 System.Console.WriteLine("Your type of account is  :"+customer1.AccountType);
                 System.Console.WriteLine("Your date of birth  is   :"+customer1.DOB.ToShortDateString());
                 System.Console.WriteLine("Your Balance is          :"+customer1.Balance);
                 System.Console.WriteLine("Your Account number is   :"+customer1.AccountNumber);
                
            }
        }

        //Deposit Method

        public static void Deposit()
        {
           
          System.Console.WriteLine("Enter your amount to deposit :");
          double amount=double.Parse(Console.ReadLine());
          currentCustomer.Balance=amount+currentCustomer.Balance;
          System.Console.WriteLine($"Your amount RS. {currentCustomer.Balance} is deposited");
        }

        //Withdraw method
        public static void Withdrawl()
        {
            System.Console.WriteLine("Enter the amount to withdrwal");
            double withdrawl=double.Parse(System.Console.ReadLine());
           currentCustomer.Balance=currentCustomer.Balance-withdrawl;
            System.Console.WriteLine($"Amount is debited.Balance amount is {currentCustomer.Balance} ");
        }

        
       //Show Balance method
        public static void ShowBalance()
        {
            System.Console.WriteLine($"Your Balance amount is {currentCustomer.Balance} ");
        }
        
        

        
    }
}