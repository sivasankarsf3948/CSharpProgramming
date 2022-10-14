using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement
{
    public enum BloodGroup{Default,A_Positive,B_Positive,O_Positive,AB_positive}
    public  class UserRegistration
    {
        public  static List <UserRegistration> userList=new List<UserRegistration>();
        private static int s_donorNumber=1000;
        public string Name { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        public BloodGroup Blood { get; set; }
        public DateTime DonationDate { get; set; }
        public int DonorNumber { get; set; }
        
        
        
        
        
       public UserRegistration(string name,int age,long phone,BloodGroup blood,DateTime donationDate) 
       {
        s_donorNumber++;
        Name=name;
        Age=age;
        Phone=phone;
        Blood=blood;
        DonationDate=donationDate;
        DonorNumber=s_donorNumber;


       }
        
        
        
        
        
        
        public static void Registration()
        {
            System.Console.WriteLine("Enter Donor Name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your age");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mobile number ");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your blood group ");
            BloodGroup blood=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter last donation date as 'dd/mm/yyyy'");
            DateTime donationDate=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            UserRegistration donor=new UserRegistration(name,age,phone,blood,donationDate);
            userList.Add(donor);
            System.Console.WriteLine("Your donor ID is   :"+donor.DonorNumber);
            System.Console.WriteLine("Registration is successfull");

            
            
        }

        //Fetch donor details
        public static void FetchDonorDetails()
        {
            System.Console.WriteLine("Enter the blood group needed");
            BloodGroup  blood=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
            foreach(UserRegistration user in userList)
            {
                if(user.Blood==blood)
                {
                    System.Console.WriteLine("Donor name is      "+user.Name);
                    System.Console.WriteLine("Donor mobile number"+user.Phone);
                }
            }
            
        }
        
        
        



        
    }
}