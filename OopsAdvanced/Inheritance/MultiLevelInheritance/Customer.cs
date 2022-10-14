using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class Customer:PersonalDetails
    {
            private static int s_customerID=1000;
            public string CustomerID { get; set; }
            public double Balance { get; set; }
            
            public Customer(string aid,string name,string fatherName,Gender gender,long phone):base(aid, name, fatherName,gender,phone)
            {
                s_customerID++;
                CustomerID="CID"+s_customerID;
            }

            public void Recharge()
            {
                System.Console.WriteLine("Enter amount to recharge");
                Balance+=double.Parse(Console.ReadLine());
                
            }
            public void ShowCustomerDetail()
            {
                System.Console.WriteLine("Customer ID  "+CustomerID);
                ShowDetails();
                System.Console.WriteLine("Balance      "+Balance);

            }
            
    }
}