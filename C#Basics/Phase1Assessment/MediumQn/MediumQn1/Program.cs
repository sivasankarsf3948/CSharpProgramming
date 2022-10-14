using System;
namespace MediumQn1{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your basic salary");
            double basic=int.Parse(Console.ReadLine());
            double hra=0,da=0,gross=0,tax=0,insurance=0,takehome=0,annualsalary=0;
            if(basic<=10000)
            {
               hra=basic*0.2;
               da=basic*0.8;
               gross=basic+hra+da;
            }
            else if(basic<=20000)
            {
              hra=basic*0.25;
               da=basic*0.90;
               gross=basic+hra+da;  
            }
            else{
                hra=basic*0.30;
               da=basic*0.95;
               gross=basic+hra+da;
            }
             annualsalary=gross*12;
            tax=annualsalary*0.06;
            insurance=annualsalary*0.01;
            takehome=annualsalary-tax-insurance;
            System.Console.WriteLine("Annual gross salary is           :"+annualsalary);
            System.Console.WriteLine("The take home salary per year is :"+takehome);
        }
    }
}
