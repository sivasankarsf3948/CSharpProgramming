using System;
namespace SimpleQn9
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter month :\n1.January\t2.February\t3.March\t4.April\t5.May\t6.June\t7.July\t8.August\t9.September\t10.October\t11.November\t12.December");
            string month=Console.ReadLine();
            month=month.ToLower();
            System.Console.WriteLine("Enter number of days leave in a specific month");
            int leave=int.Parse(Console.ReadLine());
            int month1=31,month2=30,month3=28,days=0,salary=0;
            switch(month)
            {
                case "january":case"march": case"may": case"july": case "august": case"october": case "december":
                {
                    
                    days=month1-leave;
                    salary=days*500;
                    System.Console.WriteLine("your salary is "+salary);
                    break;

                }
                case "april": case "june": case "september": case "november":
                {
                    
                    days=month2-leave;
                    salary=days*500;
                    System.Console.WriteLine("your salary is "+salary);
                    break;

                }
                case "february":
                {
                    
                    days=month3-leave;
                    salary=days*500;
                    System.Console.WriteLine("your salary is "+salary);
                    break;

                }
                default:
                {
                    System.Console.WriteLine("Invalid Option");
                    break;
                }
            }
            
            
        }
    }
}
