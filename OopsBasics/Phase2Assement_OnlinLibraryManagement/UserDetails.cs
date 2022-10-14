using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public enum Gender{Default,Male,Female,TransGender}
    public class UserDetails
    {
        public static List<UserDetails> userList=new List<UserDetails>();
        private static int s_registerNumber=3000;
        public string UserName { get; set; }
        public int Age { get; set; }
        public Gender Gender{ get; set; }
        public string Department { get; set; }
        public long MobileNumber { get; set; }
        public string MailId { get; set; }
        public string RegisterNumber { get; set; }
        
        
        
        
        
        //constructor  creation
        public UserDetails(string name,int age,Gender gender,string department,long phone,string mail)
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            UserName=name;
            Age=age;
            Gender=gender;
            Department=department;
            MobileNumber=phone;
            MailId=mail;

        }

        
        //RegistrationClass
        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Age");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your gender name");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Department name");
            string department=Console.ReadLine();
            System.Console.WriteLine("Enter your mobile number");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your e-mail id");
            string mail=Console.ReadLine();
            UserDetails user=new UserDetails(name,age,gender,department,phone,mail);
            userList.Add(user);
            System.Console.WriteLine("Your User Id is "+user.RegisterNumber);
            
            
        }
        
        
        //DefaultMethod
        public static void DefaultMethod()
        {
            userList.Add(new("Ravichandiran",21,Gender.Male,"EEE",9938388333,"ravi@gmail.com"));
            userList.Add(new("Priyadharshini",22,Gender.Female,"CSE",9938389333,"priya@gmail.com"));
        }
        
        
        
        
    }
}