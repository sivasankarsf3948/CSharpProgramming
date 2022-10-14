using System;
namespace SwitchQuestion3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a month number ");
            System.Console.WriteLine("1 :January\t2 :February\t3 :March\t4 :April\t5 :May\t6 :June\t7 :July\t8 :August\t9 :September\t10 :October\t11:November\t12 :December");
            int number=int.Parse(Console.ReadLine());
            int choice=0;
            if(number==1 || number==3 ||number==5 || number==7 ||number==8 || number==10 || number==12)
            {
                choice=1;
            }
            else if(number==4 || number==6 ||number==9 || number==11)
            {
                choice=2;
            }
            else if(number==2)
            {
                choice=3;
            }
        
            switch(choice)
            {
                case 1:
                {
                   System.Console.WriteLine("This month have 31 days");
                   break;
                }
                case 2:
                {
                   System.Console.WriteLine("This month have 30 days");
                   break;
                }case 3:
                {
                   System.Console.WriteLine("If it is leap year it has 29  days otherwise it has 28 days");
                   break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid input Enter a valid input");
                    break;
                }
            }
            
        }
    }
}
    

