using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccineApplication
{
    public static  class Operations
    {
        
        public static Beneficiary currentUser=null;
       public static void  MainMenu()
       {
        //selecting main menu
        

            bool condition=true;
            System.Console.WriteLine("Welcome to CoVax Application");
            do
            {
                System.Console.WriteLine("Select options:\n1.Beneficiary Registration\n2.Login\n3.Get Vaccine Info\n4.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                      Beneficiary.BeneficiaryRegistration();
                        break;
                    }
                    case 2:
                    {
                        Login();

                        break;
                    }
                    case 3:
                    {
                        VaccineAvailable.ShowVaccine();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Thank you! Be safe continue with vaccination updates!!");
                        condition=false;

                        break;
                    }
                }
                



            }while( condition==true);
       }

       static void Login()
       {
        int count=0;
        System.Console.WriteLine("Enter your Beneficiary Registration number");
        string regNumber=Console.ReadLine().ToUpper();
        foreach(Beneficiary regObject in Beneficiary.userList)
        {
            if(regNumber.Equals(regObject.RegistrationNumber))
            {
                System.Console.WriteLine("LogIn successful");
                currentUser=regObject;
                count++;
                SubMenu();
            }
           
        }
        if(count==0)
        {
            System.Console.WriteLine("Invalid Register number.....\nTry again or register first then Log in");
        }
        
       }

       //Submenu
       static void SubMenu()
       {
        bool condition=true;
        
         do{
            System.Console.WriteLine("Select Options:\n1.Show my Details\n2.Take Vaccination\n3.My Vaccination History\n4.Next Due Date\n5.Exit");
            int choice=int.Parse(Console.ReadLine());
            
                switch(choice)
                {
                    case 1:
                    {
                      Beneficiary.ShowMyDetails();
                        break;
                    }
                    case 2:
                    {
                        Vaccination.TakeVaccination();

                        break;
                    }
                    case 3:
                    {
                        Vaccination.MyVaccinationHistory();

                        break;
                    }
                    case 4:
                    {
                        Vaccination.NextDueDate();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Thank you! Be safe continue with vaccination updates!!");
                        condition=false;

                        break;
                    }
                }
                



            }while( condition==true);





        
       }
    }

}