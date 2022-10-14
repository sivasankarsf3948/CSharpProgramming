using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankLibrary
{
    public enum Gender {Default,Male,Female,TransGender};
    public enum AccountMode{Default,SB,FD,RD};
    public class AccountOpening
    {
        private static int s_accountnumber=3000;
        public string AccountNumber { get;  }
        
        
        public string Name { get; set; }//Auto property
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public AccountMode AccountType { get; set; }
        public double Balance { get; set; }
        
        
        
       
        
        public AccountOpening(string name,string fathername,DateTime dob,Gender gender,AccountMode accountType)
        {
            s_accountnumber++;
            AccountNumber="SF"+s_accountnumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            //AccountType=accountType;
           

        }

        //Deposit Method
        
        public void Deposit()
        {
          System.Console.WriteLine("Enter your amount to deposit :");
          double amount=double.Parse(Console.ReadLine());
          Balance=amount+Balance;
          System.Console.WriteLine($"Your amount RS. {Balance} is deposited");
        }

        //Withdraw method
        public void Withdraw()
        {
            System.Console.WriteLine("Enter the amount to withdrwal");
            double withdrawl=double.Parse(System.Console.ReadLine());
            Balance=Balance-withdrawl;
            System.Console.WriteLine($"Amount is debited.Balance amount is {Balance} ");
        }
        
        //Show method
        public void Show()
        {
            System.Console.WriteLine($"Your Balance amount is {Balance} ");
        }
    }
}