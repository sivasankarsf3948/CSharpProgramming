using System;
namespace IfStatementQuestion5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Physics mark");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Chemistry mark");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Maths mark");
            int maths=int.Parse(Console.ReadLine());
            int total=physics+chemistry+maths;
            double percentage=((double)total/300)*100;
            if(percentage>=75)
            {
            System.Console.WriteLine("The candidate is eligible for admission");
            }
            else{
              System.Console.WriteLine("The candidate is not eligible for admission");  
            }
            
        }
    }
}
