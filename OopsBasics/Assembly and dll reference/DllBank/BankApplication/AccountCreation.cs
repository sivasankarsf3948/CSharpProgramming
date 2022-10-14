using System;
using System.Collections.Generic;
using BankLibrary;
namespace BankApplication
{
    public class AccountCreation{
        public static void MainMenu()
        {
           System.Console.WriteLine("Are you willing to open an account with this bank");
            string willing=Console.ReadLine();
            
            List<AccountOpening> customerList=new List<AccountOpening>() ;
           
            while(willing=="yes")
            {
            
            System.Console.WriteLine("Customer Details ");
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
           System.Console.WriteLine("Are you willing to open an account with this bank");
           willing=Console.ReadLine();
          
            foreach(AccountOpening customer1 in customerList)
            {
                 System.Console.WriteLine("Your name is             :"+customer1.Name);
                 System.Console.WriteLine("Your father name is      :"+customer1.FatherName);
                 System.Console.WriteLine("Your gender is           :"+customer1.Gender);
                 System.Console.WriteLine("Your type of account is  :"+customer1.AccountType);
                 System.Console.WriteLine("Your date of birth  is   :"+customer1.DOB.ToShortDateString());
                 System.Console.WriteLine("Your Balance is          :"+customer1.Balance);
                 System.Console.WriteLine("Your Account number is   :"+customer1.AccountNumber);
                 customer1.Deposit();
                 System.Console.WriteLine("-----------");
                 customer1.Withdraw();
                 System.Console.WriteLine("-----------");
                 customer1.Show();
                 System.Console.WriteLine("-----------");
            }
           
            }
             
            
        }
    }
}
