using System;
namespace BasicQuestion5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int phy_mark,che_mark,math_mark;

            //student details
            Console.WriteLine("Enter Physics mark");
            bool temp=int.TryParse(Console.ReadLine(),out phy_mark);
            Console.WriteLine("Enter Chemistry mark");
            bool data=int.TryParse(Console.ReadLine(),out che_mark);
            Console.WriteLine("Enter Maths mark");
            bool value=int.TryParse(Console.ReadLine(),out math_mark);

            //sum
            float sum=phy_mark+che_mark+math_mark;
            Console.WriteLine($"Sum of mark is         :{sum}");

            //percentage
            int percentage=((int)sum/3);
            Console.WriteLine($"Percentage of mark is  :{percentage}%");
            
            

        }
    }
}