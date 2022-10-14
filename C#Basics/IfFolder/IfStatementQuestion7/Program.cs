using System;
namespace IfStatementQuestion7
{
class Program{
    public static void Main(string[] args)
    {
        double amount=0;
        System.Console.WriteLine("Enter customer id");
        double id=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter customer name");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter unit consumed");
        double unit=double.Parse(Console.ReadLine());
        double net_amount=0;

        //amount
        
        if(unit<=199)
        {
            amount=unit*1.20;
            System.Console.WriteLine("Amount charges @ Rs.1.20 per unit is "+amount);

        }
       
        else if(unit>=200 && unit<400)
        {
             amount=unit*1.50;
             System.Console.WriteLine("Amount charges @ Rs.1.50 per unit is "+amount);
        }
        else if(unit>=400 && unit<600)
        {
            amount=unit*1.80;
            System.Console.WriteLine("Amount charges @ Rs.1.80 per unit is "+amount);
        }
        else if(unit>=600)
        {
             amount=unit*2;
             System.Console.WriteLine("Amount charges @ Rs.2.00 per unit is "+amount);
        }
        
        
        

        //minimum bill
        if(amount<100)
        {
          System.Console.WriteLine("Your net amount is:  Rs. 100");
        }
        else if(amount>400)
        {
            double tax=amount*0.15;
            System.Console.WriteLine("Your Surcharge amount is:  Rs "+tax);
            net_amount=amount + tax;
             System.Console.WriteLine("Your net amount is:  Rs. "+net_amount);

        }

    }
}
}
