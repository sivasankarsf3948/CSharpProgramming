using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBillCalculations
{
    public static class Operations
    {
        static EbBillCalculator currentCustomer=null;
        static List<EbBillCalculator> meterbox=new List<EbBillCalculator>();
         public static void MainMenu()
        {
           
            string condition ="yes";
            do
            {
              System.Console.WriteLine("Select Option :\n1.Register\n2.Login \n3.Exit the Application");
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
            System.Console.WriteLine("Select Options :\n1.Show customer Details\n2.Get number of units\n3.Calculate tariff\n4.Exit");
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
                GetUnits();

                break;
              }
              case 3:
              {
               Calculatetariffs();

                break;
              }
              case 4:
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

        System.Console.WriteLine("Enter user name ");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter mobile number");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your mail id");
        string mail=Console.ReadLine();
        EbBillCalculator member=new EbBillCalculator(name,phone,mail);
        meterbox.Add(member);
        System.Console.WriteLine("MeterId Number ="+member.MeterId);
           


        }

        //Login
        public static void Login()
        {
         System.Console.WriteLine("Enter your Meter Id  number");
          string number=Console.ReadLine().ToUpper();
         foreach(EbBillCalculator customer1 in meterbox)
         {
           if(number==customer1.MeterId)
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
            foreach(EbBillCalculator bill in meterbox)
            {
                System.Console.WriteLine("Username :"+bill.UserName);
                System.Console.WriteLine("MeterId  :"+bill.MeterId);
                System.Console.WriteLine("Phone    :"+bill.Phone);
                System.Console.WriteLine("MailId  :"+bill.Mail);
            } 

        }
          
          //GetNo of units
          public static void GetUnits()
          {
            System.Console.WriteLine("Enter the number of units used ");
             double units=double.Parse(Console.ReadLine());
             currentCustomer.UnitsUsed=units;
             System.Console.WriteLine("Units used are "+currentCustomer.UnitsUsed);
          }

          //Calculatetariffs
          public static void Calculatetariffs()
          {
              double amount=0;

                if(currentCustomer.UnitsUsed<=100)
                {
                amount=0;
                }
                else if(currentCustomer.UnitsUsed>100 &&currentCustomer.UnitsUsed<=200)
                {
                amount=currentCustomer.UnitsUsed*3;
                }
                else if(currentCustomer.UnitsUsed>200 &&currentCustomer.UnitsUsed<=400)
                {
                amount=currentCustomer.UnitsUsed*5;
                }
                else{
                amount=currentCustomer.UnitsUsed*6;
                }
                System.Console.WriteLine("The EB bill Amount was :"+amount);
        
          }

        
       
    }
}