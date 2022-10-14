using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement
{
    public class Operations
    {
        public static int currentDonorId;
       public static void MainMenu()
        {
            bool condition=true;
            System.Console.WriteLine("Welcome to Blood Bank Application");
            do
            {
                System.Console.WriteLine("Select options:\n1.User Registration\n2.Login\n3.Fetch Donor Details\n4.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                      UserRegistration.Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();

                        break;
                    }
                    case 3:
                    {
                        UserRegistration.FetchDonorDetails();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Thank you! Donate Blood Save Life");
                        condition=false;

                        break;
                    }
                }
                



            }while( condition==true);
       }

      //user login method
        public static void Login()
        {
            int count=0;
            System.Console.WriteLine("Enter your donor Id ");
            int donorId=int.Parse(Console.ReadLine());
            foreach(UserRegistration user in UserRegistration.userList)
            {
                if(donorId==user.DonorNumber)
                {
                    count++;
                    System.Console.WriteLine("Logged in successfull");
                    SubMenu();
                    currentDonorId=donorId;
                }
            }
            if(count==0)
            {
                System.Console.WriteLine("Invalid donor id...Try again");
            }
        }

       //Submenu
       static void SubMenu()
       {
        bool condition=true;
        
         do{
            System.Console.WriteLine("Select Options:\n1.Donate Blood\n2.Donation History\n3.Next eligible Date\n4.Exit");
         int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                      Donation.DonateBlood();
                        break;
                    }
                    case 2:
                    {
                        Donation.DonnationHistory();

                        break;
                    }
                    case 3:
                    {
                        Donation.NextEligibledate();

                        break;
                    }
                   
                    case 4:
                    {
                        System.Console.WriteLine("Thank you!! Continue with blood donation");
                        condition=false;

                        break;
                    }
                }
                



            }while( condition==true);

        }
          
        
    }
}