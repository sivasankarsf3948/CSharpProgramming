using System;
using System.Collections.Generic;
namespace EbBillCalculations;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to EB bill Calculator");
        Operations.MainMenu();
   /* System.Console.WriteLine("To continue press yes");
    string condition=Console.ReadLine();
    condition=condition.ToLower();
    List<EbBillCalculator> meterbox=new List<EbBillCalculator>();
    while(condition=="yes")
    {
        System.Console.WriteLine("Enter user name ");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter mobile number");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your mail id");
        string mail=Console.ReadLine();
        System.Console.WriteLine("Enter the number of units used ");
        double units=double.Parse(Console.ReadLine());

        EbBillCalculator member=new EbBillCalculator(name,phone,mail);
        meterbox.Add(member);
        System.Console.WriteLine("To continue press yes");
        condition=Console.ReadLine();
        
    }

    foreach(EbBillCalculator bill in meterbox)
    {
        System.Console.WriteLine("Username :"+bill.UserName);
        System.Console.WriteLine("MeterId  :"+bill.MeterId);
        System.Console.WriteLine("Phone    :"+bill.Phone);
        System.Console.WriteLine("MailId  :"+bill.Mail);
        System.Console.WriteLine("Units used:"+bill.UnitsUsed);
        System.Console.WriteLine("------------------------");
        System.Console.WriteLine("EB bill Amount is : "+bill.CalculateAmount(bill.UnitsUsed));
        
        System.Console.WriteLine("------------------------");
    }*/

    }
}
