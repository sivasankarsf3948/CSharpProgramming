using System;
namespace Enum1
{
public enum Gender {Default,Male,Female,TransGender}
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Select Gender options Male,Female,TransGender");
            Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine(gender1);
            //select by string or integer
            System.Console.WriteLine("Select Gender options Male,Female,TransGender");
            Gender gender2=Gender.Default;
            bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
            while(!temp || !((int)gender2<4 && (int) gender2>0))
            {
                System.Console.WriteLine("Invalid gender \n enter again");
                temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
            }
            System.Console.WriteLine(gender2);
            
            
        }
    }
}