using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccineApplication
{
    public enum Gender{Default,Male,Female,TransGender}
    public class Beneficiary
    {
         
        public static List<Beneficiary>userList=new List<Beneficiary>();
       
        private static int s_registerNumber=1000;
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string RegistrationNumber { get; set; }
        public long MobileNumber { get; set; }
        public string City { get; set; }
        //public DateTime Dob { get; set; }
        public int  Age { get; set; }
        
        
        
        
        
        
        
        //Constructor
        public Beneficiary(string name,Gender gender,int age,long phone,string city)
        {
            s_registerNumber++;
            RegistrationNumber="BID"+s_registerNumber;
            Name=name;
            Gender=gender;
            Age=age;
            MobileNumber=phone;
            City=city;
            
        }
        
        public Beneficiary(string data)
        {
            string[] values=data.Split(',');
            s_registerNumber=int.Parse(values[0].Remove(0,3));
            RegistrationNumber=values[0];
            Name=values[1];
            Gender=Enum.Parse<Gender>(values[2]);
            Age=int.Parse(values[3]);
            MobileNumber=long.Parse(values[4]);
            City=values[5];
           // RegistrationNumber="BID"+s_registerNumber;
        }
        
        
        //RegistrationMethod 
        public  static void BeneficiaryRegistration()
        {
            System.Console.WriteLine("Enter Your name ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your age ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your gender ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Mobile  number ");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your city");
            string city =Console.ReadLine();
            Beneficiary user=new Beneficiary(name,gender,age,phone,city);
            userList.Add(user);
            System.Console.WriteLine("Your Registratin Number is   : "+user.RegistrationNumber);
            
        }
        
        //Default user method
        public  static void DefaultMethod()
        {
            userList.Add(new Beneficiary("Ravichandiran",Gender.Male,21,8484483,"Chennai"));
            userList.Add(new Beneficiary("Baskaran",Gender.Male,21,987683,"Chennai"));
          //  VaccineAvailable vaccine=new VaccineAvailable();
          
        }


        //Show my details
        public static void ShowMyDetails()
        {
            System.Console.WriteLine("Beneficiary user detais are :");
            System.Console.WriteLine("Register number   :"+Operations.currentUser.RegistrationNumber);
             System.Console.WriteLine("Name             :"+Operations.currentUser.Name);
            System.Console.WriteLine("Gender            :"+Operations.currentUser.Gender);
            System.Console.WriteLine("Mobile number     :"+Operations.currentUser.MobileNumber);
            System.Console.WriteLine("City              :"+Operations.currentUser.City);
            System.Console.WriteLine("Age               :"+Operations.currentUser.Age);
        }
        
    }
}