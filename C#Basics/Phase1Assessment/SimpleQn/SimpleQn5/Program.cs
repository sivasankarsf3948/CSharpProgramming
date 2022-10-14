using System;
namespace SimpleQn5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your basic salary");
            double basicsalary=double.Parse(Console.ReadLine());
            double dearance=basicsalary*0.1;
            
            double hra=basicsalary*0.1;
            double annualsalary=(basicsalary+dearance+hra)*12;
            double tax=annualsalary*0.5;
            double annualincome=annualsalary-tax;
            System.Console.WriteLine("The annual income is "+annualincome);
            
        }
    }
}
