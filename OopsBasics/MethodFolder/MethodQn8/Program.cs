using System;
namespace MethodQn8
{
    class Program
    {
        public static void Main(string[] args)
        {
            

          GetDetails();


            void GetDetails()
            {
             System.Console.WriteLine("Enter mark 1");
             int mark1=int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter mark 2");
             int mark2=int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter mark 3");
             int mark3=int.Parse(Console.ReadLine());
             int percent=Percentage(mark1,mark2,mark3);
             System.Console.WriteLine("\nThe Marks are ");
             System.Console.WriteLine("\nMark 1 :"+mark1);
             System.Console.WriteLine("Mark 2 :"+mark2);
             System.Console.WriteLine("Mark 3 :"+mark3);
             System.Console.WriteLine("\nPercentage is :"+percent+"%\n");
             
            }

            int Percentage(int mark1,int mark2,int mark3)
            {
                int total=mark1+mark2+mark3;
                int percentage=total/3;
                return percentage;
            }


        }
    }
}
