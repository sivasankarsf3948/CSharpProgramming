using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class CustomerDetails
    {
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();
        private static int s_customerId=1000;
        public string Name { get; set; }
        public string City { get; set; }
        public long MobileNumber { get; set; }
        public static double WalletBalance  { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        
        





        //Property
        public CustomerDetails(string name,long phone,string city,double wallet,string mail)
        {
            s_customerId++;
            Name=name;
            MobileNumber=phone;
            City=city;
            WalletBalance=wallet;
            Email=mail;
            CustomerId="CID"+s_customerId;
        }
        
        //Registration method
        public static void Registration()
        {
            System.Console.WriteLine("Enter your name ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Mobile Number");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your city name");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter your wallet balance");
            double wallet=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail id");
            string mail=Console.ReadLine();
            CustomerDetails customer=new CustomerDetails(name,phone,city,wallet,mail);
            customerList.Add(customer);
            System.Console.WriteLine("Your Customer ID is "+customer.CustomerId);
            
        }
        
        //Default method for customer list    
        
        public static void  DefaultMethod()
        {
            customerList.Add(new("Ravi",9885858588,"Chennai",50000,"ravi@gmail.com"));
            customerList.Add(new("Baskaran",9888475757,"Chennai",60000,"baskaran@gmail.com"));
            
        }
        
        
        
        
        
        















    }
}