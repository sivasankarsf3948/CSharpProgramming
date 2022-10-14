using System;
namespace DowhileQn4
{
    class Program{
        public static void Main(string[] args)
        {
            string condition="";
            //string s="";
            bool temp;
            do{
                System.Console.WriteLine("Enter a number");
                 int number;
                 
                 
                temp=int.TryParse(Console.ReadLine(),out number);
                //s=temp==true ?"hai":"hello";
                if(number==1||number==2||number==3||number==4||number==5|| number==6||number==7||number==8||number==9||number==10)
                {
                    System.Console.WriteLine($"The number  {number}  valid and in the range (1-10) ");
                    condition="no";
                } 
                else
                {
                    System.Console.WriteLine("The number is  invalid. If you need to continue with another number. Enter 'yes' ");
                    condition=Console.ReadLine().ToLower();
                    
                }  
            }while(condition=="yes"|| temp==false);
        }
    }
}